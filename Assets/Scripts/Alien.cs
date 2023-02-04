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

    //Needs to be filled in editor
    public List<Sprite> images;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        numStyles = 1;
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
        int randFirstName = Mathf.RoundToInt(Random.value * (StyleDict.firstNames.Count -1));
        int randLastName = Mathf.RoundToInt(Random.value * (StyleDict.lastNames.Count - 1));
        firstName = StyleDict.firstNames[randFirstName];
        lastName = StyleDict.lastNames[randLastName];
        alienName = firstName + " " + lastName;
        namePlate.nameTag.text = alienName;

        //GeneratePicture
        int randImage = Mathf.RoundToInt(Random.value * (images.Count - 1));
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
                while (selectedStyles.Contains(selectedStyle))
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
                while (selectedStyles.Contains(selectedStyle))
                {
                    randStyle = Mathf.RoundToInt(Random.value * (StyleDict.alienStyles.Count - 1));
                    selectedStyle = StyleDict.alienStyles.Values.ToList()[randStyle];
                }
                selectedStyles.Add(selectedStyle);

                alienInfo.speciesStyles.text += StyleDict.speciesStyles.Keys.ToList()[randStyle] + "\n\n";
            }
        }
        alienLaunch.alien = this;
    }
}
