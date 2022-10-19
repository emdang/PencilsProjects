using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NumPress : MonoBehaviour
{
    public TextMeshProUGUI ID;
    // Start is called before the first frame update
    public void Press(int x)
    {

        if( x == 0){
            ID.text += "0";
        }
        if( x == 1){
            ID.text += "1";
        }
        if( x == 2){
            ID.text += "2";
        }
        if( x == 3){
            ID.text += "3";
        }
        if( x == 4){
            ID.text += "4";
        }
        if( x == 5){
            ID.text += "5";
        }
        if( x == 6){
            ID.text += "6";
        }
        if( x == 7){
            ID.text += "7";
        }
        if( x == 8){
            ID.text += "8";
        }
        if( x == 9){
            ID.text += "9";
        }
        if( x == -1){
            ID.text = "";
        }
    }
}
