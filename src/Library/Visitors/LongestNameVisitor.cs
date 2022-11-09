using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library;

public class LongestNameVisitor : IVisitor<Persona>
{
    public string HijoLargo {get; set;}
    public int LongitudNombre {get; set;}
    public void Visit(Node<Persona> node)
    {
        if (node.Value.Nombre.Length > LongitudNombre)
        {
            this.HijoLargo = node.Value.Nombre;
            this.LongitudNombre = node.Value.Nombre.Length;
        }
        foreach(Node<Persona> n in node.GetList())
        {
            n.Accept(this);            
        }
    }
    public override string ToString()
    {
        return $"El hijo con el nombre más largo es {this.HijoLargo} con {this.LongitudNombre} letras.";
    }
}