using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Planet : MonoBehaviour
{
    public GameObject PlanetPopup;
    public TextMeshProUGUI planetNameLabel;
    public TextMeshProUGUI planetStyleLabel;
    public Button galaxyButton;
    public List<Sprite> spriteSheet;
    public Image atmosphereImage;
    public Image planetImage;
    public Image extraImage;

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
        Debug.Log("hello?");
        galaxyButton.interactable = false;
        Debug.Log("hello??????????");
        generate();
    }

    public void minmizeClick()
    {
        PlanetPopup.SetActive(false);
        galaxyButton.interactable = true;
    }

    public void generate()
    {
        generatePlanetImage();
        // Randomize Styles
        planetName = StyleDict.planetPrefix[Random.Range(0, StyleDict.planetPrefix.Count)] + StyleDict.planetSuffix[Random.Range(0, StyleDict.planetSuffix.Count)];
        styles = new List<StyleDict.Style>();
        int count = 2;
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

    public void generatePlanetImage()
    {
        atmosphereImage.sprite = spriteSheet[Random.Range(0, 3)];
        planetImage.sprite = spriteSheet[Random.Range(3, 6)];
        extraImage.sprite = spriteSheet[Random.Range(6, 9)];
    }
}
