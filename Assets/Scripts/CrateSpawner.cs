using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    public GameObject crate;
    public float crateDelay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCrate(crateDelay));
    }

    IEnumerator SpawnCrate(float seconds)
    {
        while (true)
        {
            Instantiate(crate, transform);
            yield return new WaitForSeconds(seconds);
        }
    }
}
