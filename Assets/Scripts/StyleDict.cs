using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StyleDict : MonoBehaviour
{

    public static Dictionary<string, Style> alienStyles;
    public static Dictionary<string, Style> planetStyles;
    public static Dictionary<string, Style> speciesStyles;
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

    // Start is called before the first frame update
    void Awake()
    {
        initStyles();
    }

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void initStyles()
    {
        alienStyles = new Dictionary<string, Style>()
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

        planetStyles = new Dictionary<string, Style>()
        {

        };

        speciesStyles = new Dictionary<string, Style>()
        {

        };

    }
    
}
