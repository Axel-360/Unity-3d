using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private string nombre = "Nombre: Dr. Pedro Domínguez";
    private string nacimiento = "Nacimiento: Paititi";
    private string nacionalidad = "Nacionalidad: Perú";
    private string residencia = "Cozumel, Mexico";
    private string raza = "Raza: Humana Amerindia";
    private string sexo = "Sexo: Hombre";
    private string estatura = "Estatura: 1,75 m";
    private string peso = "Peso: 65 kg";
    private string colorDePelo = "Pelo: Negro";
    private string colorDeOjos = "Ojos: Marrones";
    private string padres = "Padres: Desconocidos, fue criado por forasteros pertenecientes a La Trinidad";
    private string oficio = "Oficio: Arqueólogo experimentado, Jefe del Alto Consejo de La Trinidad, Líder del Culto de Kukulkán";
    private string aficiones = "Aficiones: Aficionado por la cultura Maya";
    private string equipamiento = "Equipamiento: Pistola y cuchillo";
    public int ataquePistolas = 50;
    public int balas = 9;
    public int machete = 15;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) InfoEnemigo();
        if (Input.GetKeyDown(KeyCode.A)) AtaquePistola();
        if (Input.GetKeyDown(KeyCode.R)) Recargar();
        if (Input.GetKeyDown(KeyCode.M)) AtaqueMachete();
    }
    void InfoEnemigo()
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
        Debug.Log(equipamiento);
    }
    void AtaquePistola()
    {
        if (balas >= 1)
        {
            Debug.Log(" Pedro te dispara con la pistola y te causa un daño de: " + ataquePistolas);
            balas = balas - 1;
        }
        else
            Debug.Log("Pedro tiene que recargar el arma.");
    }
    void Recargar()
    {
        if (balas < 9)
        {
            Debug.Log("Pedro recarga la pistola.");
            balas = 9;
            return;
        }
        else balas = 9;
        {
            Debug.Log("Pedro ya tiene el cargador lleno.");
        }
    }
    void AtaqueMachete()
    {
            Debug.Log("Pedro te pega con el machete y te causa un daño de: " + machete);
    }
}
