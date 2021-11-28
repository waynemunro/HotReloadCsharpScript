// See https://aka.ms/new-console-template for more information


using Microsoft.CodeAnalysis.CSharp.Scripting;


Console.WriteLine("Press a key");

Console.ReadKey();

var code = File.ReadAllText("sayhello.txt");

Console.WriteLine(code);



Console.WriteLine("Press a key");

while (true)
{
    Console.ReadKey();

    var scriptCode1 = File.ReadAllText("scriptCode1.txt");

    var scriptCode = CSharpScript.Create(scriptCode1);

    scriptCode.Compile();

    ;

    await scriptCode.RunAsync();

}







