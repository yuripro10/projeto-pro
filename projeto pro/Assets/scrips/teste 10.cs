using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] fruits = new string[] { "apple", "banana", "cherry", "orage" };

        foreach (string fruit in fruits)
        {
            Debug.Log(fruit);

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
