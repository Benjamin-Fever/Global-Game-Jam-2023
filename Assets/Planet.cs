using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public GameObject PlanetPopup;
    public GameObject GalaxyButton;

    private void Start()
    {
        // Hide the planet popup initially
        PlanetPopup.SetActive(false);
    }

    public void galaxyClick()
    {
        // Generate planet, show popup, disable galaxy button
        Debug.Log("Hello world");
        GalaxyButton.SetActive(false);
        PlanetPopup.SetActive(true);
        // TODO: Generate Planet
    }
}
