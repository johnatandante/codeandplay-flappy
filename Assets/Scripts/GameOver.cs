using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioEnd;
    public GameController game;

    void Start()
    {
        audioEnd = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // public void ClickRestart()
    // {
    //     game.EndGame();
    //     SceneManager.LoadScene(0);

    // }
}
