using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private new Rigidbody rigidbody;

    [SerializeField] float sideSpeed = 45f;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizInput=Input.GetAxis("Horizontal");
        rigidbody.AddForce(Vector3.right*horizInput*sideSpeed*Time.fixedDeltaTime,ForceMode.VelocityChange);

    }


}
