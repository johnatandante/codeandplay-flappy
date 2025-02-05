using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubi : MonoBehaviour
{

    public static float VELOCITY = 2.000f;
    public static float LIMITX = -4.20f;

    FlappyGame game;

    // Start is called before the first frame update
    void Start()
    {
        game = FlappyGame.Instance;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(game.IsGameOver)
            return;
            
        if(transform.position.x >= LIMITX) {
            transform.position = 
            new Vector2(transform.position.x - VELOCITY * Time.deltaTime, 
                transform.position.y);
        } else {
            //transform.position = posIniziale;
            Destroy(gameObject);
        }
        
    }
}
