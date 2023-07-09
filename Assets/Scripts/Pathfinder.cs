using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    public bool isSafe = false;
    public bool isCheap = true;

    public int currentLocation = 0;
    public LocationHandler locationReload;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goCheap()
    {
        isSafe = false;
        isCheap = true;
        reload();

    }

    public void goSafe()
    {
        isSafe = true;
        isCheap = false;
        reload();
    }

    void reload()
    {
        if (currentLocation == 1)
        {
            locationReload.toForest();
        }
        if (currentLocation == 2)
        {
            locationReload.toUpton();
        }
        if (currentLocation == 3)
        {
            locationReload.toCl();
        }
        if (currentLocation == 4)
        {
            locationReload.toUg();
        }
    }
}
