using UnityEngine;

public class MRUV : MonoBehaviour
{
    public Transform player;
    public float velocidadInicial = 2.0f;
    public float aceleracion = 1.0f;    
    public float tiempoTotal = 3.0f;   

    private float tiempo = 0.0f;
    private float distanciaRecorrida = 0.0f;

    private Vector3 posicionInicial;
    private float velocidadActual;

    void Start()
    {
        posicionInicial = player.position;
        velocidadActual = velocidadInicial;
    }

    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo <= tiempoTotal)
        {
            
            float distancia = (velocidadActual * tiempo) + (0.5f * aceleracion * Mathf.Pow(tiempo, 2));

            distanciaRecorrida = distancia;

            Vector3 nuevaPosicion = posicionInicial + new Vector3(distanciaRecorrida, 0, 0);

            player.position = nuevaPosicion;

            Debug.Log("Distancia Recorrida: " + distanciaRecorrida);
        }
    }
}







