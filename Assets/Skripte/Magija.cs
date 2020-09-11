using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magija : MonoBehaviour
{private AudioSource  ZvukM;

void Start(){
  ZvukM=GameObject.Find("aa").GetComponent<AudioSource>();
}
   private void OnTriggerEnter2D(Collider2D mag)
    {
      
        BrojiMagiju.brojMagije +=1;
        ZvukM.Play();
        Destroy(gameObject);
    }
}
