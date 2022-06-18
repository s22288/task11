using cw11.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Data.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> Students { get; set; }
        public StudentService()
        {
            Students = new List<Student>()
            {
                new Student
                {
                    IdStudent = 1,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    BirthDate = DateTime.Parse("2000-01-01"),
                    Avatar = "https://gravatar.com/avatar/798f7add0a0f7241e84c63342df3faec?s=400&d=robohash&r=x",
                    Studies = "Informatyka"
                },
                new Student
                {
                    IdStudent = 2,
                    FirstName = "Adam",
                    LastName = "Nowak",
                    BirthDate = DateTime.Parse("2001-01-01"),
                    Avatar = "https://fwcdn.pl/fpo/91/13/299113/7332755.3.jpg",
                    Studies = "Zarządzanie informacją"
                },
                new Student
                {
                    IdStudent = 3,
                    FirstName = "Anna",
                    LastName = "Lewandowska",
                    BirthDate = DateTime.Parse("2002-01-01"),
                    Avatar = "https://asset.vg247.com/hitman_new_face.jpg/BROK/thumbnail/1200x900/quality/100/hitman_new_face.jpg",
                    Studies = "SNM"
                }
            };
        }
        public void DeleteStudent(int id)
        {
            Students.Remove(GetStudent(id));
        }

        public Student GetStudent(int id)
        {
            return Students.FirstOrDefault(e => e.IdStudent == id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return Students;
        }
    }
}
