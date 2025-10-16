using UnityEngine;

public class StarBehavoir : MonoBehaviour
{
    //LeanTween.moveLocalY(estrella, 0.0f, animationTime).setEase(curva); -- Esto hara que se mueva al centro de la pantalla
    // LeanTween.scaleY(estrella, 1f, animationTime).setEase(curva); -- Esto hara que el objeto se escale en el ejeY
    //setOnComplete(AnimacionLatido); -- Cuando se complete la animacion, se hara otra, hecha en una funcion aparte.

    [SerializeField]
    GameObject estrella;

    [SerializeField]
    float animationTime = 1.0f;  //tiempo por defecto, en el inspector se hara los ajustes.

    [SerializeField]
    LeanTweenType curva;

    [SerializeField]
    float animationDurationScale = 1.0f;

    [SerializeField]
    LeanTweenType curvaScale;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LeanTween.moveLocalY(estrella, 0.0f, animationTime).setEase(curva);
        LeanTween.scaleY(estrella, 1f, animationDurationScale).setEase(curvaScale).setOnComplete(AnimacionLatido);
    }

    void AnimacionLatido()
    {
        LeanTween.scale(estrella,Vector3.one * 1.5f, animationDurationScale).setEaseInBounce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
