using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubi : MonoBehaviour
{

    private bool contato = false;

    public static float VELOCITY = 2.000f;
    public static float LIMITX = -4.20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.CurrentState == GameController.GameState.GameOver)
            return;
        
        if(transform.position.x >= LIMITX) {
            transform.position = 
            new Vector2(transform.position.x - VELOCITY * Time.deltaTime, 
                transform.position.y);
        } else {
            //transform.position = posIniziale;
            Destroy(gameObject);
        }

        if(!contato && 
            transform.position.x < -2.5f) {
            contato = true;
            GameController.Punti += 1;

        } 
        
    }

}
