using System.ComponentModel;

namespace projet1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    
}
class Student
{
    private int id;
    private string name;
    private float average;
    private bool isScholarshipHolder;
    private Student(){}
    private Student(string n, float a, bool s)
    {
        name = n;
        average = a;
        isScholarshipHolder = s;
    }
}
