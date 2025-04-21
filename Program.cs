
using System.Text;

Console.WriteLine(ReturnEvenNumbers(0, 100));

string ReturnEvenNumbers(int number1, int number2)
{
    StringBuilder sb = new StringBuilder();
    int pointer = number1;
    if (number1 % 2 == 1) { pointer++; }
    while (pointer < number2)
    {
        sb.Append($"{pointer} ");
        pointer = pointer + 2;
    }

    return sb.ToString();
}
