string[] FinishArray (string[] arrayString)
{
    int index = 0;
    int length = 0;
    for (int i = 0; i < arrayString.Length; i++)
        {
            if(arrayString[i].Length<=3)
                length++;
        }
    string[] finishArrayString = new string[length];
    for (int i = 0; i < arrayString.Length; i++)
        {
            if(arrayString[i].Length<=3)
            {
                finishArrayString[index]=arrayString[i];
                index++;
            }
        }
    return finishArrayString;
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
string[] arrayString = {"Гоша", "Лена","Нож","Кот","Сом","Виктор","Хом"};
string[] finishArray = FinishArray(arrayString);
PrintArray(finishArray);



