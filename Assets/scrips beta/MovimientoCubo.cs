using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
   //while = mientras
   // || significa o

    [SerializeField]
    GameObject gameElement;

    [SerializeField]
    float timeAnimation = 0.75f;

    [SerializeField]
    LeanTweenType curva;

    [SerializeField]
    Transform[] positions;

    int arrayIndex;
    int oldPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arrayIndex = GenerateNumber();
        oldPosition = arrayIndex;
        gameElement.transform.position = positions[arrayIndex].position;
        MoverInfinito();

    
    }

    void MoverInfinito()
    {
        oldPosition = arrayIndex;
        arrayIndex = GenerateNumber();
        LeanTween.move(gameElement,positions[arrayIndex], 0.75f).setOnComplete(MoverInfinito);
    }

    int GenerateNumber()
    {
       int num = Random.Range(0, positions.Length);

        while (num == arrayIndex || num == oldPosition)
        {
            num = Random.Range(0, positions.Length);
        }
        oldPosition = arrayIndex;
        return num;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
