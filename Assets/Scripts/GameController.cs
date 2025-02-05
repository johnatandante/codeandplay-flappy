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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timerSpawn += Time.deltaTime;
        if (timerSpawn >= spawnRate) {
            timerSpawn -= spawnRate;
            Vector2 pos = new Vector2  (TUBISTARTX, Random.Range(TUBIMINY, TUBIMAXY));
            Instantiate(tubi, pos, Quaternion.identity);
        }

        
    }
}
