using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System;

namespace Library
{
    public class Node<T> : IComponent<T>
    {
        public T Value {get; set;}

        private List<Node<T>> children = new List<Node<T>>();

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }
        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        public List<Node<T>> GetList()
        {
            return this.children;
        }
        
        public void Accept(IVisitor<T> visitor)
        {
            visitor.Visit(this);
        }
    }
}
