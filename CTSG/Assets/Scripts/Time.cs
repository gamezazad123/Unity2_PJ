using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    public GameObject TheDisplay;
    public int hour;
    public int minutes;
    public int seconds;
    // Start is called before the first frame update
    void Start()
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        TheDisplay.GetComponent<Text>().text = "" + hour + ":" + minutes;
    }

    // Update is called once per frame
    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        TheDisplay.GetComponent<Text>().text = "" + hour + ":" + minutes;
    }
}
