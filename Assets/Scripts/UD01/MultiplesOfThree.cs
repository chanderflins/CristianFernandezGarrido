using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int n = 0; n <= 100; n += 3)
        {
            print(n);
        }
    }
}
