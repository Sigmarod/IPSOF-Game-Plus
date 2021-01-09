using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    public NewPlayerMovement mov;
    public Rigidbody rb;
    private void OnCollisionEnter(Collision collisioninfo)
    {
        
        if(collisioninfo.collider.tag == "Obstacle")
        {
            mov.enabled = false;
            rb.AddForce(0, 0, 300 * Time.deltaTime, ForceMode.VelocityChange);
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
