using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library;

public class AgeVisitor : IVisitor<Persona>
{
    int ValorSuma {get; set;}
    public void Visit(Node<Persona> node)
    {
        this.ValorSuma += node.Value.Edad;
        foreach(Node<Persona> n in node.GetList())
        {
            n.Accept(this);            
        }
    }
    public override string ToString()
    {
        return $"La suma total de las edades de la familia es: {this.ValorSuma}.";
    }
}