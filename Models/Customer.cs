namespace GenericInheritance_Example.Models
{
    public class Customer : BaseClass<int , DateTime>
    {
        //public int Id { get; set; }                   Using BaseClass to prevent Code repetition
        //public DateTime CreationDate { get; set; }        
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
