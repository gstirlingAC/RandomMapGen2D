using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMapTester : MonoBehaviour {
    // 2. We will create a "Map Dimensions" header in the inspector
    [Header("Map Dimensions")]

    // 1. We need to store a couple of int values to 
    // represent the map width and height respectively.
    // We initialise both values to 20 for now.
    // We will use the SerializeField attribute to make the
    // private variables visible in the inspector.
    [SerializeField] private int mapWidth = 20;
    [SerializeField] private int mapHeight = 20;

    // 3. Create a new reference to the map instance.
    public Map map;

    
    // Use this for initialization
	void Start () {
        map = new Map(); // 4. Create a new instance of a map.
	}
	
    // 5. Create a method to create a new map
	public void MakeMap()
    {
        map.NewMap(mapWidth, mapHeight); // 6. Call the NewMap method. We pass in a width and height.
        Debug.Log("Created a new " + map.columns + "x" + map.rows + " map"); // 7. We'll print a statement in the console to confirm that we actually created the map.
    }
}
