namespace GenericInheritance_Example.Models
{
    public class BaseClass <TKey , TDate>
    {
        public TKey Id { get; set; }
        public TDate CreationDate { get; set; }
    }
}
