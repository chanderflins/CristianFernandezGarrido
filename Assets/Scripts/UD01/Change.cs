using UnityEngine;

public class Change : MonoBehaviour
{
    //Variable
    private int[] arrayChange = {1, 1, 1, 1, 1};

    //se imprime una primera vez el array, que habrá que pasar a string 
    //también implemento paso por parámetro para evitar que haga actualizaciones cada frame
    void Start()
    {
        foreach(var item in arrayChange)
        {
            print("Current array values: " + item.ToString());
        }

        {
            ValueChange();
        }

    }

    // En el update se hacen los cambios que se quieran y se imprime en consola el resultado
    void ValueChange()
    {
        //Se guarda el valor 42 en la posición deseada
        arrayChange[0] = 42;
        arrayChange[4] = 42;

        foreach(var item in arrayChange)
        {
            print("Array values after change: " + item.ToString());
        }
    }
}
