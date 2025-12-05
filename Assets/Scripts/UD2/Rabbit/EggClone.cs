using UnityEngine;

public class EggClone : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private GameObject _egg;
    [SerializeField]
    private Transform _posRotRabbit;
   //Estas 2 variables serian para la fuerza de arriba y adelante, para el lanzamiento
    [SerializeField]
    private float _thrustY;
    [SerializeField]
    private float _thrustZ;
    //Esta última es para el tiempo de destrucción
    [SerializeField]
    private float _timeDestroy;

  // En el Update llamamos un método para clonar huevos
    void Update()
    {
        
        CreateEggs();

    }

    private void CreateEggs()
    {
        
        if (Input.GetMouseButtonDown(0))
        {

            //Aquí se instanciaran los prefabs
            /*Primero hay que establecer el método Instantiate para después 
              guardar las instanciaciones en otro game object
            */
            GameObject cloneEgg = Instantiate(_egg, _posRotRabbit.position, _posRotRabbit.rotation);
            Rigidbody rbEgg = cloneEgg.GetComponent<Rigidbody>();
            /*También habrá que establecer un metodo para la
              destrucción de los huevos pasado un tiempo determinado,
              así no se sobrecarga el programa
            */
            Destroy(cloneEgg, _timeDestroy);
            /*Una vez realilzado, se aplica una fuerza hacia arriba
              y otra hacia delante en los Rigidbody
            */
            rbEgg.AddForce(Vector3.up * _thrustY);
            rbEgg.AddForce(transform.forward * _thrustZ);

        }

    }
}
