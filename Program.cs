while (true)
{
    Console.Write("Choose task number to run (19, 21 or 23): ");
    string task = Console.ReadLine() ?? "0";
    if (task == "19")
    {
        if (PalindromCheck() == true) Console.WriteLine("Your number is palindrom");
        else Console.WriteLine("Your number isn't palindrom");
        break;
    }
    else if (task == "21")
    {
        Console.WriteLine("Distance between points A and B is " + LineLenght().ToString("#.##"));
        break;
    }
    else if (task == "23")
    {
        CubeConsoleOutput();
        break;
    }
    else Console.WriteLine("Incorrect task number");
}

 // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int UserFiveDigitNumber()
{
    int num;
    while (true)
    {
        try
        {
            Console.Write("Type a five-digit number: ");
            num = int.Parse(Console.ReadLine()!);

            if (num < 0) num *= -1;
            if (num > 9999 && num <= 99999) break;
            else Console.WriteLine("Incorrect number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect data entered");
        }
    }
    return num;
}

bool PalindromCheck()
 {
    int palindrom = UserFiveDigitNumber();

    if (palindrom / 10000 == palindrom % 10 && 
        palindrom / 1000 % 10 == palindrom % 100 / 10) return true;
    else return false;
 }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

(int x, int y, int z) Random3DCoord()
{
    int x = new Random().Next(-10, 11);
    int y = new Random().Next(-10, 11);
    int z = new Random().Next(-10, 11);
    return (x, y, z);
}

double LineLenght() 
{
    var aCoord = Random3DCoord();
    int ax = aCoord.x, 
        ay = aCoord.y, 
        az = aCoord.z;
    Console.WriteLine("Point A coordinates: {0}, {1}, {2}", ax, ay, az);
    
    var bCoord = Random3DCoord();
    int bx = bCoord.x, 
        by = bCoord.y, 
        bz = bCoord.z;
    Console.WriteLine("Point B coordinates: {0}, {1}, {2}", bx, by, bz);    

    double line = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2)+ Math.Pow(bz - az, 2));
    return line;
}

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int UserNumber()
{
    while (true)
    {
        try
        {
            Console.Write("Type a number: ");
            int number = int.Parse(Console.ReadLine()!);
            if (number > 0) return number;
            else Console.WriteLine("Incorrect number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect data entered");
        }
    }
}

void CubeConsoleOutput()
{
    int numberCube = UserNumber();
    for (int i = 1; i <= numberCube; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.Write("\b" + "\b");
    Console.Write(".");
}