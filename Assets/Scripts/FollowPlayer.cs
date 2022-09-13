using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour

{
    public GameObject player; // Är objektet som man lägger in i scriptets meny i unity.

   

    private Vector3 offset = new Vector3(0,5,-7); // Variabeln för kameran/objektet som följer spelaren och hur kameran ska vara positionerad.
    void Start()
    {
        
    }

   
   
    void LateUpdate() // LateUpdate is called after all Update functions have been called. So in this case after the vehicle has moved the camera moves.
    {
        transform.position = player.transform.position + offset;  // Kamerans/Objectets position är detsamma som spelarens position. offset är den privata variabeln
                                                           // som är Vector3 värdet
    }
}

