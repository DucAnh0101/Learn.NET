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
        string greeting = "Xin chào, " + name;
        int length = name.Length;
        char firstChar = name[0];
        string sub = name.Substring(0, 2);
        string upper = name.ToUpper();
        string lower = name.ToLower();
        bool contains = name.Contains("an");
        string replaced = name.Replace("A", "DucAnh");
        string trimmed = "   abc   ".Trim();
        string str = "Táo,Chuối,Cam";
        string[] fruits = str.Split(',');
        DateTime today = DateTime.Now;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Married: {isMarried}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Today: {today}");
        Console.WriteLine($"Greeting: {greeting}");
        Console.WriteLine($"Length of name: {length}");
        Console.WriteLine($"First character: {firstChar}");
        Console.WriteLine($"Substring: {sub}");
        Console.WriteLine($"Uppercase: {upper}");
        Console.WriteLine($"Lowercase: {lower}");
        Console.WriteLine($"Contains 'an': {contains}");
        Console.WriteLine($"Replaced 'A' with 'DucAnh': {replaced}");
        Console.WriteLine($"Trimmed string: '{trimmed}'");
        Console.WriteLine($"Split string into array: {str}");
        Console.WriteLine("Fruits: " + string.Join(", ", fruits));
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
            Console.WriteLine($"TryParse thành công: {num3}")
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

        int[] numbers = new int[5];
        int[] scores = { 10, 20, 30, 40, 50 };
        string[] names = new string[] { "Hùng", "An", "Bình" };
        numbers[0] = 5;
        int x = numbers[0];
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"scores[{i}] = {scores[i]}");
        }
        int[] arr = { 5, 2, 9, 1, 7 };

        Array.Sort(arr);
        Console.WriteLine("Mảng sau khi sắp xếp:");
        foreach (var item in arr)
        {
            Console.Write(item + ", ");
        }

        Console.WriteLine();
        Array.Reverse(arr);
        Console.WriteLine($"Mảng sau khi sắp xếp:");
        foreach (var item in arr)
        {
            Console.Write(item + ", ");
        }

        int index = Array.IndexOf(arr, 9);
        Console.WriteLine($"\nChỉ số của phần tử 9 trong mảng: {index}");

        Console.ReadLine();
    }
}
