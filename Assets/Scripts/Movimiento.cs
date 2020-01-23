using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float force = 5;
    public float forceJump = 4;
    private Rigidbody rb;
    public GameObject newObj;
    public static bool isAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            Saltar();

    }
    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);
        }
    }

    private void Saltar()
    {
        if (rb && Mathf.Abs(rb.velocity.y) < 0.05f)
        {
            rb.AddForce(0, forceJump, 0, ForceMode.Impulse);
        }

    }



    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Chocaron");
    }

    }



