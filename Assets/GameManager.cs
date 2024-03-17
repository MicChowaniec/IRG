using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Field;
    public GameObject Plane;
    private Vector3 locationOfPlane;
    public int mapsize;
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


        for (int i = -mapsize + 1; i < mapsize; i++)
        {
            float xvalue = gaps * i * Mathf.Sqrt(3) / 2;
            float zvalue = 0;
            float jfloat = 0;

            for (int j = -mapsize + 1; j < 2 * mapsize - 2 - Mathf.Abs(i); j++)
            {
                jfloat = j;
                if (i % 2 == 0)
                {
                    zvalue = gaps * (jfloat - 0.5f);

                }
                else if (i % 2 == 1 || i % 2 == -1)
                {
                    zvalue = gaps * jfloat ;

                }
                Debug.Log("i=" + i + ", j=" + j);
                Field.transform.position = new Vector3(xvalue, 0, zvalue);
                Debug.Log("x=" + xvalue + ", z=" + zvalue);
                Instantiate(Field, Field.transform.position,Field.transform.rotation);

            }
        }
        
    }

}

