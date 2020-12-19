package test2;

import java.util.Scanner;

public class TestClass2
{
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
		System.out.println("¬ведите цель: "); int w = sc.nextInt();
		System.out.println("¬ведите количество камней в первой куче: "); int i = sc.nextInt();
		System.out.println("¬ведите х: "); int x = sc.nextInt();
		System.out.println("¬ведите у: "); int y = sc.nextInt();
		
		String[][] m = new String[w][w];
		
		for(int i1 = 1; i1 < w; i1++)
		{
			for(int j1 = 1; j1 < w; j1++)
			{
				m[i1][j1] = -1;
				System.out.print(m[i1][j1]);
			}
			System.out.println();
		}
		
		System.out.println();
		System.out.println();
		System.out.print("  ");
		
		for(int i2 = w - 1; i2 > 0; i2--)
			System.out.print(i2 > 9 ? " " + i2 : "  " + i2);

		System.out.println();
		
		for(int i2 = w - 1; i2 > 0; i2--)
		{
			System.out.print(i2 > 9 ? i2 : i2 + " ");
			
			for(int j2 = w - 1; j2 > 0; j2--)
			{
				int i1 = Math.min(i2, j2);
				int j1 = Math.max(i2, j2);

				if (j1 * y + i1 >= w) // < ??????????????????????????????????????????
				{
					m[i1][j1] = 1;
				}
				else if (m[y * i1][j1].charAt(0) == 49 && m[i1][j1 * y].charAt(0) == 49 && m[i1 + x][j1].charAt(0) == 49 && m[i1][j1 + 2].charAt(0) == 49)
				{
					m[i1][j1] = 2;
				}
				else
				{
					m[i1][j1] = 1;
				}
				
				System.out.print(m[i1][j1] < 0 ? " " + m[i1][j1] : "  " + m[i1][j1]);
			}
			System.out.println();
		}
	}
}
