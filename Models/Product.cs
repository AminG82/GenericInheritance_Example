namespace GenericInheritance_Example.Models
{
    public class Product : BaseClass
    {
        //public double Id { get; set; }                Using BaseClass to prevent Code repetition
        //public DateTime CreationDate { get; set; }        but there is a problem with Id datatype! its not int in both Entitys
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
