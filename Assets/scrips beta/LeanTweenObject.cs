using UnityEngine;
using TMPro;

public class LeanTweenObject : MonoBehaviour
{
    //LeanTween.move(objeto, newPosition, animationTime).setEase(curva);
    // public void AccionBoton() //Esto es una funcion.LeanTween.move(objeto, Vector3.zero, 0.0f); LeanTween.move(objeto, newPosition, animationTime).setEase(curva);

    Vector3 originalScale;

[SerializeField]
    GameObject objeto;
    [SerializeField]
    float animationTime = 0.75f;
    [SerializeField]                                      //Esto sirve para ajustar la animacion en el inspector
    Vector3 newPosition = new Vector3(0.0f, 4.10f,0.0f);
    [SerializeField]                                      //Para poner el tipo de curva que se hará sin tener que cambiarlo en código.
    LeanTweenType curva;

    [SerializeField]
    TextMeshProUGUI etiquetaTexto;

    public void AccionBoton() //Esto es una funcion.
    {
        if (LeanTween.isTweening(objeto) == false) //Asi no se buguea cuando le doy varias veces
        {
            if (objeto.transform.localScale == originalScale)
            {
                LeanTween.scale(objeto, Vector3.one * 3f, animationTime).setEase(curva);
                etiquetaTexto.text = "Encoger";
            }
            else
            { 
            LeanTween.scale(objeto, originalScale, animationTime).setEase(curva);   //Debe haber uno que resetee la posicion y otro que lo cambia
            }
           
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalScale = objeto.transform.localScale;
        etiquetaTexto.text = "Agrandar";
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
