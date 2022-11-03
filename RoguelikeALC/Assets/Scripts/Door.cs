using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameManager gm; //Gamemanager scri;t
    public float doorDelay = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); //Find GameManager object and then reference script component
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && gm.key <= 1)
        {
            Destroy(gameObject, doorDelay);
            gm.key --;
            Debug.Log("Keys ="+ gm.key);
            Debug.Log("Door is open!");
        }
        else
        {
            Debug.Log("This door is locked");
        }






    }
}
