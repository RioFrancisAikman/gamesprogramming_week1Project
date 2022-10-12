using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public int colourOfTheCube;

    public enum ColourOfCube { red, blue, green};
    public ColourOfCube myColOfCube;
    private Renderer r;

    public enum AIbehaviour { myAIBehaviour };

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        

        switch (myColOfCube)
        {
            case ColourOfCube.red:
                r.material.color = Color.red;
                Debug.Log("im idle ");
                break;

            case ColourOfCube.blue:
                r.material.color = Color.blue;
                break;

            case ColourOfCube.green:
                r.material.color = Color.green;
                break;

            default:
                break;
        }
    }
}
