class Program
{
  static List<int> CariGanjil(int[] arrayAwal)
  {
    List<int> hasil = new List<int>();

    for (int i = 0; i < arrayAwal.Length; i++)
    {
      if (arrayAwal[i] % 2 != 0)
      {
        if (arrayAwal[i] != 7)
          hasil.Add(arrayAwal[i]);
      }
    }
    hasil.Sort();
    hasil.Reverse();

    return hasil;
  }

  static void Main(string[] args)
  {
    Console.WriteLine("Soal no. 1:");
    Console.WriteLine();

    int[] input = { 2, 4, 6, 5, 3, 1, 7, 9, 10, 8 };
    List<int> output = CariGanjil(input);
    foreach (int elemen in output)
    {
      Console.Write(elemen + " ");
    }
    Console.WriteLine();
  }
}