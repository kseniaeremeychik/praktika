using System;

class Array2
{
    private int[,] _arr;
    public Array2( int dim1, int dim2 )
    {
        _arr = new int[dim1,dim2];         
    }
    public Array2( Array2 other )
    {
        _arr = other._arr;
    }
    public int GetLength( int d )
    {
        return _arr.GetLength( d );        
    }
    public int GetValue( int i1, int i2 )
    {
        return _arr[i1, i2];
    }
    public void SetValue( int i1, int i2, int val )
    {
        _arr[i1, i2] = val;
    }
    public static bool operator< ( Array2 a1, Array2 a2 )
    {
        int min1 = Math.Min( a1.GetLength( 0 ), a1.GetLength( 1 ) );
        int sum1 = 0;
        for( int i1 = 0; i1 < min1; i1++ )
            sum1 += a1.GetValue( i1, i1 );

        int min2 = Math.Min( a2.GetLength( 0 ), a2.GetLength( 1 ) );
        int sum2 = 0;
        for( int i2 = 0; i2 < min2; i2++ )
            sum2 += a2.GetValue( i2, i2 );
        
        return sum1 < sum2;
    }
    public static bool operator> ( Array2 a1, Array2 a2 )
    {
        int min1 = Math.Min( a1.GetLength( 0 ), a1.GetLength( 1 ) );
        int sum1 = 0;
        for( int i1 = 0; i1 < min1; i1++ )
            sum1 += a1.GetValue( i1, i1 );

        int min2 = Math.Min( a2.GetLength( 0 ), a2.GetLength( 1 ) );
        int sum2 = 0;
        for( int i2 = 0; i2 < min2; i2++ )
            sum2 += a2.GetValue( i2, i2 );
        
        return sum1 > sum2;
    }
}

class Program
{
    public static void Main()
    {
        int
            len11 = 4,
            len12 = 4,
            len21 = 4,
            len22 = 4;
        
        Console.Write($"Создаём двумерный массив [{len11},{len12}]...") ;
        Array2 a21 = new Array2( len11, len12 );
        
        Console.Write($"\nСоздаём двумерный массив [{len21},{len22}]...");
        Array2 a22 = new Array2( len21, len22 );
        Console.WriteLine( "\n" );

        int min = -10, max = 10;
        Random r = new Random();

        Console.WriteLine($"Массив 1:");
        for( int i = 0; i < a21.GetLength(0); i++ )
        {
            for( int j = 0; j < a21.GetLength(1); j++ )
            {
                a21.SetValue( i, j, r.Next( min, max ) );
                Console.Write($"{a21.GetValue( i, j )} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Массив 2:");
        for( int i = 0; i < a22.GetLength(0); i++ )
        {
            for( int j = 0; j < a22.GetLength(1); j++ )
            {
                a22.SetValue( i, j, r.Next( min, max ) );
                Console.Write($"{a22.GetValue( i, j )}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int columnNumber = 2;

        Console.WriteLine( $"Добавляем к 1 стобцу 1 матрицы {columnNumber} столбец 2 матрицы:" );
        for( int i = 0; i < a21.GetLength(0); i++ )
        {
            for( int j = 0; j < a21.GetLength(1); j++ )
            {
                if (j == 0)
                {
                    a21.SetValue( i, j, a21.GetValue(i,j) + a22.GetValue(i,1) );
                } else {
                    a21.SetValue( i, j, a21.GetValue(i,j) );
                }
                Console.Write($"{a21.GetValue( i, j )} ");
            }
            Console.WriteLine();
        }
    }
}