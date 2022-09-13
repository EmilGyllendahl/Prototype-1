using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour

{
    public GameObject player; // �r objektet som man l�gger in i scriptets meny i unity.

   

    private Vector3 offset = new Vector3(0,5,-7); // Variabeln f�r kameran/objektet som f�ljer spelaren och hur kameran ska vara positionerad.
    void Start()
    {
        
    }

   
   
    void LateUpdate() // LateUpdate is called after all Update functions have been called. So in this case after the vehicle has moved the camera moves.
    {
        transform.position = player.transform.position + offset;  // Kamerans/Objectets position �r detsamma som spelarens position. offset �r den privata variabeln
                                                           // som �r Vector3 v�rdet
    }
}

