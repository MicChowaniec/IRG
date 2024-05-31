using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Tile : ScriptableObject
{
    public int id;
    // type "Water", "Rock", "Sand", "Dirt", "Grass". 
    public Type type;
    // claims whether it is possible to pass
    public bool passable;
    // claims whether it is possible to root
    public bool rootable;
    //TODO
    public Tile[] neighbours;
    // 0 for no player, 1,2,3,4,5,6 attached to the color
    public int playerowned;
    public float xposition;
    public float zposition;
   // public Tile[] Tiles = new Tile[1000];



   
   // public int ReadId()
   // {
   //     return Tiles[this.id].id;
   // }
   // public Type ReadType()
   // {
   //     return Tiles[this.id].type;
   // }
   // public bool ReadRootable(Tile tile)
   // {
   //     return Tiles[tile.id].rootable;
   // }
   // public bool ReadPassable(Tile tile)
   // {
   //     return Tiles[tile.id].passable;
   // }
   // public int ReadPlayerOwned(Tile tile)
   // {
   //     return Tiles[tile.id].playerowned;
   // }
   // public float ReadXPosition(Tile tile)
   // {
   //     return Tiles[(tile.id)].xposition;
   // }
   // public float ReadYPosition(Tile tile)
   // {
   //     return Tiles[(tile.id)].yposition;
   // }
    //TODO 
    //public Neighbours[] ReadNeighbours[]
    //{
    //
    //}
}