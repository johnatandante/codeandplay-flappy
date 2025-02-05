using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject flappy;
    public GameObject gameOver;
    FlappyGame game;

    void Start()
    {

        game = FlappyGame.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if(!game.IsGameOver)
            return;

        if(Input.GetMouseButtonDown(0)) {
            game.IsGameOver = false;
            flappy.SetActive(true);
            gameOver.SetActive(false);
        }

    }
}
