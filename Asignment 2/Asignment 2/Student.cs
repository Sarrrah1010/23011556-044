using System.Collections.Generic;

namespace Asignment_2
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
    }

    public static class StudentData
    {
        public static List<Student> Students = new List<Student>();
    }
}
