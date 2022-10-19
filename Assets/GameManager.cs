using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject coin;

    public int gameLevel;

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 10; i++)
        {
            int randomXValue = Random.Range(0, 5);

            Instantiate(coin, new Vector3(i, 0f, randomXValue), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
