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
        }
        else
        {
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

        void funcao()
        {
            Console.WriteLine("Inside the function");
        }

        // Laços de repetição FOR
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Counting: " + i);
        }

        //Laços de repetição: While (Testa a condição ANTES de executar)
        int contadorWhile = 1;
        while (contadorWhile <= 1)
        {
            Console.WriteLine("While: " + contadorWhile);
            contadorWhile++;
        }
        Console.WriteLine("Depois do laço While: " + contadorWhile);

        //Laços de repetição: DO (Testa a condição DEPOIS)
        int contadorDo = 1;
        do
        {
            Console.WriteLine("Do: " + contadorDo);
            contadorDo++;
        } while (contadorDo <= 1);
        Console.WriteLine("Depois do laço DO: " + contadorDo);

        //Chamada do método
        string reciveName = ReturnName("Luis", "Janes");
        Console.WriteLine(reciveName);
        MeuMetodo("C# é legal");


        //Value Types, armazenam uma copia do valor
        int r = 5;
        int p = r;
        Console.WriteLine(r);
        Console.WriteLine(p);
        r = 35;
        Console.WriteLine(r);
        Console.WriteLine(p);

        //Reference types, armazena a referencia na memória.
        var arr = new string[2];
        arr[0] = "Item 1";
        var arr2 = arr;

        Console.WriteLine(arr[0]);
        Console.WriteLine(arr2[0]);

        arr[0] = "Item alterado";
        Console.WriteLine(arr[0]);
        Console.WriteLine(arr2[0]);



        Product product = new Product(1, 50.0f);
        float priceDolar = product.PriceDolar(4.87f);
        Console.WriteLine(priceDolar);

    }

    //Structs
    struct Product
    {
        //Pode usar um método contrutor
        public Product(int id, float price)
        {
            Id = id;
            Price = price;
        }

        public int Id;
        public float Price;

        public float PriceDolar(float dolar)
        {
            return dolar * Price;
        }

    }


    //definição do método que não retorna nada(void)
    static void MeuMetodo(string parametro)
    {
        Console.WriteLine(parametro);
    }

    //método que retorna uma string
    static string ReturnName(string name, string lastName, int idade = 28)
    {
        return name + " " + lastName;
    }




}