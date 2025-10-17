using Unity.Mathematics;
using Unity.Properties;
using UnityEditor.SceneManagement;
using UnityEngine;

public class BuclesFor : MonoBehaviour
{
    [SerializeField]
    GameObject[] limitesEscenario;

    [SerializeField]
    GameObject[] prefabs;

    

    //Comprobar distancias entrte el eje X y el Z de cada objetos.
    //Comprobar minimos de x e y y maximos de x e y
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float minX = limitesEscenario[0].transform.position.x;
        float maxX = limitesEscenario[0].transform.position.x;

        float minZ = limitesEscenario[0].transform.position.z;
        float maxZ = limitesEscenario[0].transform.position.z;

        for (int i = 0; i < limitesEscenario.Length; i++)
        {
            limitesEscenario[i].SetActive(false);

            if (minX > limitesEscenario[i].transform.position.x) // si el minX es 10 y el limite es 7 y buscas el minimo, cambias el 10 al 7 
            {
                minX = limitesEscenario[i].transform.position.x;
                Debug.Log("el minimo de x es " + minX);
            }

            if (maxX < limitesEscenario[i].transform.position.x)
            {
                maxX = limitesEscenario[i].transform .position.x;
                Debug.Log("el maximo de x es " + maxX);
            }

            if (minZ > limitesEscenario[i].transform.position.z)
            {
                minZ = limitesEscenario[i].transform.position.z;
                Debug.Log("el minimo de z es " +  minZ);    
            }
            if (maxZ < limitesEscenario[i].transform.position.z)
            {
                maxZ = limitesEscenario[i].transform .position.z;  
                Debug.Log("el maximo de z es " +  maxZ);
            }
        } 
    }
    for(int i = 0; i < 10; i++)
        {
        Vector3 pos = new Vector3(Random.Range(minX, maxX), -2, 5075f, Random.Range(minZ, maxZ));
    AsyncInstantiateOperation(PrefabStage[Random.Range(0, prefabs.legth)], Pose, quaternion.identity);
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
