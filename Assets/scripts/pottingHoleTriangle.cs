using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pottingHoleTriangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriangleBall"))
        {
            // Deactivate the ball
            other.gameObject.SetActive(false);
        }
    }
}
