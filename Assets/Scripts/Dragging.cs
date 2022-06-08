using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Dragging : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private Rigidbody _rigid;
    void Start()
    {
       _rigid = GetComponent<Rigidbody>();
    }
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position); 
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));         
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
    // void OnTriggerEnter(Collider other) 
	// {
    //     if (other.tag==this.tag)
    //     {
    //         Destroy(other.gameObject);
    //     }
	// }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == this.gameObject.tag)
        {
            
            if(other.rigidbody.velocity.magnitude < _rigid.velocity.magnitude)
            {
                Destroy(other.gameObject);
            }
            else
            {
                // Debug.Log("Entered here");
                Destroy(this.gameObject);
            }
            
        }
    }  
}

