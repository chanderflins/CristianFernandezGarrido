using UnityEngine;

public class Week : MonoBehaviour
{

    //Zona de variables globales
    public int WeekDay = 7;

    //Establec� una condici�n m�ltiple para que diga el d�a espec�fico de la semana seg�n el n�mero que se ponga
    //poner un n�mero que no est� entre el 1 y el 7 har� que salga el texto por defecto
    void Start()
    {
        switch (WeekDay)
        {
            case 1:
                print ("Monday");
                break;
            case 2:
                print ("Tuesday");
                break;
            case 3:
                print ("Wednesday");
                break;
            case 4:
                print ("Thursday");
                break;
            case 5:
                print ("Friday");
                break;
            case 6:
                print ("Saturday");
                break;
            case 7:
                print ("Sunday");
                break;
            default:
                print ("Please input a number between 1 and 7.");
                break;
        }
    }
}
