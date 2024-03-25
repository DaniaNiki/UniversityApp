namespace UniversityApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Score { get; set; }

        public Student(int id, string name, int age, double score)
        {
            Id = id;
            Name = name;
            Age = age;
            Score = score;
        }
    }
}
