// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text;

Console.WriteLine("Hello, World!");
string? input = Console.ReadLine().ToUpper();
string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string bestAnswer = "";
int likelyKey = 42;
int NumberOfE = 0;
for (int i = 0; i < alpha.Length; i++)
{
    var builder = new StringBuilder();
    for (int j = 0; j < input.Length; j++)
    {
        if (alpha.Contains(input[j]))
        {
            int Numpos = alpha.LastIndexOf(input[j]);
            int Outputpos = Numpos + i;
            if (Outputpos < alpha.Length)
            {
                builder.Append(alpha[Outputpos]);
            }
            else
            {
                builder.Append(alpha[Outputpos - alpha.Length]);
            }
        }
        else
        {
            builder.Append(input[j]);
        }
    }
    int count = builder.ToString().Count(f => f == 'E');
    if (count > NumberOfE)
    {
        bestAnswer = builder.ToString();
        likelyKey = i;
        NumberOfE = count;
    }
}
Console.WriteLine("answer is " + bestAnswer + "sleutel is " + likelyKey);
Console.ReadLine();