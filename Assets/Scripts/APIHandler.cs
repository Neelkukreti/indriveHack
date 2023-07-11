using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIHandler : MonoBehaviour
{
    private const string apiUrl = "https://data.police.uk/api/crimes-street/all-crime?poly=52.268,0.543:52.794,0.238:52.130,0.478&date=2017-01";

    IEnumerator Start()
    {
        UnityWebRequest request = UnityWebRequest.Get(apiUrl);

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("API request failed. Error: " + request.error);
        }
        else
        {
            // Process the API response
            string jsonResponse = request.downloadHandler.text;
            ProcessAPIResponse(jsonResponse);
        }
    }

    private void ProcessAPIResponse(string jsonResponse)
    {
        // Parse the JSON response
        Crime[] crimes = JsonUtility.FromJson<Crime[]>(jsonResponse);

        // Access the individual crimes
        foreach (Crime crime in crimes)
        {
            Debug.Log("Category: " + crime.category);
            Debug.Log("Location: " + crime.location.street.name);
            Debug.Log("Latitude: " + crime.location.latitude);
            Debug.Log("Longitude: " + crime.location.longitude);
            Debug.Log("Month: " + crime.month);
            Debug.Log("--------------------");
        }
    }
}

[System.Serializable]
public class Crime
{
    public string category;
    public Location location;
    public string month;
}

[System.Serializable]
public class Location
{
    public string latitude;
    public Street street;
    public string longitude;
}

[System.Serializable]
public class Street
{
    public int id;
    public string name;
}