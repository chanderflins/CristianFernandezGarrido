using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int n = 1; n <= 100; n += 6)
        {
            print(n);
        }
    }
}
