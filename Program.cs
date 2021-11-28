using Microsoft.CodeAnalysis.CSharp.Scripting;

Console.WriteLine("Press a key");

Console.ReadKey();

var text = File.ReadAllText("sayhello.txt");

Console.WriteLine(text);

Console.WriteLine("Press a key");

while (true)
{
    Console.ReadKey();

    var scCode = File.ReadAllText("scriptCode1.txt.cs");

    var script = CSharpScript.Create(scCode);

    await script.RunAsync();
}







