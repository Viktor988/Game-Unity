using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UcitajPonovo : MonoBehaviour
{ 

   public void Ucitaj(){
       SceneManager.LoadScene("SampleScene");
    
  
   }

     public void Izadji(){
      Application.Quit();
   }
}
