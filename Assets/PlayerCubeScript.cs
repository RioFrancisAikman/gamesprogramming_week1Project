using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCubeScript : MonoBehaviour
{
    public CounterCubeScript theCounterCube;



    // Start is called before the first frame update
    void Start()
    {
        theCounterCube = FindObjectOfType<CounterCubeScript>();
    }

    // Update is called once per frame
    void Update()
    {

        //theCounterCube.theCounter
        Debug.Log("The counter cube thing has " + theCounterCube.theCounter + " counts");


        if (Input.GetButton("Jump"))
        {
            Debug.Log("the jump has happened.");

            theCounterCube.SetColourRed();
        }
    }
}
