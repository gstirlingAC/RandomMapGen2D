using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 3. We create an enum to help us track each of the indexes
// in the array and which side they correspond to.
public enum Sides
{
    BOTTOM,
    RIGHT,
    LEFT,
    TOP
}

public class Tile {
    // 1. We need to be able to distinguish each tile from one another,
    // we will therefore need to give them a unique ID. 
    public int ID = 0;

    // 2. We will also want to keep track of all 
    // the tiles that are adjacent to this one.
    private Tile[] neighbours = new Tile[4];
}
