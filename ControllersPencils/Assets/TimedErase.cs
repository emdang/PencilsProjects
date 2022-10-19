using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimedErase : MonoBehaviour
{
    public GameObject Canvas;
    public TextMeshProUGUI t1,t2;

        
    void Update(){
        Canvas c = Canvas.GetComponent<Canvas>();
        if((c.enabled == true)){
            StartCoroutine(Wait());
            enabled = false;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(20);
        t1.enabled = false;
        t2.enabled = true;
    }

}
