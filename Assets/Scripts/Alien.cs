using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Alien : MonoBehaviour
{

    public string alienName;
    public AlienNameTag namePlate;
    public GameObject picture;
    public DetailsSection detailsSection;
    public List<StyleDict.Style> selectedStyles;
    public List<string> firstNames;
    public List<string> lastNames;
    public int numStyles;



    //Needs to be filled in editor
    public List<Sprite> images;

    // Start is called before the first frame update
    void Start()
    {
        initPreferenceOptions();
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Generates a new alien, seeing as we only have 1 alien, this function just chnages the fields of the alien class.
    public void Generate()
    {
        //Generate name
        int randFirstName = Mathf.RoundToInt(Random.value * (firstNames.Count -1));
        int randLastName = Mathf.RoundToInt(Random.value * (lastNames.Count - 1));
        alienName = firstNames[randFirstName] + " " + lastNames[randLastName];
        namePlate.nameTag.text = alienName;

        //GeneratePicture
        int randImage = Mathf.RoundToInt(Random.value * (images.Count - 1));
        picture.GetComponent<Image>().sprite = images[randImage];

        selectedStyles = new List<StyleDict.Style>();

        //Generate random preferences.
        for(int i = 0; i < numStyles; i++)
        {
            int randStyle = Mathf.RoundToInt(Random.value * (StyleDict.styles.Count - 1));
            StyleDict.Style selectedStyle = StyleDict.styles.Values.ToList()[randStyle];
            while (selectedStyles.Contains(selectedStyle))
            {
                randStyle = Mathf.RoundToInt(Random.value * (StyleDict.styles.Count - 1));
                selectedStyle = StyleDict.styles.Values.ToList()[randStyle];
            }
            selectedStyles.Add(selectedStyle);


            detailsSection.styles.text += StyleDict.styles.Keys.ToList()[randStyle] + "\n\n";
        }
        
    }

    //
    void initPreferenceOptions()
    {
        numStyles = 2;

        firstNames = new List<string>()
        {
            "Grimbul",
            "Wendy",
            "Slugrup",
            "Ingurt",
            "Yeplib",
            "Bugry",
            "Limbol",
            "Shery",
        };

        lastNames = new List<string>()
        {
            "Gumptur",
            "Rigbog",
            "Portund",
            "Etryop",
            "Dumgil",
            "Vutyred",
            "Mundy",
            "Ru",
            "Quadragop",
        };
    }
}
