using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterCubeScript : MonoBehaviour
{
    public int theCounter;
    //int i = 10;

    Renderer r;

    public int coinValue;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        r.material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetColourRed()
    {
        r.material.color = Color.red;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something had entered the trigger, and it was" + other.name);

        if (other.name == "PlayerCube")
        {
            //it was the player that has entered the countercube
            Debug.Log("player has entered the counter cube");


            

        }
    }
}
