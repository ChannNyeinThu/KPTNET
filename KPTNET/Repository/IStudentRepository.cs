using KPTNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPTNET.Repository
{
    public interface IStudentRepository
    {
        /// <summary>
        /// 
        /// This is the interface for Studnet , that will be implmented later in the service folder
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        string CreateNewStudent(Student student);
        List<Student> DeleteStudent(int studentId);
        void UpdateStudent(Student student);
        Student GetStudentById(int studentId);
        List<Student> GetStudents();
    }
}
