using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    //Zona variables universales
    public int n1 = 1;
    public int n2 = 2;
    public int n3 = 3;

    // establezco una condicional doble. en caso de que se cumpla el requisito (introducir los n�meros en orden ascendente) el mensaje dar� feedback positivo
    //en el caso contrario, se pedir� una reingresi�n de los n�meros
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
