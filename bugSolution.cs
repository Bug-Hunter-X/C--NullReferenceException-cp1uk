public class MyClass
{
    public int? MyProperty { get; set; }

    public void MyMethod()
    {
        // Handle null case using the null-conditional operator (?.)
        Console.WriteLine(MyProperty?.ToString() ?? "MyProperty is null");
    }
}