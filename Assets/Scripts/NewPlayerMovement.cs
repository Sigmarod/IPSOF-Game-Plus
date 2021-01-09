
using System.Threading;
using UnityEngine;

public class NewPlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float movementforce = 500f;


    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            rb.AddForce(movementforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-movementforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 1f)
        {
            Invoke("ymin", 2);
        }
    }

    void ymin()
    {
         if (rb.position.y < 0.9f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
