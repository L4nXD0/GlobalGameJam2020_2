using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRandom : MonoBehaviour
{
    public float breakTimer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(breakOneOfInSeconds(GameObject.FindGameObjectsWithTag("Maschine"), breakTimer));
    }

    IEnumerator breakOneOfInSeconds(GameObject[] breakableMaschines, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        while (true)
        {
            while (true)
            {
                bool breakableFound = false;
                //checks if there is a breakable object left
                foreach (GameObject breakable in breakableMaschines)
                {
                    if (breakable.GetComponent<ConveyorControll>().working)
                    {
                        breakableFound = true;
                        break;
                    }
                }

                if (!breakableFound) break;

                //breaks random breakable object
                int i = Random.Range(0, breakableMaschines.Length);
                if (breakableMaschines[i].GetComponent<ConveyorControll>().working)
                {
                    breakableMaschines[i].GetComponent<ConveyorControll>().working = false;
                    breakableMaschines[i].GetComponent<ConveyorControll>().switchArrows();
                    break;
                }
            }
            yield return new WaitForSeconds(seconds);
        }
    }
}
