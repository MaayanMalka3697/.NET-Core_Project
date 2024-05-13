namespace Solid.Core.Entities
{
    public class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

         public List<Student> Students { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
         
        public Course(int id, string name, double price,int teacherId)
        {
            Id = id;
            Name = name;
            Price = price;
           // Students = students;
            TeacherId = teacherId;
            //Teacher = teacher;
        }
    }
}
