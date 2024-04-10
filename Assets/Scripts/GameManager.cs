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
    public GameObject mapAnchor;
    public float gaps;
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
                
                fieldPosition = new Vector3(((float)i*Mathf.Sqrt(3)/2)*gaps, 0, ((float)j+Mathf.Abs((float)i)/2) * gaps );
                Instantiate(fieldTile, fieldPosition, Quaternion.identity, mapAnchor.transform);
            }
        }
    }

}
