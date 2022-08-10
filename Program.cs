
static bool TrySumIfOdd(int x, int y, out int result)
{
    result = x + y;

    bool isTrue = !(result % 2 == 0);
    return isTrue;

}

static void Repeat(string x, int n)
{
    string result = "";
    for (int i = 0; i < n; i++)
    {
        result += x;

        Console.WriteLine(result);
    }

}

Repeat("Paul", 4);

int sum;

Console.WriteLine(TrySumIfOdd(3, 5, out sum));
Console.WriteLine(sum);


Maximum a = new Maximum();

Console.WriteLine(a.MaxValue(3, 5, 10, 1100));

Minimum b = new Minimum();

Console.WriteLine(b.MinValue(3, 5, 10, 1100));



class Maximum
{
    public int MaxValue(int x, int y, int z)
    {
        int max1 = x > y ? x : y;

        return max1 > z ? max1 : z;  
        
        
        

    }

    public int MaxValue(int x, int y, int z, int i)
    {
        int max2 = x > y ? x : y;
        int max3 = z > i ? z : i;
        int overall = max2 > max3 ? max2 : max3;

        return overall;

    }

    


    

}


class Minimum
{
    public int MinValue(int x, int y, int z)
    {
        int min = x < y ? x : y;
        return min < z ? min : z;

    }

    public int MinValue(int x, int y, int z, int i)
    {
        int min1 = x < y ? x : y;
        int min2 = z < i ? z : i;
        int overall = min1 < min2 ? min1 : min2;

        return overall;
    }

}

//static int MaxValue( int x, int y)
//{
//    return Math.Max(x, y);

//}

//Console.WriteLine(MaxValue(3, 5));


//static int MinValue(int x, int y)
//{
//    return Math.Min(x, y);

//}

//checked

