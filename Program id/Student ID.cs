using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_id;

    internal class Student_ID
{
    public string Name;
    public string Surname;
    public string Group;
    public byte Point;
    public bool IsGraduatet;

    public Student_ID(string name, string surname)
    {
        Console.WriteLine("FullName: " + name + " " + surname);
        Name = name;
        Surname = surname;
    }

    public Student_ID(string name, string surname, string group, byte point, bool isgraduated)
    {
        Name = name;
        Surname = surname;
        Group = group;
        Point = point;
        IsGraduatet = isgraduated;

        if (isgraduated)
        {
            Console.WriteLine("FullName: " + name + " " + surname);
            Console.WriteLine("Goroup: " + group);
            Console.WriteLine("Point: " + point);
            Console.WriteLine("You no graduated!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you didn't graduated!");
        }
    }

    public Student_ID(string name, string surname, string group, byte point)
    {
        Name = name;
        Surname = surname;
        Group = group;
        Point = point;

        if (point >= 80 && point <= 100)
        {
            Console.WriteLine(name + " " + surname + ": You can enter the next exam to increase your score.");
        }
        else if (point < 80)
        {
            Console.WriteLine(name + " " + surname + ": Unfortunately, you cannot enter the next exam.");
        }
        else
        {
            Console.WriteLine("Please enter a valid point value.");
        }
    }
}

