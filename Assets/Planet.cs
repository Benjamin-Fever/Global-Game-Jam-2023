using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class Planet : MonoBehaviour
{
    public GameObject PlanetPopup;
    public TextMeshProUGUI planetNameLabel;
    public TextMeshProUGUI planetStyleLabel;
    public GameObject PlanetImage;

    public int styleRangeMin = 2;
    public int styleRangeMax = 6;

    public List<string> planetNamePrefix = new List<string>() { "pre1", "pre2", "pre3", "pre4" };
    public List<string> planetNameSuffix = new List<string>() { "suf1", "suf2", "suf3", "suf4" };

    private List<StyleDict.Style> styles = new List<StyleDict.Style>();
    private string planetName;

    private void Start()
    {
        // Hide the planet popup initially
        PlanetPopup.SetActive(false);
    }

    public void galaxyClick()
    {
        PlanetPopup.SetActive(true);
        generate();
    }

    public void minmizeClick()
    {
        PlanetPopup.SetActive(false);
    }

    public void generate()
    {
        
        // Randomize Styles
        planetName = StyleDict.planetPrefix[Random.Range(0, StyleDict.planetPrefix.Count)] + StyleDict.planetSuffix[Random.Range(0, StyleDict.planetSuffix.Count)];
        styles = new List<StyleDict.Style>();
        int count = Random.Range(styleRangeMin, styleRangeMax+1);
        StyleDict.Style style = StyleDict.planetStyles.Values.ToList()[Random.Range(0, StyleDict.planetStyles.Values.ToList().Count)];
        for (int i = 0; i < count; i++)
        {
            while (styles.Contains(style))
            {
                style = StyleDict.planetStyles.Values.ToList()[Random.Range(0, StyleDict.planetStyles.Values.ToList().Count)];
            }
            styles.Add(style);
            style = StyleDict.planetStyles.Values.ToList()[Random.Range(0, StyleDict.planetStyles.Values.ToList().Count)];

        }
        for (int i = 0; i < styles.Count; i++)
        {
            Debug.Log(styles[i]);
        }
        // TODO: Random planet image

        // Apply Changes
        planetNameLabel.text = planetName;
        
        string text = "";
        List<string> keys = new List<string>();
        for (int i = 0; i < styles.Count; i++)
        {
            foreach (KeyValuePair<string, StyleDict.Style> entry in StyleDict.planetStyles)
            {
                if (styles[i].Equals(entry.Value)){
                    keys.Add(entry.Key);
                }
            }
            text += keys[Random.Range(0, keys.Count)] + "\n";
        }
        planetStyleLabel.text = text;
    }
}
