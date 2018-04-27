using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounddestroy : MonoBehaviour {

    public static AudioSource destroysound;
    // Use this for initialization
    void Start()
    {
        destroysound = GetComponent<AudioSource>();
    }


}
