using UnityEngine;

public class Number : MonoBehaviour
{

    //Variable
    [SerializeField] private int number;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlusOne(number);
    }

    //Aqui se realiza la suma en valor de 1
    private void PlusOne(int number)
    {
        int numberOne = number += 1;
        print("New number: " + numberOne);
    }
}
