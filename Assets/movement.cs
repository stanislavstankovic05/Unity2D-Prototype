using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rigidbody2D = new Rigidbody2D();
    public float speed;
    public Camera cam;
    Vector2 mousePos;
    public GameObject flash;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            flash.SetActive(true);
            Debug.Log("flash light on");
        }
        else
        {
            flash.SetActive(false);
        }
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = mousePos - rigidbody2D.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg ;
        rigidbody2D.rotation = angle - 90f;

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) 
        {
            rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed, 0.8f), Mathf.Lerp(0, Input.GetAxis("Vertical") * speed, 0.8f));
        }
        else
        {
            rigidbody2D.velocity = new Vector2(0, 0);
        }
    }


}
