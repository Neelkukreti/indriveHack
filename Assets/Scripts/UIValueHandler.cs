using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIValueHandler : MonoBehaviour
{

    //public GameObject targetGameObject; // Reference to the target GameObject with the UI Text component
    public Text priceVlaue;
    public Text tripTime;
    public Pathfinder pathFinder;

    void Start()
    {
       // SetPriceValue("20","15");
    }

    void Update()
    {
        if(pathFinder.currentLocation == 1)
        {
            if(pathFinder.isCheap)
            {
                setPriceValue("29", "13");
            }
            else
            {
                setPriceValue("40", "20");
            }

        }
        if (pathFinder.currentLocation == 2)
        {
            if (pathFinder.isCheap)
            {
                setPriceValue("40", "20");
            }
            else
            {
                setPriceValue("50", "24");
            }

        }
        if (pathFinder.currentLocation == 3)
        {
            if (pathFinder.isCheap)
            {
                setPriceValue("20", "10");
            }
            else
            {
                setPriceValue("20", "10");
            }

        }
        if (pathFinder.currentLocation == 4)
        {
            if (pathFinder.isCheap)
            {
                setPriceValue("29", "13");
            }
            else
            {
                setPriceValue("38", "18");
            }

        }
    }

    public void setPriceValue(string price, string timeMin)
    {
        priceVlaue.text = "$" + price;
        tripTime.text = timeMin + " min";

          
    }
}
 