using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubmitName : MonoBehaviour
{

    public Text inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitButton(string nextScene)
    {
        GameManager.playerName = inputField.text;
        SceneManager.LoadScene(nextScene);
    }
}
