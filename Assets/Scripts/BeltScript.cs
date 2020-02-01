using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltScript : MonoBehaviour
{
    public float beltSpeed;
    public GameObject conveyorBelt;

    public Vector3 localForward;

    // Start is called before the first frame update
    void Start()
    {
        localForward = transform.TransformDirection(Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay (Collider other)
    {
        if (conveyorBelt.GetComponent<ConveyorControll>().working)
        {
            other.transform.position += localForward * beltSpeed * Time.deltaTime;
        }
    }
}
