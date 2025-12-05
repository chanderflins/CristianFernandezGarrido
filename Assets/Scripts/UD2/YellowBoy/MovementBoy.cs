using UnityEngine;

public class MovementBoy : MonoBehaviour
{
   //Zona variables globales
   [SerializeField]
   private float _speed;
   [SerializeField]
   private float _turnSpeed;

   private float _horizontal;
   private float _vertical;
 
   private Animator _anim;
  
   private void Awake()
   {
   
   //La variable "anim" apunta el componente Animator
    _anim = GetComponent<Animator>();
   
   }

   /* En el update se llaman 4 metodos distintos
   InputsPlayer: recoge informacion del input horizontal y el vertical
   Move: recoge la translacion del asset del personaje
   Turn: recoge la rotacion del personaje
   Animating: para que la animacion se realice
   */
    void Update()
    {
       
        InputsPlayer();
        Move();
        Turn();
        Animating();

    }
    
    private void InputsPlayer()
    {

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

    }

    private void Move()
    {

        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);

    }

    private void Turn()
    {

        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);

    }

    private void Animating()
    {

        if(_vertical !=0) //El personaje se mueve
        {

            _anim.SetBool("IsMoving", true);

        }
        else //El personaje se queda en idle
        {

            _anim.SetBool("IsMoving", false);

        }
    }
}
