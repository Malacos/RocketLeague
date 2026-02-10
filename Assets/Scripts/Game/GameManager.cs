using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public Transform ballSpawnPoint;
    public Transform[] carSpawnPoints;
    private int team1Score = 0;
    private int team2Score = 0;
    private float matchTime = 300f;
    private float timeRemaining;
    private bool isMatchActive = true;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    private void Start() {
        timeRemaining = matchTime;
    }

    private void Update() {
        if (isMatchActive) {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0) {
                EndMatch();
            }
        }
    }

    public void ScoreGoal(int team) {
        if (team == 1) {
            team1Score++;
        } else if (team == 2) {
            team2Score++;
        }
        Debug.Log("Team " + team + " scored! Score: " + team1Score + " - " + team2Score);
        ResetBall();
    }

    private void ResetBall() {
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        if (ball != null) {
            ball.transform.position = ballSpawnPoint.position;
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            if (rb != null) {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }

    private void EndMatch() {
        isMatchActive = false;
        Debug.Log("Match ended! Final Score: Team 1: " + team1Score + " - Team 2: " + team2Score);
    }

    public int GetTeam1Score() {
        return team1Score;
    }

    public int GetTeam2Score() {
        return team2Score;
    }

    public float GetTimeRemaining() {
        return timeRemaining;
    }

    public bool IsMatchActive() {
        return isMatchActive;
    }
}