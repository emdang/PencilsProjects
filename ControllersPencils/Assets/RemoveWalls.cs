using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWalls : MonoBehaviour
{
    public GameObject wall1, wall2, wall3, wall4;
    public void Press(int x){
        if(x == 1){
        MeshRenderer m1 = wall1.GetComponent<MeshRenderer>();
           m1.enabled = false;

        MeshCollider c1 = wall1.GetComponent<MeshCollider>();
           c1.enabled = false;

        MeshRenderer m2 = wall2.GetComponent<MeshRenderer>();
           m2.enabled = false;

        MeshCollider c2 = wall2.GetComponent<MeshCollider>();
           c2.enabled = false;

        MeshRenderer m3 = wall3.GetComponent<MeshRenderer>();
           m3.enabled = false;

        MeshCollider c3 = wall3.GetComponent<MeshCollider>();
           c3.enabled = false;

        MeshRenderer m4 = wall4.GetComponent<MeshRenderer>();
           m4.enabled = false;

        MeshCollider c4 = wall4.GetComponent<MeshCollider>();
           c4.enabled = false;
        }
    }
}
