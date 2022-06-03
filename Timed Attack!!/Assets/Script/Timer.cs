using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 5;
    public bool takinngAway = false;


    private void Start() 
    {
        textDisplay.GetComponent<Text>().text = "0" +secondsLeft;
    }

    private void Update() 
    {
        if (takinngAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takinngAway =true;
        yield return new WaitForSeconds(1);
        secondsLeft = 1;
        textDisplay.GetComponent<Text>().text = "0" + secondsLeft;
        takinngAway = false;
    }

}
