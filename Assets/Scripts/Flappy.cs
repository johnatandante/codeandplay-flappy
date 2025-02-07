using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    Rigidbody2D body2D;

    float DIRECTIONUP = 3f;

    public GameController game ;

    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.CurrentState == GameController.GameState.Playing) {       
            if(Input.GetMouseButtonDown(0)) {
                body2D.velocity = new Vector2(0f, DIRECTIONUP);
            } 
        }
        
    }
    
    void OnCollisionEnter2D(Collision2D collision) {

        game.EndGame();

    }

}
