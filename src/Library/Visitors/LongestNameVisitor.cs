using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library;

public class LongestNameVisitor : IVisitor
{
    public string HijoLargo {get; set;}
    public int LongitudNombre {get; set;}
    public void Visit(Node<Persona> node)
    {
        if (node.GetName().Length > LongitudNombre)
        {
            this.HijoLargo = node.GetName();
            this.LongitudNombre = node.GetName().Length;
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