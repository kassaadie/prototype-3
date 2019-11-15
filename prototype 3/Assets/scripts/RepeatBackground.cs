using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{  private Vector3 statPos;
    private float repeatWidth; 
    // Start is called before the first frame update
    void Start(){
    {   
      statPos = transform.psition; }
      repeatWidth = GetComponent<BoxCollider>().size.x / 2;}

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x -50) {
          transform.postion = startPos; } }
    }
}
