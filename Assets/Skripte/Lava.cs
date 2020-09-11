using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{ [SerializeField]Transform Pojav;
   private void OnTriggerEnter2D(Collider2D mag)
    {
        
        BrojiZivote.brojZivota -=1;
        
    }
    void OnCollisionEnter2D(Collision2D kol)
    {
        if (kol.transform.CompareTag("Igrac"))
            kol.transform.position = Pojav.position;
    }
}
