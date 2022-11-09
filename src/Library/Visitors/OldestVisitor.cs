using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library;

public class OldestVisitor : IVisitor<Persona>
{
    public string HijoMayor {get; set;}
    public int EdadMayor {get; set;}
    public void Visit(Node<Persona> node)
    {
        if (node.Value.Edad > EdadMayor)
        {
            this.HijoMayor = node.Value.Nombre;
            this.EdadMayor = node.Value.Edad;
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