// See https://aka.ms/new-console-template for more information
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

MyNamespace.Class2 class2 = new MyNamespace.Class2();

string jsonText;

try
{
    jsonText = System.Text.Json.JsonSerializer.Serialize(class2);
}
catch (Exception ex)
{
    jsonText = "EXCEPTION: " + ex.Message;

    System.Diagnostics.Debug.Write(ex.ToString());
}

Console.WriteLine(jsonText);

namespace MyNamespace
{
    public class Class1
    {

    }

    public class Class2 : MyNamespaceBase.Class2
    {
        [JsonIgnore]
        public new Class1 class1 => new Class1();
    }
}

namespace MyNamespaceBase
{
    public class Class1
    {

    }

    public class Class2
    {
        [JsonIgnore]
        public Class1 class1 => new Class1();
    }
}