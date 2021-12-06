using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerName : MonoBehaviour
{

    public Text playerNameDisplay;

    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("Game Manager") != null)
        {
            playerNameDisplay.text = GameManager.playerName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
