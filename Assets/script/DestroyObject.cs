using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestroyObject : MonoBehaviour {

    GameObject[] respawns;//สร้าง Array ขึ้นมา
    GameObject blank;
    //public InputField txt;//รับค่าจาก Textbox พิมพ์ Cannon หรือ Cow
    //ลบ Object ที่ติด Tag ทิ้งไป
    float temp,minnum=99999;
    string bool_text,result;
    int Long;
    
    public void destroyObjectTag()
    {
        bool_text = GetandSetText.GST.ftext.text;
        ///Debug.Log(bool_text);
        if (bool_text == "True") {

            respawns = GameObject.FindGameObjectsWithTag("fish");
            foreach (GameObject respawn in respawns)
            {
                temp = respawn.transform.position.x;
                if (temp < minnum)
                {
                    minnum = temp;
                    blank = respawn;
                }
            }
            Destroy(blank);
            sounddestroy.destroysound.Play();
            minnum = 99999;
            score.scoregame += 1;

        }
        
    }
}
