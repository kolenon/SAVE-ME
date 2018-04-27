using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public static int scoregame;
    public Text displayScore;
    // Use this for initialization
    public void Start()
    {
        scoregame = 0;
    }

    // Update is called once per frame
    public void Update()
    {
        displayScore.text = "" + scoregame.ToString();
    }
}
