using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library;

public interface IVisitor<T>
{
    public void Visit(Node<T> node);
}