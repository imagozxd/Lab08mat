using UnityEngine;

public class MRU : MonoBehaviour
{
    public Transform player;
    public GameObject puntoA;
    public GameObject puntoB;
    public Puntos tiempoA;
    public Puntos tiempoB;

    public float tiempoTotal;
    private float distanciaEntreNodos;
    private float velocidad;

    void Start()
    {
        //tiempoTotal = tiempoA.tiempo + tiempoB.tiempo;
        CalcularDistancia();
    }

    void Update()
    {
        float tiempoTranscurrido = Time.time;

        if (tiempoTranscurrido <= tiempoA.tiempo)
        {
            float t = tiempoTranscurrido / tiempoA.tiempo;
            Vector2 nuevaPosicion = Vector2.Lerp(puntoA.transform.position, puntoB.transform.position, t);
            player.position = nuevaPosicion;
        }
        else
        {
            player.position = puntoB.transform.position;
        }
    }

    void CalcularDistancia()
    {
        distanciaEntreNodos = Vector2.Distance(puntoA.transform.position, puntoB.transform.position);
        velocidad = distanciaEntreNodos / tiempoA.tiempo;
        Debug.Log("Velocidad: " + velocidad);
        Debug.Log("Distancia: " + distanciaEntreNodos);
        Debug.Log("tiempo desde el punto A al B :" +tiempoA.tiempo);
        Debug.Log("tiempo desde el punto b al C :" +tiempoB.tiempo);
    }
}




