int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

Console.WriteLine("");

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

Console.WriteLine("");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
decimal decimalQuotient = 7.0m / 5;

Console.WriteLine("");

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

Console.WriteLine("");

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

Console.WriteLine();

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}" );
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}" );

Console.WriteLine();

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

Console.WriteLine();

int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

Console.WriteLine();

value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.

Console.WriteLine();

value  = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

Console.WriteLine("");

value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

Console.WriteLine("");

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m)*(5m /9m);
Console.WriteLine($"The temperature is {celsius} Celsius");