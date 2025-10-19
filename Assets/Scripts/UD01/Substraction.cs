using UnityEngine;

public class Substraction : MonoBehaviour
{

    //Variables globales
    public int num;

    // hago un bucle "for" estableciendo los diferentes parámetros, imprimiendo al final todos los números de la resta
    void Start()
    {
        int result = num;

        for(int n = 1; n < num; n++)
        {
            print(result -= 1);
        }
    }
}
