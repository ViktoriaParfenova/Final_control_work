
System.Console.WriteLine("Введите элементы массива через пробел:");
string[] InputArray = Console.ReadLine().Split(' ');

int count = 0;
    foreach (string str in InputArray)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

string [] OutputArray = new string[count];
Console.WriteLine("Новый массив:");

int index = 0;
    foreach (string str in InputArray)
    {
        if (str.Length <= 3)
        {
            OutputArray[index] = str;
            System.Console.Write(OutputArray[index] + " ");
            index++;
        }
    }