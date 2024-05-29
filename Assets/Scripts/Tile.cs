using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public MaterialsManager materialsManager;
    public GameObject mapAnchor;
    private int id;
    // type "Water", "Rock", "Sand", "Dirt", "Grass". 
    private Type type;
    // claims whether it is possible to pass
    private bool passable;
    // claims whether it is possible to root
    private bool rootable;
    public Tile[] neighbours;
    // 0 for no player, 1,2,3,4,5,6 attached to the color
    private int playerowned;
    private float xposition;
    private float yposition;
   // Materials[0] = sandMaterial;  Materials[1] = shallowWaterMaterial; 
   // Materials[2] = grassMaterial; Materials[3] = dirtMaterial; 
   // Materials[4] = rockMaterial;
    private Material material;
    [SerializeField]
    private GameObject fieldObject;
    public Tile(int Id, Type Type, float Xposition, float Yposition)
    {
        id = Id;
        type = Type;

        if (type == Type.Water)
        { 
        passable = false;
        rootable = false;

        }
        else if (type == Type.Rock)
        {
            passable = true;
            rootable = false;
        }
        else
        {
            passable = true;
            rootable = true;
        }

        xposition = Xposition;
        yposition = Yposition;
        Vector3 fieldPosition = new Vector3(xposition, 0, yposition);
        GameObject newFieldTile = Instantiate(fieldObject, fieldPosition, Quaternion.identity, mapAnchor.transform);
        newFieldTile.GetComponent<MeshRenderer>().material = materialsManager.AssignMaterial((int)Type);
        playerowned = 0;

    }
    public void Read()
    {
        
    }
    public void Write()
    {
        
    }
    public void Delete()
    {

    }

}
