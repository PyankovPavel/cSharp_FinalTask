string[] resultArray(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i].Length < 4)
        {
            size++; // длина нового массива с элементами <=3 символов
        }
    }
    string[] newArray = new string[size]; 
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            newArray[index] = arr[i];
            index++;
        }
    }
    return newArray;
}

string[] array = { "Cat", "Dog", "Mother", "Father", "Sister", "Brother", "Son" };
string[] array1 = { "223", "0_o", ":))", ":-В", "Sister", "Brother", "Son" };

Console.WriteLine(String.Join(", ", resultArray(array)));
Console.WriteLine(String.Join(", ", resultArray(array1)));
