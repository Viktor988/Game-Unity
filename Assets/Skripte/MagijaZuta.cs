using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagijaZuta : MonoBehaviour
{private AudioSource  ZvukZ;

void Start(){
  ZvukZ=GameObject.Find("bb").GetComponent<AudioSource>();
}
    private void OnTriggerEnter2D(Collider2D mag)
    {
        
        BrojiMagijuZ.brojMagijeZ +=1;
        ZvukZ.Play();
        Destroy(gameObject);
    }
}
