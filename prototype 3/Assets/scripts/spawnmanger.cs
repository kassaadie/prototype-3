using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanger : MonoBehaviour
{   private PlayerController playerControllerScript
	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("SpawnzObstatacle", startDelay, repeatRate);
		playerControlerScrict =
		GameObject.Find("Player").GetComponent<playerControllerScript>(); }
    }

// Update is called once per frame
void Update()
{
	if (playerControllerScript.gameOver == false) {
		Instantiate(obstaclePrefab, spawnPos, obstaclePrefab, obstaclePrefab.transfrom.rotation):} }
     
        
    }

