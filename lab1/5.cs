using System;

class Animal {
    public void Eat() {
        Console.WriteLine("The animal is eating.");
    }
}

class Dog : Animal {
    public void Bark() {
        Console.WriteLine("The dog is barking.");
    }
}

interface IWalk {
    void Walk();
}

interface ISwim {
    void Swim();
}

class Duck : IWalk, ISwim {
    public void Walk() {
        Console.WriteLine("The duck is walking.");
    }

    public void Swim() {
        Console.WriteLine("The duck is swimming.");
    }
}
class Vehicle {
    public void Drive() {
        Console.WriteLine("The vehicle is being driven.");
    }
}

class Car : Vehicle {
    public void Honk() {
        Console.WriteLine("The car is honking its horn.");
    }
}

class SportsCar : Car {
    public void Accelerate() {
        Console.WriteLine("The sports car is accelerating.");
    }
}

class Shape {
    public virtual void Draw() {
        Console.WriteLine("Drawing a shape.");
    }
}

class Circle : Shape {
    public override void Draw() {
        Console.WriteLine("Drawing a circle.");
    }
}

class Square : Shape {
    public override void Draw() {
        Console.WriteLine("Drawing a square.");
    }
}

class Program {
    static void Main(string[] args) {
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();
        Console.WriteLine();

        Duck duck = new Duck();
        duck.Walk();
        duck.Swim();
        Console.WriteLine();

        SportsCar sportsCar = new SportsCar();
        sportsCar.Drive();
        sportsCar.Honk();
        sportsCar.Accelerate();
        Console.WriteLine();

        Shape[] shapes = new Shape[] { new Shape(), new Circle(), new Square() };
        foreach (Shape shape in shapes) {
            shape.Draw();
        }
    }
}
