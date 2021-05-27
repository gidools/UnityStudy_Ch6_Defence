using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private float time;
    private int intTime;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        intTime = (int)time;
        scoreText.text = "Score : " + intTime.ToString();
    }
}
