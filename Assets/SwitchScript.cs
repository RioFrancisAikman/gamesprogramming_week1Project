using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public int colourOfTheCube;

    public enum ColourOfCube { red, blue, green};
    public ColourOfCube myColOfCube;

    public enum AIbehaviour myAIBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (myAIBehaviour)
        {
            case AIBehaviour.idle:
                r.material.colour = Color.red;
                Debug.Log("im idle ");
                break;

            case AIBehaviour.patrolling:
                r.material.colour = Color.blue;
                break;

            case AIBehaviour.seeking:
                r.material.colour = Color.green;
                break;

            default:
                break;
        }

        switch (myColOfCube)
        {
            case ColourOfCube.red:
                r.material.colour = Color.red;
                Debug.Log("im idle ");
                break;

            case ColourOfCube.blue:
                r.material.colour = Color.blue;
                break;

            case ColourOfCube.green:
                r.material.colour = Color.green;
                break;

            default:
                break;
        }
    }
}
