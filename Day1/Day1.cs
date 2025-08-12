class Program
{
    static void Main(string[] args)
    {
        int age = 25;
        double height = 1.75;
        decimal salary = 1500.50m;
        bool isMarried = false;
        char grade = 'A';
        string name = "Nguyen Van A";
        DateTime today = DateTime.Now;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Married: {isMarried}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Today: {today}");
        Console.WriteLine();

        int a = 10;
        double b = (double)a;
        Console.WriteLine($"int -> double: {b}");

        double c = a;
        Console.WriteLine($"Implicit cast int -> double: {c}");

        string strNum = "123";
        int num1 = Convert.ToInt32(strNum);
        Console.WriteLine($"Convert string '123' -> int: {num1}");

        int num2 = int.Parse("456");
        Console.WriteLine($"Parse string '456' -> int: {num2}");

        if (int.TryParse("789", out int num3))
            Console.WriteLine($"TryParse thành công: {num3}");
        else
            Console.WriteLine("TryParse thất bại");
        Console.WriteLine();

        bool isAdult = age >= 18;
        bool hasTicket = true;

        if (isAdult && hasTicket)
            Console.WriteLine("Có thể vào rạp (AND)");
        else
            Console.WriteLine("Không đủ điều kiện (AND)");

        if (isAdult || hasTicket)
            Console.WriteLine("Có thể vào rạp (OR)");
        else
            Console.WriteLine("Không đủ điều kiện (OR)");

        if (!isMarried)
            Console.WriteLine("Chưa kết hôn (NOT)");

        Console.ReadLine();
    }
}
