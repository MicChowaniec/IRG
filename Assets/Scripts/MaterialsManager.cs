using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsManager : MonoBehaviour
{
    public Material sandMaterial;
    public Material shallowWaterMaterial;
    public Material grassMaterial;
    public Material dirtMaterial;
    public Material rockMaterial;
    public Material deepWaterMaterial;
    public Material[] Materials = new Material[5];
    // Start is called before the first frame update
    void Start()
    {
        Materials[0] = sandMaterial;
        Materials[1] = shallowWaterMaterial;
        Materials[2] = grassMaterial;
        Materials[3] = dirtMaterial;
        Materials[4] = rockMaterial;
    }
    public Material AssignMaterial(int value)
    {
        if (value == 0)
        {
            return sandMaterial;
        }
        else if (value ==1)
        {
            return shallowWaterMaterial;
        }
        else if (value == 2)
        {
            return grassMaterial;
        }
        else if(value == 3)
        {
            return dirtMaterial;
        }
        else if (value == 4)
        {
            return rockMaterial;
        }
        else
        {
            Debug.Log("Wrong value, please enter value in range 0-5");
            return null;
        }
        
     }

 

}
