int[] array = {1, 22, 3, 4, 53, 6, 7, 100, 100};

int n = array.Length;
int find = 100;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
