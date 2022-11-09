using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System;

namespace Library
{
    public class Node<T> : IComponent
    {
        private int number;
        private Persona persona;

        private List<Node<T>> children = new List<Node<T>>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, string nombre, int edad)
        {   
            persona = new Persona(nombre, edad);
            this.number = number;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        public List<Node<T>> GetList()
        {
            return this.children;
        }

        public int GetAge()
        {
            return persona.Edad;
        }
        public string GetName()
        {
            return persona.Nombre;
        }

        public string GetChildren()
        {
            StringBuilder children = new StringBuilder();
            children.Append("Lista de hijos:\n");
            foreach(Node<T> child in this.children)
            {
                children.Append($"{child.persona.ToString()}");
            }
            return children.ToString();
        }
        
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this as Node<Persona>);
        }
    }
}
