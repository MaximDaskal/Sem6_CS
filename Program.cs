//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

bool IsPositive(int Vnum)
{
    if(Vnum>0) return true;
    else return false;
}


//Пользовательский интерфейс
int count = 0;
do
{
    int number;
    Console.WriteLine("Input your number: ");
    var str = Console.ReadLine();
    if(str == "q") break;
    else if (int.TryParse(str, out number))
    {
       if(IsPositive(number)) count++;     
    }
    else Console.WriteLine($"Warning! \"{str}\" is not a number!");
}
while(true);
Console.WriteLine($"Quantity of positive numbers is: {count}");



