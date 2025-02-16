using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static bool GameOn = false;

    public static float MINTUBI_X = 4f;
    public static float MINTUBI_Y = 0f;
    public static float MAXTUBI_Y = MINTUBI_Y + 3f;

    float spawnTimer;
    float spawnRate = 3f;

    public GameObject tubi;
    public GameObject flappy;
    public GameObject gameOver;
    public GameObject title;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.GameOn) {
            spawnTimer += Time.deltaTime;
            if(spawnTimer >= spawnRate) {
                spawnTimer -= spawnRate;

                // spawn random tube
                Vector2 spawnPos = new Vector2(MINTUBI_X, Random.Range(MINTUBI_Y, MAXTUBI_Y));
                Instantiate(tubi, spawnPos, Quaternion.identity);
            }
        }

    }

    public void EndGame() {
        GameOn = false;
        flappy.SetActive(false);
        title.SetActive(true);
        //gameOver.SetActive(false);
        SceneManager.LoadScene(0);
    }
    
    public void Play() {
        GameOn = true;
        flappy.SetActive(true);
        title.SetActive(false);
    }
}
