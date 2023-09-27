using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Playerscript : MonoBehaviour
{
    public float jumpheight=200;
    public float movementspeed=1;
    public float MouseXspeed = 1;
    Rigidbody rigit;
    // Start is called before the first frame update
    void Start()
    {
       rigit=GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput=Input.GetAxis("Vertical");
        float horizontalInput=Input.GetAxis("Horizontal");
        float mouseXinput = Input.GetAxis("Mouse X");
        transform.position += transform.forward * verticalInput*movementspeed;
        transform.position += transform.right * horizontalInput*movementspeed;
        transform.Rotate(0, mouseXinput * MouseXspeed, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigit.AddForce(Vector3.up*jumpheight);
        }
    }
}
