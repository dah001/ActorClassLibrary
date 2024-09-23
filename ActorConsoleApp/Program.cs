// See https://aka.ms/new-console-template for more information
using ActorClassLibrary;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

ActorClassLibrary.Actor actor = new ActorClassLibrary.Actor("Olesen", 3, 2000);
Console.WriteLine(actor.Name);
Console.WriteLine(actor.Id);
Console.WriteLine(actor.BirthYear);


