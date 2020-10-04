using KPTNET.Models;
using KPTNET.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPTNET.Methods
{
    public class Method
    {
        StudentServices _studentService = new StudentServices();
        public string CreateNewStudent(Student student)
        {
           
            string resultStudentName = _studentService.CreateNewStudent(student);
            return resultStudentName;
        }
        public Student GetStudentById(int studentId)
        {
            
            return _studentService.GetStudentById(studentId);
        }
        public List<Student> GetAllStudents()
        {
            
            return _studentService.GetStudents();
        }
        public List<Student> DeleteStudnet(int studentId)
        {
           
            return _studentService.DeleteStudent(studentId);
        }
        public void UpdateStudent(Student student)
        {
            
            _studentService.UpdateStudent(student);
        }
    }
}
