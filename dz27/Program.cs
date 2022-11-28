/// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 

Console.Clear();

int number = UserInput("Введите число: ", "Ошибка ввода!");
Console.WriteLine($"{number} -> {count(number)}");

int UserInput(string message, string errorMessage)
{    
     while(true)
    {
        Console.Write(message);
        if( int.TryParse(Console.ReadLine(), out int userNumber))

            return userNumber;
        Console.WriteLine(errorMessage);
     } 
}

int count(int number)
{
    int result = 0;
    if(number<0)
    {
    number=number*(-1);
    while(number > 0)
    {
     result+=number%10;
     number /=10;
    }
  return result*(-1);
    }
   else if(number>0)
    while(number > 0)
     {
      result+=number%10;
      number /=10;
     }
      return result;
}