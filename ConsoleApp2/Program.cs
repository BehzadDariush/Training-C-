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
int studentnum = 0;
List<Student> students = new List<Student>();
List<Classroom> Classrooms = new List<Classroom>();
List<Classtudent> Classtudents = new List<Classtudent>();


while (true)
{
   
    Console. WriteLine(" Which one you whant to choose :\n1: <class> \n2:<student> \n3: <Exit>");
    Console.Write("UR choose: ");
    UserChoose = Console.ReadLine();
    
    returnto = 0;


    if (UserChoose == "1" || UserChoose == "class")
    {
       
        while (returnto < 1)
        {
            Console.Clear();
            Console.WriteLine("------------ you are in class part --------------");
            Console.WriteLine(" Which one you whant to choose :\n1: <Make> a class \n2: <Add> student to class by student code" +
           "\n3: <show student> to specific class\n4 show class <list> \n5: <return>");
            Console.Write("UR choose: ");
            UserChoose = Console.ReadLine();
            if (UserChoose == "1" || UserChoose == "make")
            {
                Console.Write("Your classname you want to add is : ");
                UserChoose = Console.ReadLine();
                Classroom newclassroom = new Classroom();
                newclassroom.classname = UserChoose.ToString();
                Classrooms.Add(new Classroom() { classname = newclassroom.classname.ToUpper() });
                Classrooms.ForEach(Classrooms => Console.WriteLine(Classrooms.classname));


            }
            else if (UserChoose == "2" || UserChoose == "add")
            {
                if (Classrooms.Count() == 0)
                {
                    Console.WriteLine("there is no class make yet !");
                    Console.ReadLine();
                }
                else
                {
                    Classrooms.ForEach(Classrooms => Console.WriteLine(Classrooms.classname));
                    Console.Write("which class you want to add student ? ");
                    UserChoose = Console.ReadLine().ToUpper();
                    Console.Write("enter student code :  ");
                    studentcode = Console.ReadLine();
                    for (int y = 0; y < studentnum; y++)
                    {

                        if ((students[y].StudentCode) == studentcode)
                        {
                            Classtudent newclasstudent = new Classtudent();
                            newclasstudent.classname = UserChoose.ToUpper();
                            Classtudents.Add(new Classtudent() { classname = UserChoose,firstname= students[y].FirstName, lastname = students[y].LastName, studentcode = students[y].StudentCode });
                            Console.WriteLine(students[y].FirstName + " is added to " + UserChoose + " class");
                        }
                    }
                    Console.ReadLine();
                }
                

            }
            else if (UserChoose == "3" || UserChoose == "show student") 
            {
                Classrooms.ForEach(Classrooms => Console.WriteLine(Classrooms.classname));
                Console.Write("which class you want to show student ? ");
                UserChoose = Console.ReadLine();
                      
                for (int y = 0;y < Classtudents.Count;y++)
                {
                 if (Classtudents[y].classname == UserChoose.ToUpper()) 
                    {
                        Console.WriteLine(Classtudents[y].firstname + "   " + Classtudents[y].lastname + "    " + Classtudents[y].studentcode);
                    }
                
                }

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
                Console.Clear();
            }
        }
    }
    else if (UserChoose == "2" || UserChoose == "student") 
    {
        while (returnto < 1)
        {
            Console.Clear();
            Console.WriteLine("------------ you are in student part --------------");
            Console.WriteLine(" input a number:\n1: <Add> \n2: <Show> all\n3: <search> \n4: <return>");
            Console.WriteLine(studentnum);
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
                  ///  Console.Clear();
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
                    Console.ReadLine() ;
                }
                else if (userEnter == 3)//// searcher
                {
                    Console.Clear();
                    Console.Write("PLZ Enter a name that you want to search : ");

                    string letter = Console.ReadLine();
                    int counter = 0;
                    for (int y = 0; y < studentnum; y++)
                    {

                        if (students[y].FirstName.StartsWith(letter))
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
                    returnto = 1;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" -------PLZ Enter Right Num-------- ");
                }


            }

            else
            {
                Console.Clear();
                Console.WriteLine(" -------PLZ Enter a Num-------- ");
            }

        }
        
       



    }
    else if(UserChoose == "3" || UserChoose == "exit")
        {
        break;
        }

}




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


class Classroom
{
    public string classname { get; set; }

    public string classroom()
    {
        return (classname);
    }

}
class Classtudent
{
    public string studentcode { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string classname { get; set; }
    public string classtudent()
    {
       return (classname+firstname+lastname+studentcode);
    }
}