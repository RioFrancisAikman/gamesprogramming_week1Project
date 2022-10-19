using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    public Text coins, level;
    public PlayerCubeScript myPlayer;
    public GameManager my GM;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = "Coins: " + myPlayer.coinsCollected.ToString();


        level.text = "level " + myGM.gameLevel.ToString();
    }
}
