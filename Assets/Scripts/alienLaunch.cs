using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienLaunch : MonoBehaviour
{
    public static Alien alien;  // set before compare
    public static Planet planet;  // set before compare

    // List of dictionary to store index of alien as key and a value of a dictionary which has the keys happy, alienName and planetName. To fetch the alien name e.g launchedAliens[0]["alienName"]
    public static List<int> imageIndexs = new List<int>();
    public static List<int> happyValues = new List<int>();
    public static List<string> alienNames = new List<string>();
    public static List<string> planetNames = new List<string>();

    public void launchCompare()
    {
        List<StyleDict.Style> alienStyles = alien.selectedStyles;
        List<StyleDict.Style> planetStyles = planet.styles;
        int happy = 0;
        foreach (StyleDict.Style style in planetStyles)
        {
            if (alienStyles[0].Equals(style)) happy++;
            if (alienStyles[1].Equals(style)) happy++;
        }

        imageIndexs.Add(0);
        happyValues.Add(happy);
        alienNames.Add(alien.alienName);
        planetNames.Add(planet.planetName);

        alien.Generate();
        planet.minmizeClick();
    }
}
