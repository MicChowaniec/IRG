using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{
    public GameObject centerTreePrefab;
    public GameManager gameManager;
    // Start is called before the first frame update
    public void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        GameObject centerTree = Instantiate(centerTreePrefab);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
