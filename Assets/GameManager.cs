using System.Collections;
using System.Collections.Generic;
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
        
       if(mapsize>=1)
        {
            locationOfPlane=Vector3.zero;
            InstantiateField();
        }
        if (mapsize >=2)
        {
            TransformCircle2();
        }
        if (mapsize >= 3)
        {
            TransformCircle3();
        }


    }
    void TransformCircle2()
    {
        //1st node
        locationOfPlane.x = 0;
        locationOfPlane.z = gaps;
        InstantiateField();

        //2nd node
        locationOfPlane.z = gaps / 2;
        locationOfPlane.x = gaps * Mathf.Sqrt(3) / 2;
        InstantiateField();

        //3rd node
        locationOfPlane.z = -gaps / 2;
        InstantiateField();

        //4th node
        locationOfPlane.x = 0;
        locationOfPlane.z = -gaps;
        InstantiateField();

        //5th node
        locationOfPlane.z = -gaps / 2;
        locationOfPlane.x = -gaps * Mathf.Sqrt(3)/2;
        InstantiateField();

        //6th node
        locationOfPlane.z = gaps / 2;
        InstantiateField();

    }

    void TransformCircle3()
    {
        //1st node
        locationOfPlane.x = 0;
        locationOfPlane.z = 2*gaps;
        InstantiateField();

        //2nd node
        locationOfPlane.x = 2*gaps / 2;
        locationOfPlane.z = 2 * gaps / Mathf.Sqrt(3);
        InstantiateField();

        //3rd node
        locationOfPlane.x = -2*gaps / 2;
        InstantiateField();

        //4th node
        locationOfPlane.x = 0;
        locationOfPlane.z = -2*gaps;
        InstantiateField();

        //5th node
        locationOfPlane.x = -2*gaps / 2;
        locationOfPlane.z = -2*gaps / Mathf.Sqrt(3);
        InstantiateField();

        //6th node
        locationOfPlane.x = -2*gaps / 2;
        locationOfPlane.z = 2*gaps / Mathf.Sqrt(3);
        InstantiateField();

    }
    void InstantiateField()
    {
        
        Field.transform.position = locationOfPlane;
        Instantiate(Field);
    }

}
