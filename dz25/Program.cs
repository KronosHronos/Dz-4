Console.Clear();
int numA = GetNumFromUser("Введите целое число A: ","Ошибка ввода!");
int numB = GetNumFromUser("Введите целое число B: ","Ошибка ввода!");
int result = AvB(numA, numB);
Console.WriteLine($"{numA}^{numB} -> {result}");

int GetNumFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

int AvB(int number1, int number2)
{
    int sum= 1;
    
    for (int i = 0; i < number2; i ++) sum *= number1;

    return sum;
}
    