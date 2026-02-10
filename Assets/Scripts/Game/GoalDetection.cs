using UnityEngine;

public class GoalDetection : MonoBehaviour
{
    public Transform goalZone;
    public GameObject ball;
    
    void Update()
    {
        if (IsBallInGoal())
        {
            HandleGoalScored();
        }
    }
    
    bool IsBallInGoal()
    {
        // Check if the ball is within the goal zone
        return ball.transform.position.x >= goalZone.position.x - (goalZone.localScale.x / 2) &&
               ball.transform.position.x <= goalZone.position.x + (goalZone.localScale.x / 2) &&
               ball.transform.position.z >= goalZone.position.z - (goalZone.localScale.z / 2) &&
               ball.transform.position.z <= goalZone.position.z + (goalZone.localScale.z / 2);
    }
    
    void HandleGoalScored()
    {
        // Logic to handle goal scoring
        Debug.Log("Goal Scored!");
        // Add further logic to update scores, etc.
    }
}