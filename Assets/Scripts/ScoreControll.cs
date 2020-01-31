using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControll : MonoBehaviour
{
    public Text scoreText;
    private int scoreValue;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Product")
        {
            Destroy(other.gameObject);
            addScore(1);
        }
    }

    void addScore(int valueToAdd)
    {
        scoreValue += valueToAdd;
        scoreText.text = "Score: " + scoreValue;
    }
}