using System;

namespace FunRunVolunteerSystem
{
    public class HungarianAlgorithm
    {
        public static int[] Run(int[,] cost)
        {
            int n = cost.GetLength(0);

            int[] u = new int[n + 1];
            int[] v = new int[n + 1];
            int[] p = new int[n + 1];
            int[] way = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                p[0] = i;
                int j0 = 0;

                int[] minv = new int[n + 1];
                bool[] used = new bool[n + 1];

                for (int j = 1; j <= n; j++)
                    minv[j] = int.MaxValue;

                do
                {
                    used[j0] = true;
                    int i0 = p[j0];
                    int delta = int.MaxValue;
                    int j1 = 0;

                    for (int j = 1; j <= n; j++)
                    {
                        if (!used[j])
                        {
                            int cur = cost[i0 - 1, j - 1] - u[i0] - v[j];

                            if (cur < minv[j])
                            {
                                minv[j] = cur;
                                way[j] = j0;
                            }

                            if (minv[j] < delta)
                            {
                                delta = minv[j];
                                j1 = j;
                            }
                        }
                    }

                    for (int j = 0; j <= n; j++)
                    {
                        if (used[j])
                        {
                            u[p[j]] += delta;
                            v[j] -= delta;
                        }
                        else
                        {
                            minv[j] -= delta;
                        }
                    }

                    j0 = j1;

                } while (p[j0] != 0);

                do
                {
                    int j1 = way[j0];
                    p[j0] = p[j1];
                    j0 = j1;
                } while (j0 != 0);
            }

            int[] result = new int[n];

            for (int j = 1; j <= n; j++)
            {
                if (p[j] - 1 < cost.GetLength(0))
                    result[p[j] - 1] = j - 1;
            }

            return result;
        }
    }
}