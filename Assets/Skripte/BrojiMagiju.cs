using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrojiMagiju : MonoBehaviour
{
		Text tekst;
    public static int brojMagije;

    void Start()
    {
        tekst = GetComponent<Text>();
          
    }

    public void Update()
    {
        tekst.text = brojMagije.ToString();
     
        
    }
}
