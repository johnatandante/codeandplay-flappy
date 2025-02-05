using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update

    GameStart gameStart;
    FlappyGame game;

    void Start()
    {
        gameStart = GetComponent<GameStart>();
        game = FlappyGame.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if(!game.IsGameOver){
            game.IsGameOver = true;
        }

    }
}
