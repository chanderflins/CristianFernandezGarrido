using UnityEngine;

public class Even : MonoBehaviour
{
    // establezco un bucle "for" sin necesidad de una variable global
    //en este, se indica que solo se mostrar�n los m�ltiplos de 2 mientras la variable n sea igual o menor a 100
    void Start()
    {
        for(int n = 0; n <= 100; n += 2)
        {
            print(n);
        }
    }
}
