using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BrojiMagijuZ : MonoBehaviour
{
   		Text tekst;
    public static int brojMagijeZ;

    void Start()
    {
        tekst = GetComponent<Text>();
    }

    public void Update()
    {
        tekst.text = brojMagijeZ.ToString();
    }
}
