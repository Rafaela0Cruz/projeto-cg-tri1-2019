using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   public static AudioManager instance;

public AudioSFX audioSFX;

   void Awake() {
       if (instance == null){
           instance = this;
       }
   }

   public void PlaySoudCoinsPickup(GameObject obj){
       AudioSource.PlayClipAtPoint(audioSFX.coinPichup, obj.transform.position);
   }
}
