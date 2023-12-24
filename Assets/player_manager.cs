using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public float count_down;
    public GameObject enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count_down <= 0)
        {
            enemy.SetActive(true);
            count_down = timer;
        }
        else if (count_down > 0 && enemy.activeSelf == false) 
        {
            count_down -= 1 * Time.deltaTime;
        }

    }
}
