using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowForceBar : MonoBehaviour
{
    public GameObject guide;
    float throwF;
    float maxF;
    public Image scaleBarImage;
    //GameObject scaleBarImage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(guide.transform.childCount > 0) { 
            throwF = guide.GetComponentInChildren<PickUp>().throwForce;
            maxF = guide.GetComponentInChildren<PickUp>().throwForceCap;
            scaleBarImage.rectTransform.localScale = new Vector3( throwF/maxF,1, 1);
        }
        else
        {
            scaleBarImage.rectTransform.localScale = new Vector3(0, 1, 1);
        }

    }
}
