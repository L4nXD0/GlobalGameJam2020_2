using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorControll : MonoBehaviour
{
    public bool working;
    // Start is called before the first frame update

    private void Start()
    {
        working = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hammer")
        {
            working = !working;
            switchArrows();
        }
    }

    public void switchArrows()
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.tag == "Arrow")
            {
                if (child.gameObject.activeSelf) child.gameObject.SetActive(false);
                else child.gameObject.SetActive(true);
            }
        }
    }
}
