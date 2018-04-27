using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreOverScence : MonoBehaviour {

    public Text ScoretoShow;
    int lastscore;
    // Use this for initialization
    private void Start()
    {
        LastScorefunc();
    }
    public void LastScorefunc()
    {
        Debug.Log(score.scoregame);
        lastscore = score.scoregame;
        ScoretoShow.text =  lastscore + " Point";
        Debug.Log(lastscore);
    }
}
