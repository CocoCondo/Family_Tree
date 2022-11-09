using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library;

public interface IVisitor
{
    public abstract void Visit(Node<Persona> node);
}