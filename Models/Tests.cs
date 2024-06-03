namespace GenericInheritance_Example.Models
{
    public class Tests
    {
        // Test the inheritance !
    }

    public class Test1<T>
    {
        //a generic Class can inheritance a normall class
    }
    public class Test2 : Test1<int>
    {
        // normal class cant inheritance an unkown generic class!
        // but it will work if the datatype is cleard
    }

    public class Test3<T> : Test1<T>
    {
        //Generic Classes can inheritance each other !
        // but the refrens should be the same even if it have multiple refrens like : <T , K , Z>
    }

}
