using UnityEngine;

public class DescendingOrder : MonoBehaviour
{

    //Zona variables universales
    public int n1 = 3;
    public int n2 = 2;
    public int n3 = 1;

    // establezco una condicional doble. en caso de que se cumpla el requisito (introducir los n�meros en orden descendente) el mensaje dar� feedback positivo
    //en el caso contrario, se pedir� una reingresi�n de los n�meros
    void Start()
    {
       if(n3 < n2 && n2 < n1 && n3 < n1) 
       {
           print("Numbers have been introduced in a descending order.");
       }
       else
       {
           print("Numbers have been introduced incorrectly.");
       }
    }
}
