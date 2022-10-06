using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private new Rigidbody rigidbody;
    //public Rigidbody Rigidbody => rigidbody;
    //private int score;
    //public int Score => score;

    private Transform cameraTrans;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.mass = 100f;
        cameraTrans = FindObjectOfType<Camera>().GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddScore()
    {
        //score++;
    }
}
