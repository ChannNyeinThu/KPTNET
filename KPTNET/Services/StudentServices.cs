using KPTNET.Models;
using KPTNET.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KPTNET.Services
{
    public class StudentServices : IStudentRepository
    {

        //Now I will create dummy data for laters operations
        //In the real world applicaitons , we need to fetch data from database
        /*Notes : The name of functions in function declaration of interface and funciton int his implementation must be same */

        List<Student> students = new List<Student>() {
        new Student()
        {
            StudentId = 1,
            StudentName = "Chan Nyein",
            Phone = "09977777777",
            Email = "channyeinthu@gmail.com",
            Address = new Address()
            {
                AddressId = 1,
                BuildingNo = "1",
                Floor = "4",
                PostalCode = "56555",
                StreetName = "Hledan",
                Township = "Kamayut township"
            },
            Books = new List<Book>()
            {
                new Book()
                { 
                    BookId = 1, Author = "Chan", BookName = "Gone With The Wind", PublishedDate = DateTime.Now.AddYears(1) 
                },
                new Book()
                { 
                    BookId = 2, Author = "Kyi Pyar", BookName = "A Street cat named 'Bob'", PublishedDate = DateTime.Now
                },

            }
        },
        new Student()
        {
            StudentId = 2,
            StudentName = "Kyaw Kyaw",
            Phone = "0988888888",
            Email = "channyeinthu2@gmail.com",
            Address = new Address()
            {
                AddressId = 1,
                BuildingNo = "1",
                Floor = "4",
                PostalCode = "56555",
                StreetName = "Hledan",
                Township = "Kamayut township"
            },
            Books = new List<Book>()
            {
                new Book()
                { 
                    BookId = 1,
                    Author = "Zaw Zaw", 
                    BookName = "Letters to His son", 
                    PublishedDate = DateTime.Now.AddYears(1) 
                },
                new Book()
                {
                    BookId = 2, 
                    Author = "Swe Ser", 
                    BookName = "A Street cat named 'Bob'", 
                    PublishedDate = DateTime.Now
                },

            }
        }
    };
        //Add new student to list
        public string CreateNewStudent(Student student)
        {
            students.Add(student);

            return student.StudentName;
        }
        
        //Delete Student from list
        public List<Student> DeleteStudent(int studentId)
        {
            var studentToDelete = students.FirstOrDefault(x => x.StudentId == studentId);

            if(studentToDelete != null)
            {
                students.Remove(studentToDelete);
                return students;
            }
            else
            {
                return null;
            }
            
        }
        public void UpdateStudent(Student student)
        {
            var studentToUpdate = students.FirstOrDefault(x => x.StudentId == student.StudentId);

            if(studentToUpdate != null)
            {
                studentToUpdate = student;
            }
        }
        
        //Get Student by Id
        public Student GetStudentById(int studentId)
        {
           
            Student student = students.Where(s => s.StudentId == studentId).FirstOrDefault();
            return student;
        }
        
        //Get All Students
        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
