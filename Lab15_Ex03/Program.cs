﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using static System.Console;

var animalA = new Dog();
var animalB = new Fish();
var animalC = new Bird();

animalA.Move();
animalB.Move();
animalC.Move();

class Animal
{
    public virtual void Move()
    {
        WriteLine("Animal moved successfully.");
    }
}

class Dog : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType()}: Running on the ground.");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType()}: Swimming in the water.");
    }
}

class Bird : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType()}: Flying in the air.");
    }
}