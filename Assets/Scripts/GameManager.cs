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

    public Material sandMaterial;
    public Material shallowWaterMaterial;
    public Material grassMaterial;
    public Material dirtMaterial;
    public Material rockMaterial;
    public Material deepWaterMaterial;

    private Material[] Materials = new Material[5] ;
    // Start is called before the first frame update
    void Start()
    {
        Materials[0] = sandMaterial;
        Materials[1] = shallowWaterMaterial;
        Materials[2] = grassMaterial;
        Materials[3] = dirtMaterial;
        Materials[4] = rockMaterial;
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
                int rand = Random.Range(0, Materials.Length);
                Debug.Log(rand);
                fieldPosition = new Vector3(((float)i*Mathf.Sqrt(3)/2)*gaps, 0, ((float)j+Mathf.Abs((float)i)/2) * gaps);
                GameObject newFieldTile = Instantiate(fieldTile, fieldPosition, Quaternion.identity, mapAnchor.transform);
                newFieldTile.GetComponent<MeshRenderer>().material = Materials[rand];
            }
        }
    }

}
