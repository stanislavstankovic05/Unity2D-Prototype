using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    // Start is called before the first frame update
    public float battery = 10f;
    public float range = 50f;
    public float value = 0.001f;
    bool change = false;
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (battery > 0)  
        {

            Debug.Log("flash light on");
            battery -= value;
        }
        if (change == true)
        {

            this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
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
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "object") 
        {
            change = true;
            col.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }
        if (col.gameObject.name == "enemy") 
        {
            Debug.Log("HIT!!");
            col.gameObject.SetActive(false);
        }

    }
    private void OnTriggerExit2D(Collider2D col)
    {
        change = false;
        col.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
    }
}
