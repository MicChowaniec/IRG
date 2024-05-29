using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class GameManager : MonoBehaviour
{
    public GameObject fieldTile;
    public int mapSize;
    public Vector3 fieldPosition;
    
    public float gaps;
    private int id;

    // Start is called before the first frame update
    void Start()
    {
        
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
                if (i >= -1 && i <= 1 && j >= -1 && j <= 1)
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
                float yposition = (float)j+Mathf.Abs((float)i)/2 *gaps;
                
                new Tile(id, type, xposition, yposition );
            }
        }
    }

}
