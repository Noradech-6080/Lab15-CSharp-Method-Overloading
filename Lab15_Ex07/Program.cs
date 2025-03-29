﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Derived_2 d2 = new Derived_2();
Base b = (Base)d2;
Derived_1 d1 = (Derived_1)d2;

b.A();
d1.A();
d2.A();

class Base
{
    public virtual void A()
    {
        Console.WriteLine("Base.A()");
    }
}

class Derived_1 : Base
{
    public override void A()
    {
        Console.WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    public new void A()
    {
        Console.WriteLine("Derived_2.A()");
    }
}