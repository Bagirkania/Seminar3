int number = 14212;
int current_number = number;
int result = 0;
while(current_number > 0)
{
    int digit = current_number % 10;
    result = result * 10 + digit;
    current_number /= 10;
    Console.WriteLine(result);
}
if(number == result)
{
    Console.WriteLine($"число {number} палиндром");
}
else
{
    Console.WriteLine($"число {number} не палиндром");
}