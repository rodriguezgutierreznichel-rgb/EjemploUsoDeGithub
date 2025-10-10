using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

public class Comportamientodelboton : MonoBehaviour
{
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    public void cambiarEstado()
    {

        gameObject.SetActive(!gameObject.activeSelf);
    }




}
