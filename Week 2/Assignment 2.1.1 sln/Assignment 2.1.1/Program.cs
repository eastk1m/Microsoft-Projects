namespace Assignment_2._1._1
{
    public enum Role { Teacher, Student };


    public abstract class Student
    {
        private int studentID;
        private string studentFName;
        private string studentLName;
        private char studentGrade;

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string StudentFName
        {
            get { return studentFName; }
            set { studentFName = value; }
        }

        public string StudentLName
        {
            get { return studentLName; }
            set { studentLName = value; }
        }

        public char StudentGrade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }
    }

    internal class Program
    {
        private static string Student()
        {
            return StudentFName;
        }

        private static void Main(string[] args, string studentFName)
        {
            Student student = new Student
            {
                StudentID = 1,
                studentFName = "Esther",
                StudentLName = "Kim",
                StudentGrade = 'A'
            };

            Console.WriteLine(student);
            Console.WriteLine("Student ID is: " + student.StudentID);
            Console.WriteLine("Student first name is: " + student.StudentFName);
            Console.WriteLine("Student last name is: " + student.StudentLName);
            Console.WriteLine("Student Grade is: " + student.StudentGrade);
        }

    }
}