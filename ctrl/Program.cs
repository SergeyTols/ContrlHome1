string[] array = FillArray();
string[] resultArray = NewArray(array);

string[] FillArray()
{
    Console.WriteLine("Enter any strings separated by commas and/or spaces: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null)
    { 
        enterSymbols = ""; 
    }
    char[] separators = new char[] { ',', ' ' };
    string[] array = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return array;
}

int CountSymbols(string[] array)
{
    int count = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArray(string[] array)
{
    int resultArrayLength = CountSymbols(array);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}

void WriteArray(string[] test)
{
    Console.Write("[");
    
        for(int i = 0; i < test.Length; i++)
        {
            if(i < test.Length -1)
            {
                Console.Write(test[i] + ", ");
            }   
            else
            {
                Console.Write(test[i]);
                        
            }

        }
    Console.Write("]");     
}

WriteArray(array);
Console.WriteLine();
WriteArray(resultArray);