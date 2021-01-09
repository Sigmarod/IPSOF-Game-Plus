using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsMovement : MonoBehaviour
{
    public Rigidbody rb;
    public NewPlayerMovement mov;
    public float forwardforce = -20f;
    


    // Update is called once per frame
    void Update()
    {
        
        if (mov.enabled == true)
        {
            transform.Translate((Vector3.back*35) * Time.deltaTime, Space.World);
        }

        
        var position = gameObject.transform.position;
        if(position.z < -20)
        {
            gameObject.SetActive(false);

        }
    }

}
