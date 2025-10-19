using UnityEngine;

public class Score : MonoBehaviour
{
     //Variable global
    [SerializeField] private int playerPoint;

    void Start()
    { 
        RoundPoints(playerPoint);
    }

    //se realiza el paso por parámetro para el resultado de los puntos
    private void RoundPoints(int playerPoint)
    {
        if (playerPoint >= 45)
        {
            print("You have 45 points or more! Congrats!");
        }
        else
        {
            print("You don't have 45 points... try it again.'");
        }
    }
}
