// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SomeClasses.Class2 class2 = new SomeClasses.Class2();

string jsonText;

try
{
    jsonText = System.Text.Json.JsonSerializer.Serialize(class2);
}
catch (Exception ex)
{
    jsonText = "EXCEPTION: " + ex.Message;
}

Console.WriteLine(jsonText);