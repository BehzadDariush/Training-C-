// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Immutable;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;
////studentnum is input counter
///

int returnto = 0;
string UserChoose;
string studentcode;


while (true)
{
    Console. WriteLine(" Which one you whant to choose :\n1: class \n2: student \n3: Exit");
    Console.Write("UR choose: ");
    UserChoose = Console.ReadLine();
    List<Classroom> Classrooms = new List<Classroom>();
    if (UserChoose == "1" || UserChoose == "class")

        Console.Clear();
        Console.WriteLine("------------ you are in class part --------------");
    {
        while (returnto < 1)
        {
            Console.WriteLine(" Which one you whant to choose :\n1: <Make> a class \n2: <Add> student to class by student code" +
           "\n3: show student to specific class\n4 show class <list> \n5: <return>");
            Console.Write("UR choose: ");
            UserChoose = Console.ReadLine();
            if (UserChoose == "1" || UserChoose == "make")
            {
                Console.Write("Your classname you want to add is : ");
                UserChoose = Console.ReadLine();
                Classroom newclassroom = new Classroom();
                newclassroom.classname = UserChoose.ToString();
                Classrooms.Add(new Classroom() { classname = newclassroom.classname.ToUpper() });

                Console.ReadLine();

            }
            else if (UserChoose == "2" || UserChoose == "add")
            {
                if (Classrooms.Count() == 0)
                {
                    Console.WriteLine("there is no class make yet !");
                }
                else
                {
                    Classrooms.ForEach(Classrooms => Console.WriteLine(Classrooms.classname));
                    Console.Write("which class you want to add student ? ");
                    UserChoose = Console.ReadLine();
                    Console.Write("enter student code :  ");
                    studentcode = Console.ReadLine();

                }
                Console.Write("Your classname you want to add is : ");
                UserChoose = Console.ReadLine();
                Classrooms.ForEach(Classrooms => Console.WriteLine(Classrooms.classname));
                Console.ReadLine();

            }
            else if (UserChoose == "4" || UserChoose == "list")
            {

                Classrooms.ForEach(Classrooms => Console.WriteLine(Classrooms.classname));
                Console.ReadLine();

            }
            else if (UserChoose == "5" || UserChoose == "return")
            {
                returnto = 1;
                Console.Write(returnto);
                Console.Clear();
            }
        }
    }
}



/*
int studentnum = 0;
List<Student> students = new List<Student>();
do
{
    Console.WriteLine(" input a number:\n1: Adding \n2: Show all\n3: search \n4: Exit");
    
    string b;
    Console.Write("UR Number: ");
    b = Console.ReadLine();
    if (b != null && int.TryParse(b, out int value))
    {
        int userEnter = Convert.ToInt32(b);
        ////userEnter is the nm that user enter
        if (userEnter == 1)
        {

            studentnum++;
            Student mystudent = new Student();
            Console.Write("enter student code : ");
            mystudent.StudentCode = Console.ReadLine().ToString();
            Console.Write("enter student first name : ");
            mystudent.FirstName = Console.ReadLine();
            Console.Write("enter student last name : ");
            mystudent.LastName = Console.ReadLine();
            students.Add(new Student() { FirstName = mystudent.FirstName, LastName = mystudent.LastName, StudentCode = mystudent.StudentCode });

            Console.WriteLine(mystudent.FirstName + "  " + mystudent.LastName + "  " + mystudent.StudentCode);
        }
        else if (userEnter == 2)///// show the list
        {
            int index = 0;
            Console.Clear();
            while (index < studentnum)
            {
                Console.WriteLine(students[index].FirstName + "  " + students[index].LastName + "  " + students[index].StudentCode);
                index = index + 1;
            }
            if (index == 0)
            {
                Console.WriteLine("there is no item in the list");
                Console.ReadLine();
            }
        }
        else if (userEnter == 3)//// searcher
        {
            Console.Clear();
            Console.Write("PLZ Enter a name that you want to search : ");
            
            string letter = Console.ReadLine();
            int counter = 0;            
            for (int y = 0; y < studentnum; y++)
            {
                
                if (students[y].FirstName.StartsWith (letter))
                {
                    Console.WriteLine(students[y].FirstName + "  " + students[y].LastName + "  " + students[y].StudentCode);
                 counter++;
                }
                
            }
            if (counter == 0)
            {
                Console.WriteLine("The name does not match");
            }
            Console.ReadLine();
        }
        else if (userEnter == 4)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.Clear();
            Console.WriteLine(" -------PLZ Enter Right Num-------- ");
        }


    }

    else
    {
       Console.Clear() ;
       Console.WriteLine(" -------PLZ Enter a Num-------- ");
    }

}
while (true);
Console.Read();


class Student
{
    public string StudentCode { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }
   
    public string student()
    {
        return (FirstName+LastName+StudentCode);

    }
}

*/
class Classroom
{
    public string classname { get; set; }
   

    public string classroom()
    {
        return (classname);

    }
    public string classstudent()
    {
        return (classname + stdentcode + firsname + lastname);
    }

    public string stdentcode { get; set; }
    public string firsname {get; set; }
    public string lastname { get; set; }
   
    
}
