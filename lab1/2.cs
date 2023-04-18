using System;

class Student {
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program {
    static void Main(string[] args) {
        Student student = new Student() {
            Id = 191832,
            Name = "Dawa Tamang Moktan"
        };
        
        Console.WriteLine("Student ID: " + student.Id);
        Console.WriteLine("Student Name: " + student.Name);
    }
}
