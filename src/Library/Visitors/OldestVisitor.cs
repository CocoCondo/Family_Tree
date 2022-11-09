using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library;

public class OldestVisitor : IVisitor
{
    public string HijoMayor {get; set;}
    public int EdadMayor {get; set;}
    public void Visit(Node<Persona> node)
    {
        if (node.GetAge() > EdadMayor)
        {
            this.HijoMayor = node.GetName();
            this.EdadMayor = node.GetAge();
        }
        foreach(Node<Persona> n in node.GetList())
        {
            n.Accept(this);            
        }
    }
    public override string ToString()
    {
        return $"El hijo mayor es {this.HijoMayor} con {this.EdadMayor} años.";
    }
}