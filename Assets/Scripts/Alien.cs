using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Alien : MonoBehaviour
{

    public string alienName;
    public string firstName;
    public string lastName;
    public AlienNameTag namePlate;
    public DetailsSection alienInfo;
    public List<StyleDict.Style> selectedStyles;
    public Image alienImage;
    private int numStyles;
    public int imageIndex; // Which alien sprite was picked.
    //public Button generate; //Debug purposes

    //Previous values so there is no repeated values in new aliens
    public string previousFirstName;
    public string previousLastName;
    public List<StyleDict.Style> previousStyles;
    public int previousImageIndex;
    private bool firstAlien;


    //Needs to be filled in editor
    public List<Sprite> images;

    // Start is called before the first frame update
    void Start()
    {
        //Send reference so spaceMail can retrieve sprites
        SpaceMail.alienObject = this;

        numStyles = 1;
        firstAlien = true;
        Generate();
        //generate.onClick.AddListener(Generate);
    }

    //Generates a new alien, seeing as we only have 1 alien, this function just chnages the fields of the alien class.
    public void Generate()
    {
        //Generate name
        int randFirstName = Mathf.RoundToInt(Random.value * (StyleDict.firstNames.Count -1));
        int randLastName = Mathf.RoundToInt(Random.value * (StyleDict.lastNames.Count - 1));
        firstName = StyleDict.firstNames[randFirstName];
        lastName = StyleDict.lastNames[randLastName];

        //Remove repeats
        while (firstName == previousFirstName)
        {
            randFirstName = Mathf.RoundToInt(Random.value * (StyleDict.firstNames.Count - 1));
            firstName = StyleDict.firstNames[randFirstName];
        }
        while (lastName == previousLastName)
        {
            randLastName = Mathf.RoundToInt(Random.value * (StyleDict.lastNames.Count - 1));
            lastName = StyleDict.lastNames[randLastName];
        }

        alienName = firstName + " " + lastName;
        namePlate.nameTag.text = alienName;

        //GeneratePicture
        int randImage = Mathf.RoundToInt(Random.value * (images.Count - 1));

        //Remove repeats
        while (randImage == previousImageIndex)
        {
            randImage = Mathf.RoundToInt(Random.value * (images.Count - 1));
        }
        imageIndex = randImage;
        alienImage.sprite = images[randImage];
        alienImage.SetNativeSize();

        selectedStyles = new List<StyleDict.Style>();

        alienInfo.alienStyles.text = firstName + " Says:\n\n";

        //Generate random Alien Style.
        for (int i = 0; i < numStyles; i++)
        {
            if (StyleDict.alienStyles.Any())
            {
                int randStyle = Mathf.RoundToInt(Random.value * (StyleDict.alienStyles.Count - 1));
                StyleDict.Style selectedStyle = StyleDict.alienStyles.Values.ToList()[randStyle];
                while (selectedStyles.Contains(selectedStyle) || previousStyles.Contains(selectedStyle))
                {
                    randStyle = Mathf.RoundToInt(Random.value * (StyleDict.alienStyles.Count - 1));
                    selectedStyle = StyleDict.alienStyles.Values.ToList()[randStyle];
                }
                selectedStyles.Add(selectedStyle);


                alienInfo.alienStyles.text += StyleDict.alienStyles.Keys.ToList()[randStyle] + "\n\n";
            }
        }
        
        //Generate random species style
        alienInfo.speciesStyles.text = "Species Profile:\n\n";
        for (int i = 0; i < numStyles; i++)
        {
            if (StyleDict.speciesStyles.Any())
            {
                int randStyle = Mathf.RoundToInt(Random.value * (StyleDict.speciesStyles.Count - 1));
                StyleDict.Style selectedStyle = StyleDict.speciesStyles.Values.ToList()[randStyle];
                while (selectedStyles.Contains(selectedStyle) || previousStyles.Contains(selectedStyle))
                {
                    randStyle = Mathf.RoundToInt(Random.value * (StyleDict.alienStyles.Count - 1));
                    selectedStyle = StyleDict.alienStyles.Values.ToList()[randStyle];
                }
                selectedStyles.Add(selectedStyle);

                alienInfo.speciesStyles.text += StyleDict.speciesStyles.Keys.ToList()[randStyle] + "\n\n";
            }
        }
        alienLaunch.alien = this;
        if (firstAlien)
        {
            previousFirstName = firstName;
            previousLastName = lastName;
            previousStyles = selectedStyles;
            previousImageIndex = imageIndex;
        }
    }
}
