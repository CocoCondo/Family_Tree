using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<Persona> n1 = new Node<Persona>(1, "coco", 21);
            Node<Persona> n2 = new Node<Persona>(2, "julio", 76);
            Node<Persona> n3 = new Node<Persona>(3, "roberto", 41);
            Node<Persona> n4 = new Node<Persona>(4, "maria", 23);
            Node<Persona> n5 = new Node<Persona>(5, "julian", 54);
            Node<Persona> n6 = new Node<Persona>(6, "huber", 75);
            Node<Persona> n7 = new Node<Persona>(7, "pepe julian onzima", 11);
            Node<Persona> n8 = new Node<Persona>(8, "ultimo", 11);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);


            AgeVisitor coso = new AgeVisitor();
            OldestVisitor mayor = new OldestVisitor();
            LongestNameVisitor largo = new LongestNameVisitor();
            coso.Visit(n1);
            mayor.Visit(n1);
            largo.Visit(n1);
            Console.WriteLine(coso);
            Console.WriteLine(mayor);
            Console.WriteLine(largo);
            // visitar el árbol aquí
        }
    }
}
