using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{

    public GameController game;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.CurrentState == GameController.GameState.Start) {
            if(Input.GetMouseButtonDown(0)) {
                game.Play();
            }
        }
    }

    public void OnClickStart() {
        game.Play();
    }

}
