using System.Collections.Generic;
using UnityEngine;


public class StatGeneration : MonoBehaviour
{
    public int natureMin = 0;  // Minimum number of nature stats     Note: This is inclusive
    public int natureMax = 1;  // Maximum number of nature stats     Note: This is inclusive
    // Dictionary containing all the possible nature stats and there description
    public UDictionary<string, string> natureStats = new UDictionary<string, string>();


    public int nurtureMin = 0;  // Minimum number of nurture stats     Note: This is inclusive
    public int nurtureMax = 1;  // Maximum number of nurture stats     Note: This is inclusive
    // Dictionary containing all the possible nurture stats and there description
    public UDictionary<string, string> nurtureStats = new UDictionary<string, string>();

    /*
     * Selects a random key from the UDictionary and returns it
     */
    public static Key RandomDictionaryKey<Key, Value>(UDictionary<Key, Value> dict)
    {
        return new List<Key>(dict.Keys)[Random.Range(0, dict.Keys.Count)];
    }

    /*
     * Select a random number of nature stats within the min and max
     */
    public List<string> generateNatureStats()
    {
        int count = Random.Range(natureMin, natureMax);
        List<string> stats = new List<string>();
        for (int i = 0; i < count; i++)
        {
            stats.Add(RandomDictionaryKey<string, string>(natureStats));
        }
        return stats;
    }

    /*
     * Select a random number of nurture stats within the min and max
     */
    public List<string> generateNurtureStats()
    {
        int count = UnityEngine.Random.Range(natureMin, natureMax);
        List<string> stats = new List<string>();
        for (int i = 0; i < count; i++)
        {
            stats.Add(RandomDictionaryKey<string, string>(natureStats));
        }
        return stats;
    }

    private void Start()
    {
        List<string> stats = generateNurtureStats();
        Debug.Log("---- Nurture Stats ----");
        foreach (string stat in stats) { Debug.Log(stat); }
        Debug.Log("\n");
        Debug.Log("\n");
        stats = generateNatureStats();
        Debug.Log("---- Nature Stats ----");
        foreach (string stat in stats) { Debug.Log(stat); }
    }
}
