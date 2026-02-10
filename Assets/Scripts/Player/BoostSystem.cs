using System;
using UnityEngine;

public class BoostSystem : MonoBehaviour
{
    public float boostAmount = 100f;
    public float currentBoost;
    public float boostDuration = 5f;

    private bool isBoosting = false;
    private float originalSpeed;
    public float boostedSpeed = 20f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentBoost = boostAmount;
        originalSpeed = rb.velocity.magnitude;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && !isBoosting && currentBoost > 0)
        {
            StartCoroutine(Boost());
        }
    }

    private System.Collections.IEnumerator Boost()
    {
        isBoosting = true;
        currentBoost -= boostedSpeed * Time.deltaTime;

        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, boostedSpeed);

        yield return new WaitForSeconds(boostDuration);

        isBoosting = false;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, originalSpeed);
    }
}