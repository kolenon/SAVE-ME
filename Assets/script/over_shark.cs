using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class over_shark : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "shark")
        {

            SceneManager.LoadScene("over");
            Debug.Log("game over");
            //Destroy(gameObject);
        }
        if (col.tag == "destroy")
        {
            Destroy(gameObject);
        }
    }
}
