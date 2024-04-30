using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 20;
        int c = 30;

        //AND. &
        bool result1 = (a < b) && (b < c);
        Debug.Log("(a < b) && (b < c) ?" + result1);

        //OR, ||
        bool result2 = (a > b) || (b < c);
        Debug.Log("(A > B) || (B < C) ?" + result2);

        //AND. OR
        //             True       True
        bool result3 = (a < b) && (b < c) || (a ==10);
        Debug.Log("(A < B) && (B < C) || (A ==10)? " + result3);

        //aAND. OR 
        bool result4 = (a < b);
        Debug.Log("(A > B?)" + result4);





    }

    // Update is called once per frame
    void Update()
    {
       


    }
}
