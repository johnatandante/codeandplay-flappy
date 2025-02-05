using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyGame
{
    public bool IsGameOver = false;

    private static FlappyGame instance;

    public static FlappyGame Instance {

        get {
            if(instance == null) instance = new FlappyGame();
            return instance;
        }
    }

}
