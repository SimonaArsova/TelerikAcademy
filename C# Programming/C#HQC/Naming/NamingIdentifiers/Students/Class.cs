namespace Students
{
    public class Class
    {
        public void AddStudent(int numberInClass)
        {
            Student student = new Student();
            student.Age = numberInClass;
            if (numberInClass % 2 == 0)
            {
                student.Name = "Ivan";
                student.Gender = GenderOfStudent.Male;
            }
            else
            {
                student.Name = "Mariya";
                student.Gender = GenderOfStudent.Female;
            }
        }

        public class Student
        {
            public GenderOfStudent Gender { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
