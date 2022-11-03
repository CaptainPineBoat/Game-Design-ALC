using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
  
    public int clickToPop = 3; //Score give for poped balloon

    public float scaleToIncrease = 0.10f; //How many clicks before pop

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        clickToPop -= 1; //Reduce clicks by one

        transform.localScale += Vector3.one * scaleToIncrease; //Increase balloon volume

        if(clickToPop == 0) //Destroy game object
        {
            Destroy(gameObject);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
