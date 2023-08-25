//conversão implícita, existe para alguns tipos, desde que sejam compatíveis.

using System.Reflection.Metadata.Ecma335;

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

        //Operadores de atribuição
        int x = 0;
        Console.WriteLine("x: " + x);
        x += 5;
        Console.WriteLine("x += 5: " + x);
        x -= 1;
        Console.WriteLine("x -= 1: " + x);
        x *= 10;
        Console.WriteLine("x *= 10: " + x);
        x /= 2;
        Console.WriteLine("x /= 2: " + x);

        // Operadores de comparação
        int y = 5;
        int j = 9;
        Console.WriteLine("y: " + y);
        Console.WriteLine("j: " + j);
        Console.WriteLine("Equal: " + (y == j));
        Console.WriteLine("Different: " + (y != j));
        Console.WriteLine("Greater than: " + (y > j));
        Console.WriteLine("Less than: " + (y < j));
        Console.WriteLine("Greater than or equal to: " + (y >= j));
        Console.WriteLine("Less than or equal to: " + (y <= j));

        //operadores lógicos (&&, || e !)
        // Operador && (and)
        Console.WriteLine("Operador and");
        Console.WriteLine((false && false));
        Console.WriteLine((false && true));
        Console.WriteLine((true && false));
        Console.WriteLine((true && true));

        // Operador || (or)
        Console.WriteLine("Operador or");
        Console.WriteLine((false || false));
        Console.WriteLine((false || true));
        Console.WriteLine((true || false));
        Console.WriteLine((true || true));

        //Operador ! (not)
        Console.WriteLine("Operador not");
        Console.WriteLine(!(false || false));
        Console.WriteLine(!(false || true));
        Console.WriteLine(!(true || false));
        Console.WriteLine(!(true || true));

        // Estruturas Condicionais: if
        bool condition = true;
        if (condition == false)
        {
            Console.WriteLine("Condition was false");
        } else { 
            Console.WriteLine("Condition was true");
        }

        if (condition == false) Console.WriteLine("Was false");

        //Estruturas condicionais switch (para muitas decisões ou cascata)
        switch (condition)
        {
            case true: funcao(); break;//Console.WriteLine("Condition was true"); break;
            case false: Console.WriteLine("Condition was false"); break;
            default: Console.WriteLine("Non of both");
        }

        void funcao() {
            Console.WriteLine("Inside the function");
        }

        // Laços de repetição FOR
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Contando: " + i);
        }
    }
}