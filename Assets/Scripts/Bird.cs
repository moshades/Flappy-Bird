using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public AudioSource hitSFX;
    public LogicManager logic;
    public Animator wing;
    public bool alive = true;
    public float flapStrength;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        wing = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive) {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            wing.SetTrigger("flap");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitSFX.Play();
        logic.gameOver();
        alive = false;
    }
}
