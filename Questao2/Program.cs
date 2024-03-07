int num = 21;
int a = 0, b = 1;
bool pertence = false;

Console.WriteLine("Sequência de Fibonacci:");

while (a <= num)
{
    Console.Write(a + " ");

    if (a == num)
        pertence = true;

    int temp = a;
    a = b;
    b = temp + b;
}

if (pertence)
    Console.WriteLine("\nO número " + num + " pertence à sequência de Fibonacci.");
else
    Console.WriteLine("\nO número " + num + " NÃO pertence à sequência de Fibonacci.");