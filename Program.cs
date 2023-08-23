//conversão implícita, existe para alguns tipos, desde que sejam compatíveis.

internal class Program
{
    private static void Main(string[] args)
    {
        float numberFloat = 5.3F;
        Console.WriteLine("Número Float: " + numberFloat);
        int numberInt = 28;
        Console.WriteLine("Número int: " + numberInt);
        numberFloat = numberInt;
        Console.WriteLine("Número Float com o int dentro: " + numberFloat);

        //conversão explícita

        int numberIntForUint = 50;
        Console.WriteLine("Número int para uint: " + numberIntForUint);
        uint numberUint = (uint)numberIntForUint;

        //Conversão com Parse
        string numberAsString = "100";
        numberAsString = numberAsString + 100;
        Console.WriteLine("Número como string: " + numberAsString);


        int numberParse = int.Parse("100");
        numberParse = numberParse + 100;
        numberInt = int.Parse(numberFloat.ToString());
        Console.WriteLine("Número utilizando parse: " + numberParse);
        Console.WriteLine("Número utilizando o tostring " + numberInt);

        int numberConvert = Convert.ToInt32("100");
        Console.WriteLine("Número utilizando o convert: " + numberConvert);
    }
}