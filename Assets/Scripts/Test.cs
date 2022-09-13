using UnityEngine;

public class Test : MonoBehaviour
{


    [SerializeField] private string bussenHeter;
    [SerializeField] private int antalSittPlatser;
    [SerializeField] private float bussensVikt;
    [SerializeField] private bool arBussenSnabb;


    // Start is called before the first frame update
    void Start()
    {
        bussenHeter = "Blåtand";
        antalSittPlatser = 30;
        bussensVikt = 350.5f;
        arBussenSnabb = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
