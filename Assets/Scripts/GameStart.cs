using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update

    public GameController game;

    // Update is called once per frame
    public void ClickRestart()
    {
        game.StartGame(); 
        SceneManager.LoadScene(0);

    }
}
