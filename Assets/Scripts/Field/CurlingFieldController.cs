using UnityEngine;
using UnityEngine.Events;

public class CurlingFieldController : MonoBehaviour
{
    private Vector3 initialPosition; // Inital position of the curling stone
    private bool isSiding = false;   // Flag to indicate if the curing stone is sliding
    private float slideStartTime;        // Time when sliding starts
    private float totalDistance = 0f;
    private Rigidbody rb;            // Rigidboby component of the curling stone

    private void Start()
    {
        initialPosition = transform.position; // Save the initial position of the curling stone
        rb = GetComponent<Rigidbody>();       // Get the Rigidboby component of the curling stone
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CurlingStone"))  // Check if the colliding object is the curling stone
        {
            isSiding = true ;            // Set the flag to indicate that the curling stone has started slidiing
            slideStartTime = Time.time ; // Reocrd the time when sliding starts
        }
    }

    private void Update()
    {
        if (isSiding) 
        {
            // Calculate the sliding distance using the velocity of the Rigidboby
            float distance = (Time.time - slideStartTime) * rb.velocity.magnitude; 
            float distances = Vector3.Distance(initialPosition, transform.position);

            totalDistance += distances;

            // Check if the curling stone has stopped sliding, then reset relevent variables
            if (rb.velocity.magnitude < 0.01f)  
            {
                isSiding = false ;
                totalDistance = 0f ;
            
            }

            
        }
    }


}
