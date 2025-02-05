using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    float timerSpawn;
    float spawnRate = 3f;
    public float TUBISTARTX = 4f;
    public float TUBIMINY = -1f;
    public float TUBIMAXY = 3f;

    public GameObject tubi;
    public GameObject flappy;
    public GameObject gameStart;
    public GameObject gameOver;

    FlappyGame game;

    // Start is called before the first frame update
    void Start()
    {
        game = FlappyGame.Instance;
    }

    // Update is called once per frame
    void Update()
    {

        if(game.IsGameOver){
            flappy.SetActive(false);
            gameOver.SetActive(true);
            gameStart.SetActive(true);
            return;     
        }

        timerSpawn += Time.deltaTime;
        if (timerSpawn >= spawnRate) {
            timerSpawn -= spawnRate;
            Vector2 pos = new Vector2  (TUBISTARTX, Random.Range(TUBIMINY, TUBIMAXY));
            Instantiate(tubi, pos, Quaternion.identity);
        }

        
    }
}
