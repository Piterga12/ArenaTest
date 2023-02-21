//using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BarrierController : MonoBehaviour
{
    public GameObject barrier;
    public GameObject barrier1;
    public GameObject barrier2;
    public GameObject barrier3;
    public GameObject barrier4;
    public GameObject barrier5;

    public GameObject Light1;
    public GameObject Light2;

    public bool b = false;
    public bool b1 = false;
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
        if(!b && barrier.transform.position.y < 13.24f)
        {
            barrier.transform.position = new Vector3(barrier.transform.position.x, barrier.transform.position.y + 0.3f, barrier.transform.position.z);
        }
        else if(b && barrier.transform.position.y > -192)
        {
            barrier.transform.position = new Vector3(barrier.transform.position.x, barrier.transform.position.y - 0.3f, barrier.transform.position.z);
        }


        if (b1 && barrier1.transform.position.y > -192)
        {
            barrier1.transform.position = new Vector3(barrier1.transform.position.x, barrier1.transform.position.y - 0.3f, barrier1.transform.position.z);
        }
        if (b3 && barrier3.transform.position.y > -192)
        {
            barrier3.transform.position = new Vector3(barrier3.transform.position.x, barrier3.transform.position.y - 0.3f, barrier3.transform.position.z);
            barrier4.transform.position = new Vector3(barrier4.transform.position.x, barrier4.transform.position.y - 0.3f, barrier4.transform.position.z);
        }
        if (b2 && barrier2.transform.position.y > -192)
        {
            barrier2.transform.position = new Vector3(barrier2.transform.position.x, barrier2.transform.position.y - 0.3f, barrier2.transform.position.z);
        }
        if (b4 && barrier5.transform.position.y > -192)
        {
            barrier5.transform.position = new Vector3(barrier5.transform.position.x, barrier5.transform.position.y - 0.3f, barrier5.transform.position.z);
        }
    }

    public void OnBarrier(InputValue value)
    {
        b = true;
    }
    public void OnNoBarrier(InputValue value)
    {
        b = false;
    }
    public void OnBarrier1(InputValue value)
    {
        b1 = true;
    }
    public void OnBarrier2(InputValue value)
    {
        b2 = true;
        Light1.SetActive(true);
        Light2.SetActive(true);
    }
    public void OnBarrier3(InputValue value)
    {
        b3 = true;
    }
    public void OnBarrier4(InputValue value)
    {
        b4 = true;
    }
}
