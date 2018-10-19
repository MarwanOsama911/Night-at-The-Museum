using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTV : MonoBehaviour
{
     public GameObject tvDisplay;

     private void OnTriggerEnter(Collider otherCollider)
     {
          if (otherCollider.GetComponent<GvrEditorEmulator>() != null)
          {
               tvDisplay.SetActive(true);
               //tvOff.SetActive(true);
          }
     }

     public void OnTriggerExit(Collider other)
     {
          tvDisplay.SetActive(false);
     }
}
