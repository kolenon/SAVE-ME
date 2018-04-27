using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetandSetText : MonoBehaviour
{
    public static GetandSetText GST;
    public AudioClip falseSound;
    AudioSource source;
    public InputField word;
   
    public Text ftext;
    private string w_in, w_check;
    private bool ist = false,ans;
    public int L;
    private void Awake()
    {
        GST = this;
    }
    private void Start()
    {
        
    }
    public void setget()
    {
        //rndword.Rword.wordrnd();
        w_check = rndword.Rword.rndtxt.text;
        w_in = word.text;
        ans = check_ans(w_in, w_check);

        if (ans == true)
        {
            ftext.text = "True";
            L = w_check.Length;
            ///Debug.Log(w_check.Length);
            ///Debug.Log(L);
        }
        else 
        {
            ftext.text = "False";
        }
        word.text="";
        word.ActivateInputField();


    }
    
    private bool check_ans(string w,string Tcond)
    {
        
        if (w == Tcond)
        {
            ist = true;
        }
        else
        {
            ist = false;
            soundwrong.AsoundF.Play();
        }
        return ist;
    }

}