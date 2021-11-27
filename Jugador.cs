using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private string nombre = "Nombre: Lara Croft";
    private string nacimiento = "Nacimiento: Inglaterra, 14 de febrero";
    private string nacionalidad = "Nacionalidad: Inglesa";
    private string residencia = "Residencia: Surrey, Inglaterra";
    private string raza = "Raza: Humana Caucásica";
    private string sexo = "Sexo: Mujer";
    private string estatura = "Estatura: 1,68 m";
    private string peso = "Peso: 58 kg";
    private string colorDePelo = "Pelo: Castaño";
    private string colorDeOjos = "Ojos: Marrones";
    private string padres = "Padres: Richard Croft, Amelia Croft";
    private string oficio = "Oficio: Arqueóloga";
    private string aficiones = "Aficiones: Escribir, explorar y aventuras";
    private string especialidad = "Especialidad: Arqueología, atletismo, deporte extremo y tiro con arco";
    private string titulo = "Titulo: Condesa de Abingdon";
    private string equipamiento = "Equipamiento: Pistolas y arco";
    public int ataquePistolas = 30;
    public int balas = 9;
    public int ataqueArco = 15;
    public int flechas = 20;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) InfoJugador();
        if (Input.GetMouseButtonDown(0)) AtaquePistola();
        if (Input.GetMouseButtonDown(2)) Recargar();
        if (Input.GetMouseButtonDown(1)) AtaqueArco();
        if (Input.GetKeyDown(KeyCode.F)) FabricarFlechas();
    }
    void InfoJugador()
    {
        Debug.Log(nombre);
        Debug.Log(nacimiento);
        Debug.Log(nacionalidad);
        Debug.Log(residencia);
        Debug.Log(raza);
        Debug.Log(sexo);
        Debug.Log(estatura);
        Debug.Log(peso);
        Debug.Log(colorDePelo);
        Debug.Log(colorDeOjos);
        Debug.Log(padres);
        Debug.Log(oficio);
        Debug.Log(aficiones);
        Debug.Log(especialidad);
        Debug.Log(titulo);
        Debug.Log(equipamiento);
    }
    void AtaquePistola()
    {
        if (balas >= 1)
        {
            Debug.Log("Lara dispara con las pistolas y causa un daño de: " + ataquePistolas);
            balas = balas - 1;
        }
        else
            Debug.Log("Lara tienes que recargar el arma.");
    }
    void Recargar()
    {
        if (balas < 9)
        {
            Debug.Log("Lara recarga la pistola.");
            balas = 9;
            return;
        }
        else balas = 9;
        {
            Debug.Log("El cargador de Lara ya está lleno.");
        }
    }
    void AtaqueArco()
    {
        if (flechas >= 1)
        {
            Debug.Log("Lara dispara con el arco y causa un daño de: " + ataqueArco);
            flechas = flechas - 1;
        }
        else
            Debug.Log("A Lara no le quedan flechas tienes que fabricar más");
        
    }
    void FabricarFlechas()
    {
        if (flechas < 20)
        {
            Debug.Log("Lara fabrica algunas flechas.");
            flechas = 20;
            return;
        }
        else flechas = 20;
        {
            Debug.Log("Lara ya no puedes llevar más flechas.");
        }
    }
}
