using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Identifier : MonoBehaviour
{
    public GameObject superior;
    public TextMeshProUGUI text;
    public GameManager gameManager;
    public Material glowingMaterial;
    private int id;
    [SerializeField]
    public Player humanPlayer;
    private Vector3 playerPosition;
    [SerializeField]
    public float maxdistance;
    [SerializeField]
    public float yposition;

    public Button root;
    [SerializeField]
    public GameObject smallTreePrefab;


    void Start()
    {

        gameManager = FindFirstObjectByType<GameManager>();
        
        humanPlayer = FindFirstObjectByType<Player>();

        id = Int32.Parse(superior.name);

        text.text = gameManager.Tiles[id].rootable.ToString();
    }
  


    void Update()
    {

      

    }

    private void OnMouseOver()
    {

        Material[] materials = new Material[2];
        materials[0] = superior.GetComponent<MeshRenderer>().material;
        materials[1] = glowingMaterial;
        superior.GetComponent<MeshRenderer>().materials = materials;
    }
    private void OnMouseExit()
    {

        Material[] materials = new Material[1];
        materials[0] = superior.GetComponent<MeshRenderer>().material;
        superior.GetComponent<MeshRenderer>().materials = materials;
    }
    private void OnMouseDown()
    {
        //Debug.Log(Distance(playerPosition, superior.transform.position).ToString());
        if (Distance(playerPosition, superior.transform.position) <= maxdistance)
        {
            
            if (gameManager.Tiles[id].passable == true)
            {
                playerPosition = new Vector3(superior.transform.position.x, yposition, superior.transform.position.z);
                humanPlayer.transform.position = playerPosition;
                

            }

        }
    }

    public float Distance(Vector3 destination, Vector3 player)
    {
        Vector3 distance = destination - player;
        return distance.magnitude;
    }
    public Vector3 Direction(Vector3 destination, Vector3 player)
    {
        Vector3 direction = destination - player;
        return direction;
    }

    public void RootNow()
    {
        if (gameManager.Tiles[id].rootable == true)
        {
            GameObject newTree = Instantiate(smallTreePrefab, playerPosition, Quaternion.identity);
            gameManager.Tiles[id].rootable = false;
        }
    }


}
