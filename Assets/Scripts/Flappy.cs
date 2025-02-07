using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    AudioSource[] audios;
    Rigidbody2D body2D;

    float DIRECTIONUP = 3f;

    public GameController game ;

    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        audios = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.CurrentState == GameController.GameState.Playing) {    
            if(Input.GetMouseButtonDown(0)) {
                 
                audios[0].Play();
                body2D.velocity = new Vector2(0f, DIRECTIONUP);
            } 
        }
        
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
        game.EndGame();

    }

}
