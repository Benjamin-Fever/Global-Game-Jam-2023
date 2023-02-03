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
    public Dictionary<string, Style> styles;
    public List<Style> selectedStyles;
    public List<string> firstNames;
    public List<string> lastNames;
    public int numStyles;
    public enum Style
    {
        Crowds,
        EmptySpace,
        Mexican,
        Pajamas,
        Rocks,
        NickelBack,
        Herbivore
    };

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

        selectedStyles = new List<Style>();

        //Generate random preferences.
        for(int i = 0; i < numStyles; i++)
        {
            int randStyle = Mathf.RoundToInt(Random.value * (styles.Count - 1));
            Style selectedStyle = styles.Values.ToList()[randStyle];
            while (selectedStyles.Contains(selectedStyle))
            {
                randStyle = Mathf.RoundToInt(Random.value * (styles.Count - 1));
                selectedStyle = styles.Values.ToList()[randStyle];
            }
            selectedStyles.Add(selectedStyle);


            detailsSection.styles.text += styles.Keys.ToList()[randStyle] + "\n\n";
        }
        
    }

    //
    void initPreferenceOptions()
    {
        numStyles = 2;

        styles = new Dictionary<string, Style>()
        {
            {"I really love talking in the cinema, or going to the bathroom with my friends. I can't bear to be alone.", Style.Crowds },
            {"I like to eat by myself, with something to read. My favourite date was when I got stood up at the steakhouse. Ah! I was in heaven.", Style.EmptySpace },
            {"I once ate 5572 of those crunchy triangles they serve in bars!", Style.Mexican},
            {"I own 34 sets of pajamas. One for each of my moods.", Style.Pajamas},
            {"Food's all about texture for me. I'm looking for that maximum crunch!", Style.Rocks},
            {"And I've been wrong, I've been down. Been to the bottom of every bottle.", Style.NickelBack },
            {"I never eat anything that moves on its own.", Style.Herbivore },
            {"I love wearing ponchos and think everyday is Taco Tuesday.", Style.Mexican }
        };

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
