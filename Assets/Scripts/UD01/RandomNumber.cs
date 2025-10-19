using UnityEngine;

public class RandomNumber : MonoBehaviour
{

    //Primero establezco el array con los 5 textos
    private string[] message = {"You will gamble all your money on horseracing next month.", "I want to eat curry.", "Tomorrow will be your worst day.", "Maybe I should run off and star a new life in Thailand.", "Don't forget to water your plants."};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //hay que establecer un "index". de este modo podremos un mensaje nuevo cada vez que iniciemos el "script"
        int index = Random.Range(0,(message.Length - 1));
        print("Here is your newest future prediction! " + message[index]);
    }
}
