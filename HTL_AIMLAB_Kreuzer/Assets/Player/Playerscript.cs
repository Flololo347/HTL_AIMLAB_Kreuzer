using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput=Input.GetAxis("Vertical");
        float horizontalInput=Input.GetAxis("Horizontal");

        transform.position += transform.forward * verticalInput;
        transform.position += transform.right * horizontalInput;
    }
}
