using UnityEngine;

public class Week : MonoBehaviour
{

    //Zona de variables globales
    public int WeekDay = 7;

    //Establecí una condición múltiple para que diga el día específico de la semana según el número que se ponga
    //poner un número que no esté entre el 1 y el 7 hará que salga el texto por defecto
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
