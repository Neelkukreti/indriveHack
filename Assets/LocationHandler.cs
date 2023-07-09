using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationHandler : MonoBehaviour
{
    public Pathfinder pathfinder;
    public GameObject[] forestSafe;
    public GameObject[] forestCheap;

    public GameObject[] uptonSafe;
    public GameObject[] uptonCheap;

    public GameObject[] clSafe;
    public GameObject[] clCheap;

    public GameObject[] ugSafe;
    public GameObject[] ugCheap;

    public GameObject[] gpSafe;
    public GameObject[] gpCheap;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clearPath()
    {
        for (int i = 1; i < forestSafe.Length; i++)
        {
            forestSafe[i].SetActive(false);
        }

        for (int i = 1; i < forestCheap.Length; i++)
        {
            forestCheap[i].SetActive(false);
        }

        for (int i = 1; i < uptonSafe.Length; i++)
        {
            uptonSafe[i].SetActive(false);
        }

        for (int i = 1; i < uptonCheap.Length; i++)
        {
            uptonCheap[i].SetActive(false);
        }

        for (int i = 1; i < ugCheap.Length; i++)
        {
            ugCheap[i].SetActive(false);
        }

        for (int i = 1; i < ugSafe.Length; i++)
        {
            ugSafe[i].SetActive(false);
        }

        for (int i = 1; i < clCheap.Length; i++)
        {
            clCheap[i].SetActive(false);

           
        }

        for (int i = 1; i < clSafe.Length; i++)
        {
            clSafe[i].SetActive(false);
        }
    }

    public void toForest()
    {
        clearPath();
        pathfinder.currentLocation = 1;
        if(pathfinder.isCheap)
        {
            for (int i = 1; i < forestCheap.Length; i++)
            {
                forestCheap[i].SetActive(true);
            }
            for (int i = 1; i < forestSafe.Length; i++)
            {
                forestSafe[i].SetActive(false);
            }
        }
        if(pathfinder.isSafe)
        {
            for (int i = 1; i < forestCheap.Length; i++)
            {
                forestCheap[i].SetActive(false);
            }
            for (int i = 1; i < forestSafe.Length; i++)
            {
                forestSafe[i].SetActive(true);
            }
        }
    }

    public void toUpton()
    {
        clearPath();

        Debug.Log("Called");
        pathfinder.currentLocation = 2;
        if (pathfinder.isCheap)
        {
            for (int i = 1; i < uptonCheap.Length; i++)
            {
                uptonCheap[i].SetActive(true);
            }
            for (int i = 1; i < uptonSafe.Length; i++)
            {
                uptonSafe[i].SetActive(false);
            }
        }
        if (pathfinder.isSafe)
        {
            for (int i = 1; i < uptonCheap.Length; i++)
            {
                uptonCheap[i].SetActive(false);
            }
            for (int i = 1; i < uptonSafe.Length; i++)
            {
                uptonSafe[i].SetActive(true);
            }
        }
    }

    public void toCl()
    {
        clearPath();

        Debug.Log("Called");
        pathfinder.currentLocation = 3;
        if (pathfinder.isCheap)
        {
            for (int i = 1; i < clCheap.Length; i++)
            {
                clCheap[i].SetActive(true);
            }
          
        }
        if (pathfinder.isSafe)
        {
           
            for (int i = 1; i < clSafe.Length; i++)
            {
                clSafe[i].SetActive(true);
            }
        }
    }

    public void toUg()
    {
        clearPath();

        Debug.Log("Called");
        pathfinder.currentLocation = 4;
        if (pathfinder.isCheap)
        {
            for (int i = 1; i < ugCheap.Length; i++)
            {
                ugCheap[i].SetActive(true);
            }
            for (int i = 1; i < ugSafe.Length; i++)
            {
                ugSafe[i].SetActive(false);
            }
        }
        if (pathfinder.isSafe)
        {
            for (int i = 1; i < ugCheap.Length; i++)
            {
                ugCheap[i].SetActive(false);
            }
            for (int i = 1; i < ugSafe.Length; i++)
            {
                ugSafe[i].SetActive(true);
            }
        }
    }



}
