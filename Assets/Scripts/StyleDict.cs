using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StyleDict : MonoBehaviour
{

    public static Dictionary<string, Style> alienStyles;
    public static Dictionary<string, Style> speciesStyles;
    public static Dictionary<string, Style> planetStyles;
<<<<<<< Updated upstream
=======
    public static List<string> firstNames;
    public static List<string> lastNames;
    public static List<string> planetPrefix;
    public static List<string> planetSuffix;
>>>>>>> Stashed changes

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
            {"I once ate 5572 of those crunchy triangles they serve in bars!", Style.Mexican },
            {"I own 34 sets of pajamas. One for each of my moods.", Style.Pajamas },
            {"Food's all about texture for me. I'm looking for that maximum crunch! Granite, limestone, they're all delicious.", Style.Rocks },
            {"And I've been wrong, I've been down. Been to the bottom of every bottle.", Style.NickelBack },
            {"I never eat anything that moves on its own.", Style.Herbivore },
            {"I love wearing ponchos and think everyday is Taco Tuesday.", Style.Mexican },
            {"I ate my primary school teacher. She was a grape.", Style.Herbivore }
        };

        speciesStyles = new Dictionary<string, Style>()
        {
            {"A sentient super organism made up of hundreds of distinct creatures.", Style.Crowds },
            {"Farts nonstop and is easily embarassed.", Style.EmptySpace },
            {"Salsa conveys nutrients through its veins and to its organs.", Style.Mexican },
            {"Creature of comfort that is not comfortable leaving the house. The ultimate homebody.", Style.Pajamas },
            {"Parents hatch their eggs in craters and let their young play with rocks until maturity.", Style.Rocks },
            {"Descendents from the original Chad. Generations of inbreeding have kept the genetic stock 'somewhat pure'.", Style.NickelBack },
            {"Lacks the stomach enzymes to process protein, and the taste buds to care.", Style.Herbivore }
        };

        planetStyles = new Dictionary<string, Style>()
        {
            {"A hippy commune. Everyone eats together, sleeps together, bathes in the sea together, watches TV together. Making friends is easy.", Style.Crowds },
            {"The whole planet looks like elbows. Most find it unsettling and no one has colonized it yet.", Style.EmptySpace },
            {"A circumbinary planet that orbits 2 suns. Simply put, it's Taco Tuesday everyday.", Style.Mexican },
            {"A giant gas cloud seperates the planet from its star causing it a permanent night time. Wearing pajamas outdoors is social acceptable.", Style.Pajamas },
            {"It rains rocks. That's enough info to make a decision.", Style.Rocks },
            {"The only radio station in the solar system is WANB. Their tagline is: 'All Nickelback! All the time!'", Style.NickelBack },
            {"Trees grow on clouds and it rains fruit juice.", Style.Herbivore },
            {"An atypical gas giant. The gas is from all the lifeforms on the planet sweating. Smells like a college dorm party and is just as packed.", Style.Crowds },
            {"Perfect for the modern day nomad, this planet has broken free from its system's gravity. Traveling outer space is beautiful and has few neighbours.", Style.EmptySpace },
            {"The deity Quetzalcoatl owns the planet and all aspects of life reference Aztec culture as a sign of respect.", Style.Mexican },
            {"Textile manufacturing is the greatest industry. The citizens are especially proud of their sweat pants and pajamas.", Style.Pajamas },
            {"Perfectly spherical planet made entirely of marble.", Style.Rocks },
            {"The planet has a long history of acclaimed musicians. On their way to the top, most gig part-time playing alt-rock in cafes.", Style.NickelBack },
            {"Warning. This planet is overrun by giant sassysquashes. When the gourds get together, their attitude is unbearable.", Style.Herbivore },
            {"There is only one colony and it's on a boat. It's great to know all your neighbours.", Style.Crowds },
            {"A nearby black hole is swallowing the planet. Great place to live when you are trying to get away from someone.", Style.EmptySpace },
            {"The three-legged sasla is the hottest dance craze.", Style.Mexican },
            {"The native population are similar to sentient fleece. They are kind and love to snuggle.", Style.Pajamas },
            {"Surrounded by an asteroid field, mining is the most prominent industry.", Style.Rocks },
            {"Ancient aliens carvings were found in caves. When the wind passes through, it sounds like sad rock music from Earth, circa 2000.", Style.NickelBack },
            {"Home of the Endless Lettuce. Nothing has ever managed to consume more lettuce than has grown in the same time.", Style.Herbivore }
        };

<<<<<<< Updated upstream
=======
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

        planetPrefix = new List<string>()
        {
            "PlanetPrefix1",
        };

        planetSuffix = new List<string>()
        {
            "PlanetSufix1",
        };
>>>>>>> Stashed changes
    }
    
}
