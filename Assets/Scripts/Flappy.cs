using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    AudioSource[] audios;
    Rigidbody2D body2D;

    public GameController game;

    float DIRECTIONUP = 3f;

    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        audios = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.GameOn) {    
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
