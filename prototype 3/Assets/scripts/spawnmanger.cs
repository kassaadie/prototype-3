using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanger : MonoBehaviour
{   private Vector3 spawnPos = new Vector3(25, 0 0);
	public GameObject obstaclePrefab;
	private float startDelay = 2;
	private float repeatRate = 2;

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
		Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transfrom.rotation):} }
     
        
    }

