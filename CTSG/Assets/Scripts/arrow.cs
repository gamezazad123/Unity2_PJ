using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrow : MonoBehaviour
{
    public Sprite newimage;
    public Button button;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeimagebutton()
    {
        button.image.sprite = newimage;
    }
}
