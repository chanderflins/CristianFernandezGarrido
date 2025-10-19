using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    
    //Zona variables globales
    public int a;
    public int b;
    public int c;

    // Se debe configurar un mensaje por defecto en caso de que 2 o 3 numeros sean iguales
    void Start()
    {
        if(a > b && b > c)
        {
            print("The descending order of the numbers is: " + a + ", " + b + ", " + c);
        }
        else if(a > c && c > b)
        {
            print("The descending order of the numbers is: " + a + ", " + c + ", " + b);
        }
        else if(b > a && a > c)
        {
            print("The descending order of the numbers is: " + b + ", " + a + ", " + c);
        }
        else if(b > c && c > a)
        {
            print("The descending order of the numbers is: " + b + ", " + c + ", " + a);
        }
        else if(c > a && a > b)
        {
            print("The descending order of the numbers is: " + c + ", " + a + ", " + b);
        }
        else if(c > b && b > a)
        {
            print("The descending order of the numbers is: " + c + ", " + b + ", " + a);
        }
        else
        {
            print("Some of the numbers are equal to each other.");
        }
    }
}
