using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;


public class apiCaller : MonoBehaviour
{
    private string api = "https://restcountries.com/v3.1/all?fields=name,population\r\n";

    void Start()
    {
        StartCoroutine(GetCountries());
    }

    IEnumerator GetCountries()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(api))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string wrappedJson = "{\"countries\":" + request.downloadHandler.text + "}";

                CountryList countryList = JsonUtility.FromJson<CountryList>(wrappedJson);

                if (countryList != null && countryList.countries != null)
                {
                    foreach (Country country in countryList.countries)
                    {
                        Debug.Log($"Country: {country.name.common}, Population: {country.population}");
                    }
                }
                else
                {
                    Debug.LogError("Failed");
                }
            }
            else
            {
                Debug.LogError("API call failed: " + request.error);
            }
        }
    }
}
