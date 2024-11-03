//You need to create a Math game containing the 4 basic operations

//The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.

//Users should be presented with a menu to choose an operation

//You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.

//You don't need to record results on a database. Once the program is closed the results will be deleted.


using System.ComponentModel.Design;


bool cal = true;
string operation;
Random dice = new Random();
int num1;
int num2;
List<string> history = new List<string>();

do
{
    Console.WriteLine();
    Console.WriteLine("please pick an operation: add, sub, mul, div.. press any key for your game history");
    string question = Console.ReadLine();
     operation = question.ToLower();
    
    switch (operation)
    {
        case "add":
            {
                num1 = dice.Next(0, 1000);
                num2 = dice.Next(0, 1000);
                int sum = num1 + num2;
                Console.WriteLine($"What is the result of {num1} + {num2}");
                string res = Console.ReadLine();
                int result = int.Parse(res);
                if (result == sum) { Console.WriteLine("Correct!"); history.Add($"{num1}+{num2} = {result} (win)");  }
                else { Console.WriteLine("oops, wrong"); history.Add($"{num1}+{num2} = {result}(loss)"); }
                Console.WriteLine();
                continue;
            }
        case "sub":
            {
                num1 = dice.Next(0, 1000);
                num2 = dice.Next(0, 1000);
                int sub;
                if (num1 > num2)
                {
                    sub = num1 - num2;
                    Console.WriteLine($"What is the result of {num1} - {num2}");
                    string resu = Console.ReadLine();
                    int result2 = int.Parse(resu);
                    if (result2 == sub) { Console.WriteLine("Correct!"); history.Add($"{num1}-{num2} = {result2} (win)");  }
                    else { Console.WriteLine("oops, wrong"); history.Add($"{num1}-{num2} = {result2} (loss)"); }
                }
                else if (num2 > num1)
                {
                    sub= num2 - num1;
                    Console.WriteLine($"What is the result of {num2} - {num1}");
                    string resu = Console.ReadLine();
                    int result2 = int.Parse(resu);
                    if (result2 == sub) { Console.WriteLine("Correct!"); history.Add($"{num2}+{num1} = {result2} (win)");  }
                    else { Console.WriteLine("oops, wrong"); history.Add($"{num2}+{num1} = {result2} (loss)"); }
                }
                else
                {
                    sub = num1 - num2;
                    Console.WriteLine($"What is the result of {num1} - {num2}");
                    string resu = Console.ReadLine();
                    int result2 = int.Parse(resu);
                    if (result2 == sub) { Console.WriteLine("Correct!"); history.Add($"{num1}+{num2} = {result2} (win)"); }
                    else { Console.WriteLine("oops, wrong"); history.Add($"{num1}+{num2} = {result2} (loss)"); }
                }
                Console.WriteLine();
                continue;
            }
        case "mul":
            {
                num1 = dice.Next(0, 1000);
                num2 = dice.Next(0, 1000);
                int mult = num1 * num2;
                Console.WriteLine($"What is the result of {num1} * {num2}");
                string res = Console.ReadLine();
                int result = int.Parse(res);
                if (result == mult) { Console.WriteLine("Correct!"); history.Add($"{num1}*{num2} = {result} (win)"); }
                else { Console.WriteLine("oops, wrong"); history.Add($"{num1}*{num2} = {result} (loss)"); }
                Console.WriteLine();
                continue;
            }
        case "div":
            {
                num1 = dice.Next(1, 101);
                num2 = dice.Next(1, 101);
                do
                {
                    num1 = dice.Next(1, 101);
                    num2 = dice.Next(1, 101);
                    if (num1 % num2 == 0)
                    {
                        int div = num1 / num2;
                        Console.WriteLine($"What is the result of {num1} / {num2}");
                        string res = Console.ReadLine();
                        int result = int.Parse(res);
                        if (result == div) { Console.WriteLine("Correct!"); history.Add($"{num1}/{num2} = {result} (win)"); }
                        else { Console.WriteLine("oops, wrong"); history.Add($"{num1}/{num2} = {result} (loss)"); }
                    }
                } while (num1 % num2 != 0);
                continue;
    }

        default:
            Console.WriteLine("your history is loading..");
        foreach (string item in history)
            Console.WriteLine(item);
            
            continue;
    }
} while (cal);
    
