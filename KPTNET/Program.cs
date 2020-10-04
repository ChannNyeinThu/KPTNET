using KPTNET.Methods;
using KPTNET.Models;
using System;
using System.Collections.Generic;

namespace KPTNET
{
    public class Program
    {

        static void Main(string[] args)
        {
            do
            {
                Method method = new Method();
                int userChoice = 0;
                if (userChoice == 0)
                {
                    // Now I will call funciton from services
                    Console.WriteLine("Please choose option for operations :" + "\n");
                    Console.WriteLine("Choose 1 for : View All Students \n");
                    Console.WriteLine("Choose 2 for : For View student detail by ID \n");
                    Console.WriteLine("Choose 3 for : Delete student by ID \n");
                    Console.WriteLine("Choose 4 for : Create New Student \n");
                    Console.WriteLine("Choose 5 for : Update Student \n");
                    userChoice = int.Parse(Console.ReadLine());
                }


                if (userChoice == 1)
                {
                    List<Student> students = method.GetAllStudents();

                    foreach (var std in students)
                    {
                        ShowInformation(std);
                    }

                    Console.WriteLine("Press 0 to exit program or choose options to do other operations");
                    userChoice = int.Parse(Console.ReadLine());
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Plz enter ID number of Student ");
                    try
                    {
                        int studentId = int.Parse(Console.ReadLine());
                        Student student = method.GetStudentById(studentId);
                        ShowInformation(student);
                        Console.WriteLine("Press 0 to exit program or choose options to do other operations");
                        userChoice = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("There is no student with Id you typed ");

                        Console.WriteLine(ex.Message);

                        Console.WriteLine("Press 0 to restart program or choose options to do other operations");
                        userChoice = int.Parse(Console.ReadLine());

                    }

                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Plz enter ID number of Student ");
                    try
                    {
                        int studentId = int.Parse(Console.ReadLine());
                        List<Student> students = method.DeleteStudnet(studentId);
                        foreach(Student std in students)
                        {
                            ShowInformation(std);
                        }
                        //Console.WriteLine(studentName + "has been deleted successfully.... \n");
                        Console.WriteLine("Press 0 to restart program or choose options to do other operations");
                        userChoice = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("There is no student with Id you typed ");

                        Console.WriteLine(ex.Message);

                        Console.WriteLine("Press 0 to restart program or choose options to do other operations");
                        userChoice = int.Parse(Console.ReadLine());

                    }
                }
                else
                {
                    Console.WriteLine("Plz type only 1, 2, 3, 4 to choose options");
                    userChoice = int.Parse(Console.ReadLine());
                }

            }
            while (true);

        }

        private static void ShowInformation(Student std)
        {
            Console.WriteLine("Student ID :" + std.StudentId.ToString());
            Console.WriteLine("Student Name :" + std.StudentName);
            Console.WriteLine("Student Email :" + std.Email);
            Console.WriteLine("Student Phone :" + std.Phone + "\n\n");
            Console.WriteLine("Student Address : => ");
            Console.WriteLine("     Address ID :" + std.Address.AddressId.ToString());
            Console.WriteLine("     Building No :" + std.Address.BuildingNo);
            Console.WriteLine("     Street  :" + std.Address.StreetName);
            Console.WriteLine("     Postal Code :" + std.Address.PostalCode + "\n\n\n");
        }
       
    }
}
