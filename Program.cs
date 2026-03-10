using System.ComponentModel;

namespace projet1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Student s1 = new Student("Alice", 15.5f, true);
        Student s2 = new Student("Bernard", 4.0f, false);
        Student s3 = new Student("Emma", 17.0f, true);
        Student s4 = new Student("Lucas", 2.0f, false);
        Student s5 = new Student("Sarah", 8.0f, false);

        Course c1 = new Course("Mathematique", 3.0f, true);
        Course c2=new Course("Informatique", 4.0f, true);
        Course c3=new Course("Anglais", 2.0f, false);
        Course c4 =new Course("Histoire", 3.0f, true);

        c1.AddStudent(s1);
        c2.AddStudent(s2);
        c3.AddStudent(s3);
        c4.AddStudent(s4);

        List<Course> courses = new List<Course>();

         courses.Add(c1);
        courses.Add(c2);
        courses.Add(c3);
        courses.Add(c4);
Console.WriteLine("Liste des cours :");

foreach (Course c in courses)
{
    c.Display();
}

     
    }

    
}
class Student
{
    private int id;
    private string name;
    private float average;
    private bool isScholarshipHolder;
    public Student(){}
    public Student(string name, float average, bool isScholarshipHolder)
    {
        this.name = name;
        this.average = average;
        this.isScholarshipHolder = isScholarshipHolder;
    }
    public void Display()
{
    Console.WriteLine("Nom : " + name);
    Console.WriteLine("Moyenne : " + average);

    if (isScholarshipHolder)
        Console.WriteLine("Boursier");
    else
        Console.WriteLine("Non boursier");

    Console.WriteLine();
}
}
class Course
{
    private int id;
    private string name;
    private float credits;

    private bool isMandatory;

    private List<Student> student;

    public Course() { }
    public Course(string name, float credits, bool isMandatory)
    {
        this.name = name;
        this.credits = credits;
        this.isMandatory = isMandatory;
        student = new List<Student>();
    }
    public void AddStudent(Student s)
    {
        student.Add(s);
    }
    
    public void Display()
{
    Console.WriteLine("Nom du cours : " + name);
    Console.WriteLine("Crédits : " + credits);

    if (isMandatory)
        Console.WriteLine("Cours obligatoire");
    else
        Console.WriteLine("Cours non obligatoire");

    Console.WriteLine("Nombre d'étudiants inscrits : " + student.Count);
    Console.WriteLine("---------------------------");
}
public void DisplayStudents()
{
    Console.WriteLine("Etudiants inscrits :");

    foreach (Student s in student)
    {
        s.Display();
    }
}
 
        
    
 
    
}
