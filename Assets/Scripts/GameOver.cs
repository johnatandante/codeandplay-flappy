using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioEnd;

    void Start()
    {
        audioEnd = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
