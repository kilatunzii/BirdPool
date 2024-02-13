using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pottingHoles : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            // Deactivate the ball
            other.gameObject.SetActive(false);
        }
    }
}

