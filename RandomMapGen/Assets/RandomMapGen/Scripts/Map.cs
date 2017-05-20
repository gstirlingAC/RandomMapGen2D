using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map {
    // 1. We will need to create a few private fields:
    private Tile[] tiles; // First an array of tiles.
    public int columns; // Secondly a variable to store the width of our map,
    public int rows; // followed by a variable to store the height of our map.

    // 2. Define a public method which will create our map.
    public void NewMap(int width, int height) // We pass in a couple of parameters to hold the width and height of the map.
    {
        // 3. Initialise the columns and rows variables 
        // to the width and height respectively.
        columns = width;
        rows = height;

        // 4. We set the value of the tiles array
        // to a new array, in order to track how many
        // tiles will exist inside of our map.
        tiles = new Tile[columns * rows]; // We set the value the value of the array equal to columns multiplied by rows.

        // 6. Create the map
        CreateTiles();
    }

    // 5. Use this method to create the tiles
    private void CreateTiles()
    {
        var total = tiles.Length; // create a reference to the total number of tiles and assign it to the length of the tiles array.
        for (var i = 0; i < total; i++)
        {
            var tile = new Tile(); // create a new tile class instance
            tile.ID = i; // set the value of the ID variable from the tile class to i
            tiles[i] = tile; // save this tile inside the array
        }
    }
}
