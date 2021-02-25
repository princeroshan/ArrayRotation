using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static int[] RotateArray(int[] A, int k, int n)
        {
            int rot_count = 1;
            while (rot_count <= k)
            {
                int temp = A[n - 1];
                for (int i = n - 1; i != 0; i--)
                {
                    A[i] = A[i - 1];
                }
                A[0] = temp;
                rot_count++;
            }
            return A;
        }
        static void Main(string[] args)
        {
            int N;
            int K;
            int flag = 1;
            int T = Convert.ToInt32(Console.ReadLine());
            while (flag <= T)
            {
                string str1 = Console.ReadLine();
                string[] strarr1 = new string[2];
                strarr1 = str1.Split(' ', (char)2);
                N = Convert.ToInt32(strarr1[0]);
                K = Convert.ToInt32(strarr1[1]);
                string str2 = Console.ReadLine();
                string[] strarr2 = new string[N];
                strarr2 = str2.Split(' ');
                int[] A = new int[N];
                for (int i = 0; i < N; i++)
                {
                    A[i] = Convert.ToInt32(strarr2[i]);
                }
                int[] resarr = RotateArray(A, K, N);
                Console.WriteLine(string.Join(" ", resarr));
                Console.WriteLine();
                flag++;
            }

        }
    }
}
