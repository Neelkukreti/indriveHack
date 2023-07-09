using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FindRiderHandler : MonoBehaviour
{
    public string[] driverNames; // = ["John Doe"]; //, "Harry Patel", "David Blaine", "Graham Bell"];
    public string[] driverRatngs; // = "4.7"; //, "4.2", "4.1", "4.9"];
    public string[] driverFiveStars; // = "70"; //, "40", "30", "100"];
    public string[] driverTotalRides; // = "100";//, "80", "90", "250"];
    public GameObject[] driverLocation;
    public GameObject[] driverImagesMore;


    public Text driverName;
    public Text driverRating;
    public Text driverFiveStar;
    public Text driverTotalRide;

    public Text driverPannelName;
    public GameObject[] driverImages;

    int x = 0; //Need to be a random number



    // Start is called before the first frame update
    void Start()
    {
       x = Random.Range(0, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getADriver()
    {
        //Add animation code here.

        x = Random.Range(0, 8);
        driverName.text = driverNames[x];
        driverRating.text = driverRatngs[x];
        driverFiveStar.text = driverFiveStars[x];
        driverTotalRide.text = driverTotalRides[x];
        driverLocation[x].SetActive(true);
        driverPannelName.text = driverNames[x];
        driverImagesMore[x].SetActive(true);
        driverImages[x].SetActive(true);


    }

    public void clear()
    {
        Debug.Log("Cleared");
        for (int i = 0; i < driverLocation.Length; i++)
        {
            driverLocation[i].SetActive(false);
        }
        for (int i = 0; i < driverImagesMore.Length; i++)
        {
            driverImagesMore[i].SetActive(false);
        }
        for (int i = 0; i < driverImages.Length; i++)
        {
            driverImages[i].SetActive(false);
        }
    }

    public void findAnother()
    {
        clear();
        for (int i = 1; i < driverLocation.Length; i++)
        {
            driverLocation[i].SetActive(false);
        }
        int y = x;
        x = Random.Range(0, 8); ; //Something else
        if (x != y)
        {
            getADriver();
        }
        else
        {
            findAnother();
        }
    }
}
