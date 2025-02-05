using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update

    Flappy flappy;
    GameOver gameOver;
    FlappyGame game;

    void Start()
    {
        flappy = GetComponent<Flappy>();
        gameOver = GetComponent<GameOver>();
        game = FlappyGame.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if(!game.IsGameOver)
            return;

        if(Input.GetMouseButtonDown(0)) {
            game.IsGameOver = false;
            flappy.enabled = true;
            gameOver.enabled = false;
            enabled = false;
        }

    }
}
