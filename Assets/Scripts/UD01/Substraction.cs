using UnityEngine;

public class Substraction : MonoBehaviour
{

    //Variables globales
    public int num;

    // hago un bucle "for" estableciendo los diferentes par�metros, imprimiendo al final todos los n�meros de la resta
    void Start()
    {
        int result = num;

        for(int n = 1; n < num; n++)
        {
            print(result -= 1);
        }
    }
}
