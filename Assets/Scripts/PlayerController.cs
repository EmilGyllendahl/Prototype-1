using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour

{

    // Start is called before the first frame update
    void Start()
    {

    }

    public float speed = 20; // Variabeln speed har en hastighet på 20
    [SerializeField] private float turnSpeed;
    public float horizontalInput; // variabeln för att svänga höger och vänster.
    public float forwarInput;
    void Update()

    {
        horizontalInput = Input.GetAxis("Horizontal"); // horizontalinput variabeln som hämtar inputen och värdet ifrån det.
        forwarInput = Input.GetAxis("Vertical");
        // Move the vechicle forward

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwarInput); // transform komponenten translatar Vector 3 alltså 3d objectet framåt // och använder Time.Delta time för att få tid per sekund räkningen, till slut tar den * speed för att få fram variabelns hastighet på 20.
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); // Höger inputen på objektet med realtid kan svänga höger,vänster och har inputs för det ifrån användaren.                                                
        // Variabeln turnSpeed som möjliggör att objektet flyttas till höger, skapar även en ruta i unity på scriptet i inspectorn.

    }


}
