namespace Solid.Core.Entities
{
    public class Teacher
    {
        //int id;
        //string name;
        //string coursTeaching; //איזה קורס מלמדת

        public int Id { get; set; }
        public string Name { get ; set; }
        public List<Course> CoursesTeaching { get; set; }



        public Teacher(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            //this.CoursesTeaching = coursesTeaching;
        }
    }
}
