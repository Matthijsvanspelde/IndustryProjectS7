using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarChanger : MonoBehaviour
{
    public bool starFilled; 

    public Sprite filledStar;
    public Sprite greyStar;

    private void Start()
    {
        starFilled = true;
    }

    void Update()
    {
        if(starFilled == true)
        {
            this.GetComponent<Image>().sprite = filledStar;
        }
        else if (starFilled == false)
        {
            this.GetComponent<Image>().sprite = greyStar;
        }
    }
}
