int select = 11;
string num2 = "";
string num1 = "";
char op = '0';
bool first = true;
while (true)
{
    Console.Clear();
    Console.WriteLine("\n\n");
    switch (select)
    {
        case 11:
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 1 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 2  3  +  ");
            Console.WriteLine(" 4  5  6  -");
            Console.WriteLine(" 7  8  9  * ");
            Console.WriteLine(" C  0  =  / ");
            break;
        case 12:
            Console.Write(" 1 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 2 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 3  +  ");
            Console.WriteLine(" 4  5  6  -");
            Console.WriteLine(" 7  8  9  * ");
            Console.WriteLine(" C  0  =  / ");
            break;
        case 13:
            Console.Write(" 1  2 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 3 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" +  ");
            Console.WriteLine(" 4  5  6  -");
            Console.WriteLine(" 7  8  9  * ");
            Console.WriteLine(" C  0  =  / ");
            break;

        case 14:
            Console.Write(" 1  2  3 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" + ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 4  5  6  -");
            Console.WriteLine(" 7  8  9  * ");
            Console.WriteLine(" C  0  =  / ");
            break;

        case 21:
            Console.WriteLine(" 1  2  3  +");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 4 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 5  6  -");
            Console.WriteLine(" 7  8  9  * ");
            Console.WriteLine(" C  0  =  / ");
            break;

        case 22:
            Console.WriteLine(" 1  2  3  +");
            Console.Write(" 4 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 5 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 6  -");
            Console.WriteLine(" 7  8  9  * ");
            Console.WriteLine(" C  0  =  / ");
            break;

        case 23:
            Console.WriteLine(" 1  2  3  +");
            Console.Write(" 4  5 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 6 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" -");
            Console.WriteLine(" 7  8  9  * ");
            Console.WriteLine(" C  0  =  / ");
            break;

        case 24:
            Console.WriteLine(" 1  2  3  +");
            Console.Write(" 4  5  6 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" - ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 7  8  9  * ");
            Console.WriteLine(" C  0  =  / ");
            break;

        case 31:
            Console.WriteLine(" 1  2  3  +");
            Console.WriteLine(" 4  5  6  -");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 7 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 8  9  * ");
            Console.WriteLine(" C  0  =  / ");
            break;

        case 32:
            Console.WriteLine(" 1  2  3  +");
            Console.WriteLine(" 4  5  6  -");
            Console.Write(" 7 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 9  * ");
            Console.WriteLine(" C  0  =  / ");
            break;

        case 33:
            Console.WriteLine(" 1  2  3  +");
            Console.WriteLine(" 4  5  6  -");
            Console.Write(" 7  8 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 9 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" * ");
            Console.WriteLine(" C  0  =  / ");
            break;

        case 34:
            Console.WriteLine(" 1  2  3  +");
            Console.WriteLine(" 4  5  6  -");
            Console.Write(" 7  8  9 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" * ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" C  0  =  / ");
            break;

        case 41:
            Console.WriteLine(" 1  2  3  +");
            Console.WriteLine(" 4  5  6  -");
            Console.WriteLine(" 7  8  9  * ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" C ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 0  =  / ");
            break;

        case 42:
            Console.WriteLine(" 1  2  3  +");
            Console.WriteLine(" 4  5  6  -");
            Console.WriteLine(" 7  8  9  * ");
            Console.Write(" C ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 0 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" =  / ");
            break;

        case 43:
            Console.WriteLine(" 1  2  3  +");
            Console.WriteLine(" 4  5  6  -");
            Console.WriteLine(" 7  8  9  * ");
            Console.Write(" C  0 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" = ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" / ");
            break;

        case 44:
            Console.WriteLine(" 1  2  3  +");
            Console.WriteLine(" 4  5  6  -");
            Console.WriteLine(" 7  8  9  * ");
            Console.Write(" C  0  = ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" /");
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }
    Console.WriteLine("\n");
    Console.Write(num1 + " ");
    if (op != '0')
        Console.Write(op + " " + num2);


    var _key = Console.ReadKey(true);

    if (_key.Key == ConsoleKey.UpArrow && select > 20)
        select -= 10;

    else if (_key.Key == ConsoleKey.DownArrow && select < 40)
        select += 10;

    else if (_key.Key == ConsoleKey.RightArrow && select < 44)
        if (select % 10 != 4)
            select++;
        else
            select += 7;
    else if (_key.Key == ConsoleKey.LeftArrow && select > 11)
        if (select % 10 != 1)
            select--;
        else
            select -= 7;
    else if (_key.Key == ConsoleKey.Enter)
    {
        if (select == 41)
        {
            first = true;
            num1 = "";
            op = '0';
            num2 = "";
        }
        else if (select == 43)
        {
            if (num1 == "" || num2 == "" || op == '0')
            {
                Console.WriteLine("\nYou should enter numbers and operator first!\n");
                Thread.Sleep(1452);
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{num1} {op} {num2}");
                double d1 = double.Parse(num1);
                double d2 = double.Parse(num2);
                switch (op)
                {
                    case '+':
                        Console.WriteLine($" = {d1 + d2}");
                        break;

                    case '-':
                        Console.WriteLine($" = {d1 - d2}");
                        break;

                    case '*':
                        Console.WriteLine($" = {d1 * d2}");
                        break;

                    case '/':
                        if (num2 != "0")
                            Console.WriteLine($" = {d1 / d2}");
                        else
                            Console.WriteLine(" = ∞");
                        break;
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nPress Esc to Exit or any other button to continue...");
                var a = Console.ReadKey(true);
                if (a.Key == ConsoleKey.Escape)
                    break;
                first = true;
                num1 = "";
                op = '0';
                num2 = "";
            }
        }
        else if (select % 10 == 4)
        {
            if (select == 14)
                op = '+';
            else if (select == 24)
                op = '-';
            else if (select == 34)
                op = '*';
            else if (select == 44)
                op = '/';
            first = false;
        }
        else if (first)
        {
            if (select == 11)
                num1 = num1 + "1";

            else if (select == 12)
                num1 = num1 + "2";

            else if (select == 13)
                num1 = num1 + "3";

            else if (select == 21)
                num1 = num1 + "4";

            else if (select == 22)
                num1 = num1 + "5";

            else if (select == 23)
                num1 = num1 + "6";

            else if (select == 31)
                num1 = num1 + "7";

            else if (select == 32)
                num1 = num1 + "8";

            else if (select == 33)
                num1 = num1 + "9";

            else if (select == 42)
                num1 = num1 + "0";

        }
        else if (first == false)
        {
            if (select == 11)
                num2 = num2 + "1";

            else if (select == 12)
                num2 = num2 + "2";

            else if (select == 13)
                num2 = num2 + "3";

            else if (select == 21)
                num2 = num2 + "4";

            else if (select == 22)
                num2 = num2 + "5";

            else if (select == 23)
                num2 = num2 + "6";

            else if (select == 31)
                num2 = num2 + "7";

            else if (select == 32)
                num2 = num2 + "8";

            else if (select == 33)
                num2 = num2 + "9";

            else if (select == 42)
                num2 = num2 + "0";
        }
        else if (_key.Key == ConsoleKey.Escape)
            break;

    }

}