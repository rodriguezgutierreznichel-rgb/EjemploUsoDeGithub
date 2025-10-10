using Unity.VisualScripting;
using UnityEngine;

public class FuncionesArray : MonoBehaviour
{
    //primera prueba con el array: Debug.Log("Nota del alumno en ese examen " + notasAlumno[2]);
    //i = indice.
    // for (int i = 0; i < 5;i++) {} Debug.Log(i) --> mostrara en la console los numeros del 0 al 4.
    //void start {} MostrarArray(); --> se mostrara una vez.
    //El 5 es el numero de notas que hay.
    //for (int i = 0; i < 5;i++) {} Debug.Log(notasaAlumno[i]); --> mostrara las notas que hay.


    [SerializeField]
    int[] notasAlumnoPrimerTrimestre;



    [SerializeField]
    int[] notasAlumnoSegundoTrimestre;

    //El array sirve para tener varios datos iguales en una lista.
    //Se puede acceder de manera directa a cualquier elemento.
    //El primer elemento es el numero 0.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        MostrarArray(notasAlumnoSegundoTrimestre);

        Debug.Log("Nota mas alta del primer trimestre " + NotaMayor(notasAlumnoPrimerTrimestre));
        Debug.Log("Nota mas alta del segundo trimestre " + NotaMayor(notasAlumnoSegundoTrimestre));

        Debug.Log("Nota mas baja del primer trimestre " + NotaMenor(notasAlumnoPrimerTrimestre));
        Debug.Log("Nota mas baja del segundo trimestre " + NotaMenor(notasAlumnoSegundoTrimestre));

        Debug.Log("La nota media del primer trimestre " + CalculaMedia(notasAlumnoPrimerTrimestre));
        Debug.Log("La nota media del segundo trimestre " + CalculaMedia(notasAlumnoSegundoTrimestre));
    }

    /// <summary>
    /// Funcion que muestra en la consola todos los valores del array
    /// </summary>
    /// <param name="notasAlumno">Array con notas de un alumno en un trimestre</param>param>

    void MostrarArray(int[] notasAlumno)
    {
        //Cambiar el Debug.Log(i) para que se muestren las notas.
        //que tenemos en el array.
        //notasAlumno[indice] me permite ver la nota en un examen.

        for (int i = 0; i < notasAlumno.Length; i++) 
        {
            Debug.Log(notasAlumno[i]);

        }
    }

    int NotaMayor(int[] notasAlumno)
    {
        int notaMasAlta = 0; //partimos de la nota mas baja.
        //Debug.Log("Inicio la busqueda de la nota mas alta ahora mismo la nota es " + notaMasAlta);

        for (int i = 0; i < notasAlumno.Length; i++)
        {
            // Debug.Log(i + "Compruebo " + notasAlumno[i] + " > " + notaMasAlta + "?");
            if (notasAlumno[i] > notaMasAlta)
            {
                notaMasAlta = notasAlumno[i];
               // Debug.Log("Ahora cambio nota mas alta " + notaMasAlta + " por " + notasAlumno[i]);
            }
        }

        return notaMasAlta;
    }

    int NotaMenor(int[] notasAlumno)
    {
        int notaMasBaja = 10;

        for (int i = 0; i < notasAlumno.Length; i++) //el 0 es el primer elemento que el codigo va a mirar para buscar la nota mas baja.
        {
            if (notasAlumno[i] < notaMasBaja)
            {
                notaMasBaja = notasAlumno[i];
            }
        }
        return notaMasBaja;
    }

    float CalculaMedia(int[] notas)
    {
       int suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma = suma + notas[i];
        }
        float media = (float)suma / notas.Length;

        return media;
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
