using UnityEngine;
public class PlayerController : MonoBehaviour

{


    [SerializeField] private float speed = 25.0f;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;

    [SerializeField] private Rigidbody characterBody; // Skapar f�lt f�r objektets rigidbody 


    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()

    {

        horizontalInput = Input.GetAxis("Horizontal"); // horizontalinput variabeln som h�mtar inputen och v�rdet ifr�n det.
        forwardInput = Input.GetAxis("Vertical");

        // Move the vechicle forward based on vertical input

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); // transform komponenten translatar Vector 3 allts� 3d objectet fram�t // och anv�nder Time.Delta time f�r att f� tid per sekund r�kningen, till slut tar den * speed f�r att f� fram variabelns hastighet p� 20.
         
      
        // H�ger inputen p� objektet med realtid kan sv�nga h�ger,v�nster och har inputs f�r det ifr�n anv�ndaren.                                                
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);                      // Variabeln turnSpeed som m�jligg�r att objektet flyttas till h�ger, skapar �ven en ruta i unity p� scriptet i inspectorn.


     




    }




}
