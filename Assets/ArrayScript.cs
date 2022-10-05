using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    string[] fruit;

    // Start is called before the first frame update
    void Start()
    {
        fruit = new string[5];

        fruit[0] = "banana";
        fruit[1] = "apple";
        fruit[2] = "orange";
        fruit[3] = "coconut";
        fruit[4] = "grape";

        Debug.Log(fruit[0]);
        Debug.Log(fruit[2]);
        Debug.Log(fruit[3]);
        Debug.Log(fruit[4]);
        Debug.Log(fruit[1]);

        for (int i = 0; i < fruit.Length; i++) 
        {
            //inside the loop
            Debug.Log(fruit[i]);
        }

        
        int k = 0;
        while (k > 10)
        {
            //loop this
            Debug.Log("something is true");

            k++;
        }


        int f = 0;
        do
        {
            Debug.Log("something is true but do while");
            f++;
        } while (f > 10);


    }

    // Update is called once per frame
    void Update()
    {
        //int randomNumber = Random.Range(0, 5);
       // float randomFloat = Random.Range(1.0f, 5.0f);

        //Debug.Log(fruit[randomNumber]);
    }
}
