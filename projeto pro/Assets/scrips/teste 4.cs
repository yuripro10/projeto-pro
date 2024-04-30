using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = -10;

        if (number > 0)
        {
            Debug.Log("o número é maior que zero.");
        }
        else if (number == 0)
        {
            Debug.Log("O número não é maior que zero.");
        }
        else
          
        {
            Debug.Log("o número não é maior que zero.");
        }

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
