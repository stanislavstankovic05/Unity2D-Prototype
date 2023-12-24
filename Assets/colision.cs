using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class colision : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
       
    }
    /*
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "object")
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1);
            Debug.Log("touched");

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        Debug.Log("exit touched");
    }
    */

}
