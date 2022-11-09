using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library;

public interface IComponent
{
    void Accept(IVisitor visitor);
}