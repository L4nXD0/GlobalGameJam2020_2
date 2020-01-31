using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float throwForceStart = 0;
    float throwForceIncrement = 5;
    public float throwForce;
    Vector3 objectPos;
    float distance;

    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;
    public int throwForceCap = 800;


    void Start()
    {
        throwForce = throwForceStart;
    }

    void Update()
    {
        distance = Vector3.Distance(item.transform.position, tempParent.transform.position);

        if (Input.GetMouseButtonDown(0))
        {
            if (distance < 2f)
            {
                isHolding = true;
                throwForce = throwForceStart;
                item.GetComponent<Rigidbody>().useGravity = false;
                item.GetComponent<Rigidbody>().detectCollisions = true;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            isHolding = false;
        }
        
        if (Input.GetMouseButton(1))
        {
            if (throwForce < throwForceCap)
            {
                throwForce += throwForceIncrement;
            }
        }

        if (distance > 2f)
        {
            isHolding = false;
        }
        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);

            if (Input.GetMouseButtonUp(1)) //down
            {
                item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward*throwForce);
                isHolding = false;
            }
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;
        }
    }
/*
    void OnMouseDown()
    {
        if (distance < 2f)
        {
            isHolding = true;
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }

    void OnMouseUp()
    {
        isHolding = false;
    }*/
}
