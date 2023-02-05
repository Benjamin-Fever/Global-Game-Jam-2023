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
    public static Dictionary<int, List<string>> responses;

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
        initScenes();
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
            {"We are many. We like to mingle.", Style.Crowds },
            {"You're going to find me a new home? Huddle up! Let's collaborate to make ideas great!", Style.Crowds },
            {"I like to eat by myself, with something to read. My favourite date was when I got stood up at the steakhouse. Ah! I was in heaven.", Style.EmptySpace },
            {"My favourite thing about museums is that no one visits them and I get them all to myself.", Style.EmptySpace },
            {"Uh... I don't know what to say. I'm shy.", Style.EmptySpace },
            {"I ate my primary school teacher. She was a grape.", Style.Herbivore },
            {"I love the smell of pollen in the morning.", Style.Herbivore },
            {"I never eat anything that moves on its own.", Style.Herbivore },
            {"Hola mi amigo.", Style.Mexican },
            {"I love wearing ponchos and think everyday is Taco Tuesday.", Style.Mexican },
            {"I once ate 5572 of those crunchy triangles they serve in bars!", Style.Mexican },
            {"'And I've been wrong, I've been down. Been to the bottom of every bottle.'", Style.NickelBack },
            {"'And this is how you remind me of what I really am.'", Style.NickelBack },
            {"'It's not like you to say sorry, I was waitin' on a different story.'", Style.NickelBack },
            {"'Never made it as a wise man. I couldn't cut it as a poor man stealing.'", Style.NickelBack },
            {"'These five words in my head scream, 'Are we havin' fun yet'?'", Style.NickelBack },
            {"'This time I'm mistaken, for handing you a heart worth breaking.'", Style.NickelBack },
            {"I have pajamas for any occasion. Party pjs, wedding pajamas, funeral pajamas. You name it, I've got it!", Style.Pajamas },
            {"I love to lie down on the sofa and watch TV. Y'all got a planet for that?", Style.Pajamas },
            {"I own 34 sets of pajamas. One for each of my moods.", Style.Pajamas },
            {"Food's all about texture for me. I'm looking for that maximum crunch! Granite, limestone, they're all delicious.", Style.Rocks },
            {"I practice martial arts everyday. Where I'm going, will there be rocks for me to punch?", Style.Rocks },
            {"I've been sleeping in a hammock. It's killing my back. I need to sleep on a hard and rough surface.", Style.Rocks },
        };

        speciesStyles = new Dictionary<string, Style>()
        {
            {"A sentient super organism made up of hundreds of distinct creatures.", Style.Crowds },
            {"Born in a sardine tin can. This species is used to tight spaces.", Style.Crowds },
            {"Each family has two thousand siblings living their awkward high school years in the same small town.", Style.Crowds },
            {"Most of the species are filthy rich and make friends easily.", Style.Crowds },
            {"Farts nonstop and is easily embarassed.", Style.EmptySpace },
            {"Only meets with others of its kind during a mating season every 78 years. Quite happy by itself otherwise.", Style.EmptySpace },
            {"Having a two-minute memory means growing up an orphan and not keeping many relationships.", Style.EmptySpace },
            {"Being really short and really wide makes it difficult for this species to fit in small spaces while upright.", Style.EmptySpace },
            {"Lacks the stomach enzymes to process protein, and the taste buds to care.", Style.Herbivore },
            {"Actively seeks our polyspecific, poly-amorous relationships. Loves plants more than you think.", Style.Herbivore },
            {"Breathes in carbon dioxide and excretes photons.", Style.Herbivore },
            {"Essentially a sentient sushi that needs a constant supply of seaweed to live.", Style.Herbivore },
            {"Salsa conveys nutrients through its veins and to its organs.", Style.Mexican },
            {"Rubs skin with guacamole to protect against sun burns.", Style.Mexican },
            {"Ran out of fossil fuels and resorted to burning tequila for energy.", Style.Mexican },
            {"A high tolerence for spices and acids, like chilli and limes, have forged many famous eating champions.", Style.Mexican },
            {"Descendents from the original Chad. Generations of inbreeding have kept the genetic stock 'somewhat pure'.", Style.NickelBack },
            {"Has no auditory sense. Thankfully.", Style.NickelBack },
            {"Brain exists in a protected, out-of-body environment. Dances really badly because of the lag.", Style.NickelBack },
            {"A partially organic, partially mineral lifeform. Has a backbone made of Ni on the periodic table of elements.", Style.NickelBack },
            {"Creature of comfort that is not comfortable leaving the house. The ultimate homebody.", Style.Pajamas },
            {"A wolf wearing sheep's clothes. Quite literally. The softness and comfort of wool cannot be matched.", Style.Pajamas },
            {"Always in a state of 'squish'. Needs a lot of fabric to soak up after themselves.", Style.Pajamas },
            {"Body is mostly made of bones and spikes. Needs soft clothes.", Style.Pajamas },
            {"Parents hatch their eggs in craters and let their young play with rocks until maturity.", Style.Rocks },
            {"Secretes ooze when it touches the ground. Prefers sharp and rough terrain.", Style.Rocks },
            {"Nails never stop growing and needs to keep them short by clawing and scratching all the time.", Style.Rocks },
            {"Has a heart of stone, biologically-speaking.", Style.Rocks },
        };

        planetStyles = new Dictionary<string, Style>()
        {
            {"A hippy commune. Everyone eats together, sleeps together, bathes in the sea together, watches TV together. Making friends is easy.", Style.Crowds },
            {"An atypical gas giant. The gas is from all the lifeforms on the planet sweating. Smells like a college dorm party and is just as packed.", Style.Crowds },
            {"There is only one colony and it's on a boat. It's great to know all your neighbours.", Style.Crowds },
            {"Known as the moshpit of the Andromeda Nebulae. Showering optional.", Style.Crowds },
            {"The whole planet looks like elbows. Most find it unsettling and no one has colonized it yet.", Style.EmptySpace },
            {"Perfect for the modern day nomad, this planet has broken free from its system's gravity. Traveling outer space is beautiful and has few neighbours.", Style.EmptySpace },
            {"A nearby black hole is swallowing the planet. Great place to live when you are trying to get away from someone.", Style.EmptySpace },
            {"Trees grow on clouds and it rains fruit juice.", Style.Herbivore },
            {"Warning. This planet is overrun by giant sassysquashes. When the gourds get together, their attitude is unbearable.", Style.Herbivore },
            {"Home of the Endless Lettuce. Nothing has ever managed to consume more lettuce than has grown in the same time.", Style.Herbivore },
            {"A circumbinary planet that orbits 2 suns. Simply put, it's Taco Tuesday everyday.", Style.Mexican },
            {"The deity Quetzalcoatl owns the planet and all aspects of life reference Aztec culture as a sign of respect.", Style.Mexican },
            {"The three-legged salsa is the hottest dance craze.", Style.Mexican },
            {"The only radio station in the solar system is WANB. Their tagline is: 'All Nickelback! All the time!'", Style.NickelBack },
            {"The planet has a long history of acclaimed musicians. On their way to the top, most gig part-time playing alt-rock in cafes.", Style.NickelBack },
            {"Ancient aliens carvings were found in caves. When the wind passes through, it sounds like sad rock music from Earth, circa 2000.", Style.NickelBack },
            {"A giant gas cloud seperates the planet from its star causing it a permanent night time. Wearing pajamas outdoors is social acceptable.", Style.Pajamas },
            {"Textile manufacturing is the greatest industry. The citizens are especially proud of their sweat pants and pajamas.", Style.Pajamas },
            {"The native population are similar to sentient fleece. They are kind and love to snuggle.", Style.Pajamas },
            {"It rains rocks. That's enough info to make a decision.", Style.Rocks },
            {"Perfectly spherical planet made entirely of marble.", Style.Rocks },
            {"Surrounded by an asteroid field, mining is the most prominent industry.", Style.Rocks },
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
            "Strawberry",
            "Star",
            "Yuddle",
            "Nefpo",
            "Chombam",
            "Justefefe",
            "Humbo",
            "Habduj",
            "Hsjin",
            "Snackniquerai",
            "Coughles",
            "Sazj",
            "Sojz",
            "Jytinc",
            "Browl",
            "Mufflo",
            "Hippo",
            "Corn",
            "Dav",
            "Bellark",
            "Whin",
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
            "Ziddy",
            "Esnic",
            "Xewoo",
            "Bigal",
            "Nuichu",
            "Yokod",
            "Dvia",
            "Tshamous",
            "Khor",
            "Crodent",
            "Grifunt",
            "Pushles",
            "Ofnameo",
            "Vafodil",
            "Gruness",
            "Fadco",
            "Memely",
            "Whazel",
            "Tream",
            "Sgavinous",
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
            "Risep",
            "Flightul",
            "Moa",
            "Maybe",
            "Sleepy",
            "Jefferson",
            "Bagel",
            "Fite",
            "Bark Bark",
            "Dolop",
            "Pnemio",
            "Lamio",
        };

        planetSuffix = new List<string>()
        {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
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
            " Chi",
            " Zuo",
            " Kuan",
            " Fort",
            " Wizs",
            " Twok",
            " Nib",
            " Yut",
            " Quizzle",
            " Blub Ham",
            " Por",
            " Rek",
            " Din",
            " Lun",
            " Swo",
            " Qad",
        };

        responses = new Dictionary<int, List<string>>()
        {
            { 0, new List<string>(){
                "This place sucks!",
                "What dump!",
                "No fun was had",
                "You ruined my holidays",
                "I can't live here anymore",
                "Thanks for nothing",
                "I've hired another agency",
                "I'm not mad at you, just dissapointed",
                "We' just got here and we're moving on",
                "Get me out of here!!!",
                "Help! Get me off this planet",
                "You should try a few days here",
            }},
            { 1, new List<string>(){
                "It's not perfect, but it's home",
                "My elders always said 'This'll do'",
                "We'll make the best of it",
                "I can make it anywhere",
                "At least it's not Auckland",
                "I wonder what's on TV here",
                "It's not ideal, but they deliver here",
                "Maybe in a few generations, we'll make it work",
                "My kids won't know any better. It'll do",
                "She'll be right",
                "The grass isn't always greener. It isn't always grass.",
            }},
            { 2, new List<string>(){
                "What a lovely dump!",
                "I'm in heaven",
                "Thank you, you were my only hope",
                "Package safely delivered to paradise",
                "You did well my friend",
                "Come visit anytime!",
                "It's so nice here",
                "=)",
                "Not too hot, not too cold, but just right",
                "What a wonderful world",
                "Pinch me, I must be dreaming"
            }}
        };
    }
    public void initScenes()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
        SceneManager.LoadScene(3, LoadSceneMode.Additive);
        SceneManager.LoadScene(4, LoadSceneMode.Additive);
    }
}