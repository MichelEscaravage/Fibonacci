
int firstDigit = -1;
int secondDigit = 1;
int result;

for (int i = 0; i <= 20; i++)
{

    result = firstDigit + secondDigit;
    firstDigit = secondDigit;
    secondDigit = result;

    Console.WriteLine(result);
}
