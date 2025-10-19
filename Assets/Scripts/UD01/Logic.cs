using UnityEngine;

public class Logic : MonoBehaviour
{
    //Variable
    private bool[] arrayLogic = {false, false, false};

    //se imprime una primera vez el array, que habr� que pasar a string 
    //tambi�n implemento paso por par�metro para evitar que haga actualizaciones cada frame
    void Start()
    {
        foreach(var item in arrayLogic)
        {
            print("Current array logic: " + item.ToString());
        }

        {
            ValueChange();
        }

    }

    // En el update se hacen los cambios que se quieran y se imprime en consola el resultado
    void ValueChange()
    {
        //Se cambia el valor de la primera casilla a true
        arrayLogic[0] = true;

        foreach(var item in arrayLogic)
        {
            print("Array logic after change: " + item.ToString());
        }
    }
}
