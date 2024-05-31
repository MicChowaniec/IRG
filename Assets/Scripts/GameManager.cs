using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public int mapSize;
    public GameObject TileParent;
    public float gaps;
    public GameObject fieldObject;
    private int id;
    public MaterialsManager materialsManager;
    public Tile[] Tiles = new Tile[100000];
    public Tile currentTile;

    // Start is called before the first frame update
    void Start()
    {
        id = 0;
        CreateMap();
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateMap()
    {
        for (int i=-mapSize+1; i<mapSize; i++)
        {
            
            for (int j = -mapSize + 1; j < (mapSize - Mathf.Abs(i)); j++)
            {
                
                int rand;
                if (i >= -1 && i <= 1 && j >= -1 && j <= 1 - Mathf.Abs(i))
                {
                    rand = 2;
                    //Debug.Log(i + " " + j + " " + rand);
                }
                else
                {
                    rand = Random.Range(0,5);
                    //Debug.Log(i+" "+j+" "+rand);
                }
                Type type = (Type)rand;
                float xposition = (float)i*Mathf.Sqrt(3)/2* gaps;
                float zposition = ((float)j+Mathf.Abs((float)i)/2) * gaps;
                // Scriptable Object holding data
                Tile tile = ScriptableObject.CreateInstance<Tile>();
                tile.id = id;
                tile.type = type;

                if (tile.type == Type.Water)
                {
                    tile.passable = false;
                    tile.rootable = false;

                }
                else if (type == Type.Rock)
                {
                    tile.passable = true;
                    tile.rootable = false;
                }
                else
                {
                    tile.passable = true;
                    tile.rootable = true;
                }
                tile.playerowned = 0;
                
                tile.xposition = xposition;
                tile.zposition = zposition;
                Tiles[id]=tile;
                //Debug.Log(Tiles[id].id.ToString());
               




                // Preparing Game Object
                Vector3 fieldPosition = new Vector3(xposition, 0, zposition);
                //Instantiate Game Object in World.
                GameObject mapTile = Instantiate(fieldObject, fieldPosition, Quaternion.identity,TileParent.transform);
                //Binding Scriptable Object to Game object
                mapTile.name = id.ToString();
                //Assigning material from Materials Manager;
                mapTile.GetComponent<MeshRenderer>().material = materialsManager.AssignMaterial(rand);
                id++;


            }
        }
    }

}
