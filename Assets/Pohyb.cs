using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pohyb : MonoBehaviour
{
    private float SPEED = 1;
    public Camera mojeCamera;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            //transform.position += Time.delta * Vector3.rigth;
            transform.Rotate(0, 90f, 0);
        }
        if (Input.GetKeyDown("left"))
        {
            // transform.position += Time.delta * Vector3.left;
            transform.Rotate(0, -90f, 0);
        }
        if (Input.GetKeyDown("up"))
        {
            //transform.position += Time.delta * Vector3.foward;
            transform.position += SPEED * gameObject.transform.forward;
        }
        if (Input.GetKeyDown("down"))
        {
            transform.position -= SPEED * gameObject.transform.forward;
            //transform.position += Time.delta * Vector3.back;
        }

        mojeCamera.transform.position = transform.position;
        mojeCamera.transform.rotation = transform.rotation;
    }
}

