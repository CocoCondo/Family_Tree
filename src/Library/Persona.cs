using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
namespace Library;

public class Persona
{
    public string Nombre {get; set;}
    public int Edad {get; set;}
    public Persona(string nombre, int edad)
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }
    public override string ToString()
    {
        return $"{this.Nombre} {this.Edad}";
    }
}