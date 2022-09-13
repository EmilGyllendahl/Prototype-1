using UnityEngine;
public class PlayerController : MonoBehaviour

{


    [SerializeField] private float speed = 25.0f;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;

    [SerializeField] private Rigidbody characterBody; // Skapar fält fär objektets rigidbody 


    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()

    {

        horizontalInput = Input.GetAxis("Horizontal"); // horizontalinput variabeln som hämtar inputen och värdet ifrån det.
        forwardInput = Input.GetAxis("Vertical");

        // Move the vechicle forward based on vertical input

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); // transform komponenten translatar Vector 3 alltså 3d objectet framåt // och använder Time.Delta time för att få tid per sekund räkningen, till slut tar den * speed för att få fram variabelns hastighet på 20.
         
      
        // Höger inputen på objektet med realtid kan svänga höger,vänster och har inputs för det ifrån användaren.                                                
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);                      // Variabeln turnSpeed som möjliggör att objektet flyttas till höger, skapar även en ruta i unity på scriptet i inspectorn.


     




    }




}
