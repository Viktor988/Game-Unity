using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BrojiZivote : MonoBehaviour
{
        
		Text tekst;
    public static int brojZivota=2;

    void Start()
    {
        tekst = GetComponent<Text>();
    }

    public void Update()
    {
        tekst.text = brojZivota.ToString();
        if(brojZivota<=0){
           
            SceneManager.LoadScene("Umro");
            brojZivota=2;
    BrojiMagijuZ.brojMagijeZ=0;
    BrojiMagiju.brojMagije=0;
        }
    
  
}}
