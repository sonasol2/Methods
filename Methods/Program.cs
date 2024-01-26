namespace Methods;
class Program
{
    static void Main(string[] args)
    {
        void SayHello()
        {
            Console.WriteLine("Hello");
	    }

        void PrintMsg(string message)
        {
            Console.WriteLine(message);
	    }

        PrintMsg("Hello");
        PrintMsg("Yo");

        void Summ(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result); 
	    }

        Summ(13, 4);


        void PrintPerson(string name, int age = 0, string company = "undefined")
        {
            Console.WriteLine($"Имя: {name}, возраст: {age},компания: {company}.");
	    }

        PrintPerson("Bob", 24);
        PrintPerson("Fred", 32, "Amazon");


    }
}

