using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour

{

    // Start is called before the first frame update
    void Start()
    {

    }

    public float speed = 20; // Variabeln speed har en hastighet p� 20
    [SerializeField] private float turnSpeed;
    public float horizontalInput; // variabeln f�r att sv�nga h�ger och v�nster.
    public float forwarInput;
    void Update()

    {
        horizontalInput = Input.GetAxis("Horizontal"); // horizontalinput variabeln som h�mtar inputen och v�rdet ifr�n det.
        forwarInput = Input.GetAxis("Vertical");
        // Move the vechicle forward

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwarInput); // transform komponenten translatar Vector 3 allts� 3d objectet fram�t // och anv�nder Time.Delta time f�r att f� tid per sekund r�kningen, till slut tar den * speed f�r att f� fram variabelns hastighet p� 20.
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); // H�ger inputen p� objektet med realtid kan sv�nga h�ger,v�nster och har inputs f�r det ifr�n anv�ndaren.                                                
        // Variabeln turnSpeed som m�jligg�r att objektet flyttas till h�ger, skapar �ven en ruta i unity p� scriptet i inspectorn.

    }


}
