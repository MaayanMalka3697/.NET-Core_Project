namespace Solid.Core.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            //Courses = courses;
        }
    }
}
