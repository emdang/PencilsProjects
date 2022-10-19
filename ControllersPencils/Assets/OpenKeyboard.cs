using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKeyboard : MonoBehaviour
{
    
    // Start is called before the first frame update
   public void OpenBoard(int x){
    if (x == 1)
        TouchScreenKeyboard.Open("");
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
