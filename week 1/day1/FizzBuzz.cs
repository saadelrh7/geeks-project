// exercice 1
console.WriteLine("Enter a number between 1 and 100: ");
int number = int.Parse(Console.ReadLine());
if (number % 3 == 0 && number % 5 == 0 )
{
    Console.WriteLine("FizzBuzz");
}
else if (number % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (number % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(number);
}

// exercice 2 
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i;j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// exercice 3 

Console.Write("Enter a word: ");
string word = Console.ReadLine();

string reversed = "";

for (int i = word.Length - 1; i >= 0; i--)
{
    reversed += word[i];
}
Console.WriteLine(reversed);