using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string nombreDelObjeto = "Texto Cualquiera";
    //Variable de tipo entero
    int entero = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(nombreDelObjeto, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Estoy dentro de la update");
        //Aumentar en una unidad
        entero = entero + 1;
        //Mostramos
        Debug.Log("En el update " + entero);
    }
}
