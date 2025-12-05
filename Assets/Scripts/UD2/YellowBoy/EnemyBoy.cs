using UnityEngine;

public class EnemyBoy : MonoBehaviour
{
    /*En este proceso especifico el enemigo recibe el ataque para
    despues destruirse
    */
    private void OnTriggerEnter(Collider infoAccess)
    {

        if(infoAccess.CompareTag("AttackPlayer"))
        {

            Destroy(gameObject);

        }

    }
}
