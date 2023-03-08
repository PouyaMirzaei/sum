using System;
public class Exercise28
{
    public static void Main()
    {
        int i, j;
        int[,] arr1 = new int[10, 10];
        int det = 0;
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.Write("element - [{0}],[{1}] : ", i, j);
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("The matrix is :\n");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
                Console.Write("{0}  ", arr1[i, j]);
            Console.Write("\n");
        }
        for (i = 0; i < 3; i++)
            det = det + (arr1[0, i] * (arr1[1, (i + 1) % 3] * arr1[2, (i + 2) % 3] - arr1[1, (i + 2) % 3] * arr1[2, (i + 1) % 3]));
        Console.Write(det);
    }
}
