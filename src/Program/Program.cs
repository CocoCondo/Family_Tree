using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("coco", 21);
            Persona p2 = new Persona("julio", 76);
            Persona p3 = new Persona("roberto", 41);
            Persona p4 = new Persona("maria", 23);
            Persona p5 = new Persona("julian", 54);
            Persona p6 = new Persona("huber", 75);
            Persona p7 = new Persona("pepe julian onzima", 11);
            Persona p8 = new Persona("ultimo", 11);

            Node<Persona> n1 = new Node<Persona>();
            Node<Persona> n2 = new Node<Persona>();
            Node<Persona> n3 = new Node<Persona>();
            Node<Persona> n4 = new Node<Persona>();
            Node<Persona> n5 = new Node<Persona>();
            Node<Persona> n6 = new Node<Persona>();
            Node<Persona> n7 = new Node<Persona>();
            Node<Persona> n8 = new Node<Persona>();

            n1.Value = p1;
            n2.Value = p2;
            n3.Value = p3;
            n4.Value = p4;
            n5.Value = p5;
            n6.Value = p6;
            n7.Value = p7;
            n8.Value = p8;

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
