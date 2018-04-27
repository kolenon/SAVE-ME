using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerSence : MonoBehaviour {
    public int index;
    public string check;
    public Image black;
    public Animator anim;
    // Use this for initialization
    public IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
    }
}
