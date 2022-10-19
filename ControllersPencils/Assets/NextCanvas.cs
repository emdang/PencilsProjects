using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NextCanvas : MonoBehaviour
{
    public GameObject Canvas1, Canvas2;
    
    public void Press(int x){
        if(x == 1){
            Destroy(Canvas1);
            Canvas c = Canvas2.GetComponent<Canvas>();
            c.enabled = true;
        }
    }
}
