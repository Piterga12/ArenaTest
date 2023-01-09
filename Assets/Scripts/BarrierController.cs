using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BarrierController : MonoBehaviour
{
    public GameObject barrier2;
    public GameObject barrier3;
    public GameObject barrier4;

    public GameObject Light1;
    public GameObject Light2;

    public bool b2 = false;
    public bool b3 = false;
    public bool b4 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (b3 && barrier3.transform.position.y > -22)
        {
            barrier3.transform.position = new Vector3(barrier3.transform.position.x, barrier3.transform.position.y - 0.1f, barrier3.transform.position.z); ;
        }
        if (b2 && barrier2.transform.position.y > -22)
        {
            barrier2.transform.position = new Vector3(barrier2.transform.position.x, barrier2.transform.position.y - 0.1f, barrier2.transform.position.z); ;
        }
        if (b4 && barrier4.transform.position.y > -22)
        {
            barrier4.transform.position = new Vector3(barrier4.transform.position.x, barrier4.transform.position.y - 0.1f, barrier4.transform.position.z); ;
        }
    }

    public void OnBarrier2(InputValue value)
    {
        b2 = true;
    }
    public void OnBarrier3(InputValue value)
    {
        b3 = true;
        Light1.SetActive(true);
        Light2.SetActive(true);
    }
    public void OnBarrier4(InputValue value)
    {
        b4 = true;
    }
}
