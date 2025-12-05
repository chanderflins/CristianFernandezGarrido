using UnityEngine;

public class Movement : MonoBehaviour
{
    //Zona de variables universales
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turn;

    public void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {

        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        }

        if(Input.GetKey(KeyCode.S))
        {

        transform.Translate(Vector3.back * _speed * Time.deltaTime);

        }

        if(Input.GetKey(KeyCode.A))
        {

        transform.Rotate(-Vector3.up * _turn * Time.deltaTime);

        }

        if(Input.GetKey(KeyCode.D))
        {

        transform.Rotate(Vector3.up * _turn * Time.deltaTime);

        }
    }
}
