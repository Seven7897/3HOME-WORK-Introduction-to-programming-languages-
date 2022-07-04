
Console.WriteLine("Введите 5-ти значное число :");
string number = Console.ReadLine();
int index = 0 ;
int length = number.Length;
for (int i = 0; i < length / 2; i++)
{   int and = number.Length - index - 1 ;
    if (number[index] == number[and]) 
    {
    
    }
    else
    {
    Console.WriteLine("Ваше число не является полиндромом");
    return;
    }
    index++;
}
Console.WriteLine("Ваше число  является полиндромом");
