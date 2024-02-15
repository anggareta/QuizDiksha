Console.WriteLine("Soal no. 2:");
Console.WriteLine();

string deret = "aaabbcccaaaac";
Console.WriteLine($"input: {deret}");

Console.WriteLine("output:");
int mulai = 1;
for (int i = 0; i < deret.Length; i++)
{
  if (i + 1 < deret.Length)
  {
    if (deret[i] != deret[i + 1])
    {
      Console.WriteLine($"{deret[i].ToString()} = {mulai.ToString()}");
      mulai = 1;
    }
    else
    {
      mulai++;
    }
  }
  else
  {
    Console.WriteLine($"{deret[i].ToString()} = {mulai.ToString()}");
  }
}