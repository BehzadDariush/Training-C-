// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Immutable;
using static System.Net.Mime.MediaTypeNames;
//// i is input counter
int i = 0;

List<Student> students = new List<Student>();
do
{
    Console.WriteLine(" input a number:\n1: Adding \n2: Show all\n3: search \n4: Exit");
    int index = 0;
    string b;
    Console.Write("UR Number: ");
    b = Console.ReadLine();
    if (b != null && int.TryParse(b, out int value))
    {
        int userEnter = Convert.ToInt32(b);
        ////userEnter is the nm that user enter
        if (userEnter == 1)
        {

            i++;
            Student mystudent = new Student();
            Console.Write("inter student code : ");
            mystudent.StudentCode = Console.ReadLine().ToString();
            Console.Write("inter student first name : ");
            mystudent.FirstName = Console.ReadLine();
            Console.Write("inter studentlast name : ");
            mystudent.LastName = Console.ReadLine();
            students.Add(new Student() { FirstName = mystudent.FirstName, LastName = mystudent.LastName, StudentCode = mystudent.StudentCode });

            Console.WriteLine(mystudent.FirstName + "  " + mystudent.LastName + "  " + mystudent.StudentCode);
        }
        else if (userEnter == 2)///// show the list
        {
            Console.Clear();
            while (index < i)
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
            string letter;
            letter = Console.ReadLine();
            int counter = 0;            
            for (int y = 0; y < i; y++)
            {
                
                if (students[y].FirstName.StartsWith (letter))
                {
                    Console.WriteLine(students[y].FirstName + "  " + students[y].LastName + "  " + students[y].StudentCode);
                 counter++;
                }
                
            }
            if (counter == 0)
            {
                Console.WriteLine("The name does match");
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


