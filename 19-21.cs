using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("¬ведите конечную цель: ");
        int w = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¬ведите кол-во камней в первой куче: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¬ведите ƒействие с сложением: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¬ведите ƒействие с умножением: ");
        int y = Convert.ToInt32(Console.ReadLine());
        
        int[][] a = new int[w * w][w * w]();
        int[][] b = new int[w * w][w * w]();
        int[][] c = new int[w * w][w * w]();
        
        for(int i = w - 1; i > m - 1; i--)
            for(int j = w - 1; i > m - 1; i--)
            {
                if (a[i + x][j] * a[i * y][j] * a[i][j * y] * a[i][j + x] == 0)
                    a[i][j] = 1;
                if (Math.Max(i, j) * y + Math.Min(i, j) >= w)
                {
                    a[i][j] = 1;
                    b[i][j] = 1;
                    c[i][j] = 1;
                }
                else if (a[i][j] == 0)
                {
                    b[i][j] = Math.Min(b[i + x][j], b[i * y][j], b[i][j + x], b[i][j * y]) + 1;
                    c[i][j] = Math.Max(c[i + x][j], c[i * y][j], c[i][j + x], c[i][j * y]) + 1;
                }
                else
                {
                    b[i][j] = Math.Min(b[i + x][j] + (a[i + x][j] == 0 ? 0 : 10), b[i * y][j] + (a[i * y][j] == 0 ? 0 : 10), b[i][j + x] + (a[i][j + x] == 0 ? 0 : 10), b[i][j * y] + (a[i][j * y] == 0 ? 0 : 10)) + 1;
                    c[i][j] = Math.Min(c[i + x][j] + (a[i + x][j] == 0 ? 0 : 10), c[i * y][j] + (a[i * y][j] == 0 ? 0 : 10), c[i][j + x] + (a[i][j + x] == 0 ? 0 : 10), c[i][j * y] + (a[i][j * y] == 0 ? 0 : 10)) + 1;
                }
            }
        
        Console.WriteLine("ќтветы на 19-й номер:");
        Console.WriteLine(Math.Ceiling((w - n) / (y ** 2)));
        Console.WriteLine("ќтветы на 20-й номер:");
        for(int i = 0; i < w; i++)
            if (a[m][i] == 1 && b[m][n] == 3 && c[m][n] == 3) Console.WriteLine(i);
        
        Console.WriteLine("ќтветы на 21-й номер:");
        for(int i = 0; i < w; i++)
            if (a[m][i] == 0 && b[m][n] == 2 && c[m][n] == 4) Console.WriteLine(i);
    }
}