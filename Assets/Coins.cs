using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coinsCollected;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("A collision has happened");

        if(collider.gameObject.tag == "Coin")
        {
            Debug.Log("Coin collected");
            coinsCollected = coinsCollected + 1;
            collider.gameObject.SetActive(false);

            collider.gameObject.GetComponent<Coins>().coinsCollected += 1;
            Destroy(gameObject, 0.60f);
        }
    }
}
