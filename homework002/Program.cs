Console.WriteLine("Введите 5-ти значное число :");
string number = Console.ReadLine();
int index = 0 ;
int length = number.Length;
int and = length - 1 - index ;
while (index < length / 2)
{
    if (number[index] == number[and]) 
    {
        Console.WriteLine("+");        
    }
    else
    {
        Console.WriteLine("нет");
        break;
    }
    index++;
}