using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperBound = 25.0f;
    private Balloon balloon;

    private ScoreManager scoreManager; //A variable t manage the score manager


    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Reference ScoreManager Component
        balloon = GetComponent<Balloon>(); //Reference Balloon

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime); //Move the balloon upward

        if(transform.position.y > upperBound) //Destroy balloon after it flies up too far
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);
            Destroy(GameObject); //Pops balloon
        }

    }
}
