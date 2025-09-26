using Unity.VisualScripting;
using UnityEngine;

public class ContadorDeEspacio : MonoBehaviour
{
    int vecesPulsado = 0;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            rb.AddForce(Vector3.up * modificarSalto, ForceMode.Impulse);
           

            vecesPulsado = vecesPulsado + 1;
            
            if (vecesPulsado == 5)
            {
                Debug.Log("Pulsado 5 puntos");
                vecesPulsado = 0;
            }
            else
            {
                Debug.Log("veces pulsado = " + vecesPulsado);
            }

        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entra en colisión");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("SALE DE colisión");
 
     }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("MANTIENE EN colision");
    }
    public float modificarSalto = 1.0f; 

   

}
