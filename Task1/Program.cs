void PrintarrayString(string[] mass)
{
    for (int i = 0; i < mass.Length - 1; i++)
    {
        Console.Write(mass[i] + ", ");
    }
    Console.WriteLine(mass[mass.Length - 1] + ".");
}

void PrintarrayInt(int[] mass)
{
    for (int i = 0; i < mass.Length - 1; i++)
    {
        Console.Write(mass[i] + ", ");
    }
    Console.WriteLine(mass[mass.Length - 1] + ".");
}

int Positive(int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] >= 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.Write("Введите числа, разделенные между собой запятой, точкой или пробелом: ");
string a = Console.ReadLine()!;

char [] separators=new char[] {' ','.',','};

string[] arrayString = a.Split(separators, StringSplitOptions.RemoveEmptyEntries);
PrintarrayString(arrayString);//Проверка записи строкового массива

int[] arrayInt = new int[arrayString.Length];

for (int i = 0; i < arrayString.Length; i++)
{
    arrayInt[i] = int.Parse(arrayString[i]);
}
PrintarrayInt(arrayInt);//Проверка записи числового массива

Console.WriteLine($"В веденных числах положительных чисел {Positive(arrayInt)}");