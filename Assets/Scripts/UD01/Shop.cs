using UnityEngine;

public class Shop : MonoBehaviour
{

    //Variables globales
    //addProduct y subtractProduct deben ser booleanas para así permitir su activacón true
    [SerializeField] private int potato;
    [SerializeField] private int brocolli;
    [SerializeField] private int morePotato;
    [SerializeField] private int moreBrocolli;
    [SerializeField] private int lessPotato;
    [SerializeField] private int lessBrocolli;
    [SerializeField] private bool addProduct;
    [SerializeField] private bool subtractProduct;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StockManager();
    }

    // Después de iniciar el stock manager se le pedirá al usuario que indique si quiere añadir o quitar producto.
    //Una vez escogidas e indicadas las diferentes cantidades el programa mostrará la cantidad antes y después de la operación.
    private void StockManager()
    {

        if(addProduct = true)
        {
            GetMore(potato, brocolli, morePotato, moreBrocolli);
        }
     
        if(subtractProduct = true)
        {
            GetLess(potato, brocolli, lessPotato, lessBrocolli);
        }

    //En Unity ambas opciones se activan solas por alguna razón. Para solo hacer una acción dejar ya sea por ejemplo moreBrocolli o lessBrocolli en 0.

    }

    void Update()
    {

    }

    void GetMore(int potato, int brocolli, int morePotato, int moreBrocolli)
    {
        int newpotato = potato + morePotato;
        int newbrocolli = brocolli + moreBrocolli;
        print("New potato units: " + newpotato);
        print("New brocolli units: " + newbrocolli);

    }

    void GetLess(int potato, int brocolli, int lessPotato, int lessBrocolli)
    {
        int newpotato = potato - lessPotato;
        int newbrocolli = brocolli - lessBrocolli;
        print("New potato units: " + newpotato);
        print("New brocolli units: " + newbrocolli);

    }

}
