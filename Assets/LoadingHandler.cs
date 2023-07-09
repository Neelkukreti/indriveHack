using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingHandler : MonoBehaviour
{
    public GameObject gameObject;
    public FindRiderHandler findRider;
    public GameObject findingAnimation;
    public GameObject backButton;
    public RiderPannelPopUp riderPannel;
    public GameObject moreDeets;
    public GameObject anotherDriver;
    public GameObject driverPannel;
    // Start is called before the first frame update
    public void loadNow()
    {
        Invoke("turnOff", 2f);
        
    }

    void turnOff()
    {
        gameObject.SetActive(false);
        findingAnimation.SetActive(false);
        backButton.SetActive(true);
        moreDeets.SetActive(true);
        anotherDriver.SetActive(true);
        driverPannel.SetActive(true);
        driver();
    }

    public void driver()
    {
        findRider.getADriver();
        riderPannel.StartAnimation();
    }
}
