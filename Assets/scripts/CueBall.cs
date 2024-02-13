using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour
{
    private Rigidbody whiteBall;
    private Vector3 initialPosition;
    private bool isShot = false;


    // Start is called before the first frame update
    void Start()
    {
        whiteBall = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseButton(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100f)) // You might need to adjust the distance
                {
                    // Ensure the raycast hits the table plane
                    if (hit.collider.gameObject.CompareTag("Table"))
                    {
                        Vector3 targetPoint = hit.point;
                        Vector3 direction = targetPoint - transform.position;

                        // Adjust the force based on the distance to the target point
                        float distance = direction.magnitude;
                        // Adjust the max force as needed
                        float forceMultiplier = Mathf.Clamp(distance, 0f, 0.2f); 

                        whiteBall.AddForce(direction.normalized * forceMultiplier, ForceMode.VelocityChange);
                    }
                }
            }
      


    }

    
}
