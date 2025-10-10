using UnityEngine;

public class CreadorDeObjetos : MonoBehaviour
{
    [SerializeField]
    GameObject[] objetosQueVoyACrear;  //para añadir arrays se pone []

    [SerializeField]
    int cantidadDeObjetos = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Random.Range(-3f, 3f)); //elegi un numero random entre -3 y el 3.
        //Crear 5 veces el mismo objeto, cambiando su posicion de forma aleatoria.

        for (int i = 0; i < cantidadDeObjetos; i++)
        {
            float posX = Random.Range(-10f, 10f);
            float posY = Random.Range(-10f, 10f);
            float posZ = Random.Range(-10f, 10f);
            int numeroAleatorio = Random.Range(0, objetosQueVoyACrear.Length);
            Instantiate(objetosQueVoyACrear[numeroAleatorio], new Vector3(posX, posY, posZ), Quaternion.identity); //Vector es la posicion y el Quaternion es la rotacion.
        }
     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
