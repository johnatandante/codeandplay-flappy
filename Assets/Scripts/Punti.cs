using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Punti : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameController.Punti = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMP_Text>().text = "Score: " + GameController.Punti.ToString();
    }
}
