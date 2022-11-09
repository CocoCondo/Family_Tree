using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library;

public interface IComponent<T>
{
    void Accept(IVisitor<T> visitor);
}