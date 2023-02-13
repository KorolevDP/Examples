// Определение максимального из 9 чисел.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int num1 = 1111125;
int num2 = 21;
int num3 = 39;
int num4 = 12;
int num5 = 2311;
int num6 = 33;
int num7 = 13;
int num8 = 23111;
int num9 = 313;

// int max1 = Max(num1, num2, num3);
// int max2 = Max(num4, num5, num6);
// int max3 = Max(num7, num8, num9);
// int max = Max(max1, max2, max3);

int max = Max(
          Max(num1, num2, num3), 
          Max(num4, num5, num6), 
          Max(num7, num8, num9));

Console.WriteLine(max);