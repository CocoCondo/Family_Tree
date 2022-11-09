using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library;

public class AgeVisitor : IVisitor
{
    int ValorSuma {get; set;}
    public int Suma {get; set;}
    public void Visit(Node<Persona> node)
    {
        this.ValorSuma += node.GetAge();
        //Console.WriteLine(node.GetName());
        foreach(Node<Persona> n in node.GetList())
        {
            n.Accept(this);            
        }
    }
    public int GetTotalAge()
    {
        this.Suma = this.ValorSuma;
        return this.Suma;
    }
    public override string ToString()
    {
        return $"La suma total de las edades de la familia es: {this.GetTotalAge()}.";
    }
}