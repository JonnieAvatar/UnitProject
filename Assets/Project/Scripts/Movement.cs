using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer.material.color = Color.green;
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(1, 0, 0);
        }
    }



}
