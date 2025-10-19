using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    //Zona variables universales
    public int n1 = 1;
    public int n2 = 2;
    public int n3 = 3;

    // establezco una condicional doble. en caso de que se cumpla el requisito (introducir los números en orden ascendente) el mensaje dará feedback positivo
    //en el caso contrario, se pedirá una reingresión de los números
    void Start()
    {
       if(n1 < n2 && n2 < n3 && n1 < n3) 
       {
           print("Numbers have been introduced in an increasing order.");
       }
       else
       {
           print("Numbers have been introduced incorrectly.");
       }
    }
}
