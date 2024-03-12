using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Field;
    public GameObject Plane;
    private Vector3 locationOfPlane;
    public int size;
    
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
        Field.transform.position=locationOfPlane;
        for(int i = 0; i < size; i++)
        {
            
            locationOfPlane = new Vector3(i,0,i);
            Instantiate(Field);
        }
        

    }

}
