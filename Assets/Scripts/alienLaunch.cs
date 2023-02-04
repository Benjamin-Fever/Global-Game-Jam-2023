using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class alienLaunch : MonoBehaviour
{
    public static Alien alien;  // set before compare
    public static Planet planet;  // set before compare
    public static SpaceMail spaceMail; // Is set on spacemail start
    public List<float> mailTimers; //On launch, timer is set for mail.

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

        imageIndexs.Add(alien.imageIndex);
        happyValues.Add(happy);
        alienNames.Add(alien.alienName);
        planetNames.Add(planet.planetName);
        mailTimers.Add(Random.value * 0 + 10); //Add a timer ranging from 10 seconds to a minute

        alien.Generate();
        planet.minmizeClick();
    }

    //Countdown mail timers and send mail when each one ends.
    private void Update()
    {
        if (mailTimers.Any())
        {
            countDownMailTimers();
        }
    }

    
    //Decrease timers, and remove data for aliens where the timer has run out.
    void countDownMailTimers()
    {
        List<int> finishedTimers = new List<int>();
        for(int i = 0; i < mailTimers.Count; i++)
        {
            mailTimers[i] -= Time.deltaTime;
            if (mailTimers[i] <= 0)
            {
                //Generate mail
                spaceMail.generateMail(alienNames[i], planetNames[i], imageIndexs[i], happyValues[i]);
                finishedTimers.Add(i);
            }
        }
        
        //Remove entries whos timers have run out
        for(int i = 0; i < finishedTimers.Count; i++)
        {
            int index = finishedTimers[i];

            mailTimers.RemoveAt(index);
            imageIndexs.RemoveAt(index);
            happyValues.RemoveAt(index);
            alienNames.RemoveAt(index);
            planetNames.RemoveAt(index);

            //Adjusts timers in the off chance that multiple timers finish at the same time
            for(int j = i + 1; j < finishedTimers.Count; j++)
            {
                if (finishedTimers[j] > finishedTimers[i])
                {
                    finishedTimers[j]--;
                }
            }

        }
    }
}
