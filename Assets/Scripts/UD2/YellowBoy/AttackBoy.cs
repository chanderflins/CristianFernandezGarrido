using UnityEngine;

public class AttackBoy : MonoBehaviour
{
    
    /*En la zona de variables globales vuelvo a establecer el componente anim
    tambien el collider para activarlo y desactivarlo en el ataque
    */
    private Animator _anim;
    [SerializeField]
    private Collider _colliderAttack;

    //En el Awake recogo el componente
    private void Awake()
    {
        
        _anim = GetComponent<Animator>();

    }

    /*Se llama a un método en el Update para realizar la animacion
    de ataque
    */
    void Update()
    {
        
        AttackYellowBoy();

    }

    /*En el metodo de ataque hago un parametro "if" para que
    al recibir el input, el personaje haga un espadazo
    */
    private void AttackYellowBoy()
    {

        if (Input.GetMouseButtonDown(0))
        {

            _anim.SetTrigger("AttackPlayer");

        }

    }

    private void OnEnableCollider()
    {

         //Habilitacion del collider
        _colliderAttack.enabled = true;

    }

    private void OnDisableCollider()
    {

        //Deshabilitacion del collider
        _colliderAttack.enabled = false;

    }

}
