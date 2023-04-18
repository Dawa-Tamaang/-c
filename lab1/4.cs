using System;

class Student {
    private string[] names = new string[5];

    public string this[int index] {
        get {
            return names[index];
        }
        set {
            names[index] = value;
        }
    }
}

class Program {
    static void Main(string[] args) {
        Student student = new Student();
        student[0] = "Sujan";
        student[1] = "Samin";
        student[2] = "samir";
        student[3] = "ashmin";
        student[4] = "durga";

        Console.WriteLine("Names of students:");
        Console.WriteLine(student[0]);
        Console.WriteLine(student[1]);
        Console.WriteLine(student[2]);
        Console.WriteLine(student[3]);
        Console.WriteLine(student[4]);
    }
}
