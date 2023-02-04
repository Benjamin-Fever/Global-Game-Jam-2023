using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StyleDict : MonoBehaviour
{

    public static Dictionary<string, Style> alienStyles;
    public static Dictionary<string, Style> speciesStyles;
    public static Dictionary<string, Style> planetStyles;
    public static List<string> firstNames;
    public static List<string> lastNames;
    public static List<string> planetPrefix;
    public static List<string> planetSuffix;


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
            {"'And I've been wrong, I've been down. Been to the bottom of every bottle.'", Style.NickelBack },
            {"I never eat anything that moves on its own.", Style.Herbivore },
            {"I love wearing ponchos and think everyday is Taco Tuesday.", Style.Mexican },
            {"I ate my primary school teacher. She was a grape.", Style.Herbivore },
            {"Uh... I don't know what to say. I'm shy.", Style.EmptySpace },
            {"We are many. We like to mingle.", Style.Crowds },
            {"I have pajamas for any occasion. Party pjs, wedding pajamas, funeral pajamas. You name it, I've got it!", Style.Pajamas },
            {"I've been sleeping in a hammock. It's killing my back. I need to sleep on a hard and rough surface.", Style.Rocks },
            {"'And this is how you remind me of what I really am.'", Style.NickelBack },
            {"'These five words in my head scream, 'Are we havin' fun yet'?'", Style.NickelBack },
            {"'It's not like you to say sorry, I was waitin' on a different story.'", Style.NickelBack },
            {"'This time I'm mistaken, for handing you a heart worth breaking.'", Style.NickelBack },
            {"'Never made it as a wise man. I couldn't cut it as a poor man stealing.'", Style.NickelBack }
        };

        speciesStyles = new Dictionary<string, Style>()
        {
            {"A sentient super organism made up of hundreds of distinct creatures.", Style.Crowds },
            {"Farts nonstop and is easily embarassed.", Style.EmptySpace },
            {"Salsa conveys nutrients through its veins and to its organs.", Style.Mexican },
            {"Creature of comfort that is not comfortable leaving the house. The ultimate homebody.", Style.Pajamas },
            {"Parents hatch their eggs in craters and let their young play with rocks until maturity.", Style.Rocks },
            {"Descendents from the original Chad. Generations of inbreeding have kept the genetic stock 'somewhat pure'.", Style.NickelBack },
            {"Lacks the stomach enzymes to process protein, and the taste buds to care.", Style.Herbivore },
            {"A wolf wearing sheep's clothes. Quite literally. The softness and comfort of wool cannot be matched.", Style.Pajamas },
            {"Born in a sardine tin can. This species is used to tight spaces.", Style.Crowds },
            {"Only meets with others of its kind during a mating season every 78 years. Quite happy by itself otherwise.", Style.EmptySpace },
            {"Rubs skin with guacamole to protect against sun burns.", Style.Mexican },
            {"Actively seeks our polyspecific, poly-amorous relationships. Loves plants more than you think.", Style.Herbivore },
            {"Secretes ooze when it touches the ground. Prefers sharp and rough terrain.", Style.Rocks },
            {"Has no auditory sense. Thankfully.", Style.NickelBack },
            {"Each family has two thousand siblings living their awkward high school years in the same small town.", Style.Crowds },
            {"Having a two-minute memory means growing up an orphan and not keeping many relationships.", Style.EmptySpace },
            {"Ran out of fossil fuels and resorted to burning tequila for energy.", Style.Mexican },
            {"Always in a state of 'squish'. Needs a lot of fabric to soak up after themselves.", Style.Pajamas },
            {"Nails never stop growing and needs to keep them short by clawing and scratching all the time.", Style.Rocks },
            {"Brain exists in a protected, out-of-body environment. Dances really badly because of the lag.", Style.NickelBack },
            {"Breathes in carbon dioxide and excretes photons.", Style.Herbivore }
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
            {"Home of the Endless Lettuce. Nothing has ever managed to consume more lettuce than has grown in the same time.", Style.Herbivore },
            {"Known as the moshpit of the Andromeda Nebulae. Showering optional.", Style.Crowds }
        };

        firstNames = new List<string>()
        {
            "Crispy",
            "Timbuktu",
            "Young",
            "Monkey",
            "Pizzaface",
            "Aoife",
            "Rugru",
            "James",
            "Olivier",
            "Ben",
            "AJ",
            "Clementine",
            "Superius",
            "Skux",
            "Toots",
            "Gee",
            "Muffin",
            "Polax",
            "Scruff",
            "McMac",
            "Grand",
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
            "Spaghetti",
            "Borneo",
            "Zanzibar",
            "Chone",
            "Jr.",
            "McGee",
            "Bond",
            "Muose",
            "Sr.",
            "Clone",
            "Chrun",
            "Penguin",
            "O'Dea",
            "Fever",
            "Ngo",
            "Zeus",
            "Saxophone",
            "Ten",
            "Tennis",
            "Afgard",
            "Ladson",
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
            "Blue",
            "Sticky",
            "Epsilon",
            "Two",
            "Emily",
            "Orangina",
            "Knuckle",
            "Scrote",
            "Bonce",
            "Wok",
            "Poland",
            "Guf",
            "Horbo",
            "Komon",
            "Tyolin",
            "Defko",
            "Chinester",
            "Bebobibu",
            "Aaaaaaaaaa",
            "Hoomon",
            "Snorzzles",
            "Crustaceous",
            "Wrat",
            "Blub",
            "Cronch",
            "Tigu",
            "Jhohani",
            "Welq",
            "Nmo",
            "Gasfadil",
            "Twin",
            "Fats",
            "Walrii",
            "Trampo",
            "Linus",
            "Bova",
            "Xolch",
            "Quream",
            "Lolpoppadom",
            "Trigle",
            "Kifjilo",
            "Trudjno",
            "Ljubo",
            "Connie",
        };

        planetSuffix = new List<string>()
        {
            "",
            "",
            "",
            "",
            "",
            " I",
            " II",
            " III",
            " IV",
            " V",
            " VI",
        };
    }

}