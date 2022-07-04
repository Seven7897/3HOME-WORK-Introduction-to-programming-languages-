
Console.WriteLine("Введите 5-ти значное число :");
string number = Console.ReadLine();
int index = 0 ;
int length = number.Length;
int and = number.Length - index - 1 ;
for (int i = 0; i < length / 2; i++)
{
    if (number[i] == number[and]) 
    i++;
    else
    Console.WriteLine("Ваше число не является полиндропом");
}
Console.WriteLine("Ваше число  является полиндропом");


/*
for (int i = 0; i < length; i++)
{
    
}
*/