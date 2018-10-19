using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTV : MonoBehaviour {

     public GameObject tv1;
     public GameObject tv2;
     public GameObject tv3;
     public GameObject tv4;
     public GameObject tv5;


     public GameObject This;

     void Start()
     {
          
          This.SetActive(false);     

     }

     private void OnTriggerEnter(Collider otherCollider)
     {
          if (otherCollider.GetComponent<GvrEditorEmulator>() != null)
          {
               tv1.SetActive(false);
               tv1.SetActive(false);
               tv2.SetActive(false);
               tv3.SetActive(false);
               tv4.SetActive(false);
               tv5.SetActive(false);
          }
     }
}
