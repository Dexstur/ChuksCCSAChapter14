using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From1
{
    public class Student
    {
        public string Name { get; set; }    
        public string ?Course { get; set; }
        public string ?University { get; set; }
        public string ?Email { get; set; }
        public string ?PhoneNo { get; set; }
        public static int Count { get; private set; } = 0;
        public Student() {
            Count++;
            Name = "student" + Count;
        }
        public Student(string name)
        {
            Name = name;
            Count++;
        }
        public Student(string name, string email, string phoneNo)
        {
            Name = name;
            Email = email;
            PhoneNo = phoneNo;
            Count++;
        }
        public static void GetInfo(Student student)
        {
            Console.WriteLine($"Name: { student.Name}");
            if(student.Email != null) Console.WriteLine($"Email: {student.Email}");
            if(student.PhoneNo != null) Console.WriteLine($"Phone Number: {student.PhoneNo}");
            if(student.University != null)Console.WriteLine($"Institution: {student.University}");
            if(student.Course != null) Console.WriteLine($"Course: {student.Course}");
        }

    }
}
