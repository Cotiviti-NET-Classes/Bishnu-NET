using System;

class Student
{
    public Student()
    { }

    public Student(string name, string sem, string mobileNum)
    {
        this.name = name;
        semester = sem;
        mobileNumber = mobileNum;
    }

    public string name;
    public string semester;
    public string mobileNumber;

    void Enroll(string sem)
    {
        Console.WriteLine($"{name} enrolled on {sem}.");
    }
}

class SeniorStudent : Student
{
    public string electiveSubject;

    void EnrollOnInternProgram(string company)
    {
        Console.WriteLine($"{name} is interning on {company}.");
    }
}

class Almuni : SeniorStudent, ILivingThings
{

}

interface ILivingThings
{

}
