﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using static System.Console;

var b = new Base();
var d1 = new Derived_1();
var d2 = new Derived_2();

b.A();
d1.A();
d2.A();

class Base
{
    public virtual void A()
    {
        WriteLine("Base.A()");
    }
}

class Derived_1 : Base
{
    public override void A()
    {
        WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    public override void A()
    {
        WriteLine("Derived_2.A() - Calling Derived_1.A()");
        base.A(); // เรียกเมธอด A() ของคลาส Derived_1
    }
}