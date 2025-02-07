using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public enum GameState {
        Start,
        Playing,
        GameOver
    }

    public static GameState CurrentState;

    public static float MINTUBI_X = 4f;
    public static float MINTUBI_Y = 0f;
    public static float MAXTUBI_Y = MINTUBI_Y + 3f;

    float spawnTimer;
    float spawnRate = 3f;

    public GameObject tubi;
    public GameObject flappy;
    public GameObject gameOver;
    public GameObject gameStart;
    public GameObject title;
    public GameObject punti;

    public static int Punti = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentState == GameState.Playing) {
            spawnTimer += Time.deltaTime;
            if(spawnTimer >= spawnRate) {
                spawnTimer -= spawnRate;

                // spawn random tube
                Vector2 spawnPos = new Vector2(MINTUBI_X, Random.Range(MINTUBI_Y, MAXTUBI_Y));
                Instantiate(tubi, spawnPos, Quaternion.identity);
            }
        }

    }

    public void StartGame() {
        Punti = 0;
        CurrentState = GameState.Start;
        flappy.SetActive(false);
        title.SetActive(true);
        gameStart.SetActive(false);
        gameOver.SetActive(false);
        punti.SetActive(false);
    }

    public void EndGame() {
        CurrentState = GameState.GameOver;
        flappy.SetActive(true);
        gameStart.SetActive(true);
        gameOver.SetActive(true);
        punti.SetActive(true);
    }
    
    public void Play() {
        CurrentState = GameState.Playing;
        flappy.SetActive(true);
        punti.SetActive(true);
        title.SetActive(false);
        gameStart.SetActive(false);
        gameOver.SetActive(false);
    }
}
