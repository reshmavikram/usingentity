using System.ComponentModel.DataAnnotations;

namespace usingentity.Model
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }


    }
}
