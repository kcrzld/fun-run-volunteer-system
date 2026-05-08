using System;
using System.Collections.Generic;

namespace FunRunVolunteerSystem
{
    public class HungarianAlgorithm
    {
        public static int[] Run(int[,] cost)
        {
            int n = cost.GetLength(0);

            int[,] matrix = (int[,])cost.Clone();

            // STEP 1: Row Reduction
            for (int i = 0; i < n; i++)
            {
                int min = matrix[i, 0];

                for (int j = 1; j < n; j++)
                    if (matrix[i, j] < min)
                        min = matrix[i, j];

                for (int j = 0; j < n; j++)
                    matrix[i, j] -= min;
            }

            // STEP 2: Column Reduction
            for (int j = 0; j < n; j++)
            {
                int min = matrix[0, j];

                for (int i = 1; i < n; i++)
                    if (matrix[i, j] < min)
                        min = matrix[i, j];

                for (int i = 0; i < n; i++)
                    matrix[i, j] -= min;
            }

            // STEP 3: Assignment
            int[] result = new int[n];
            bool[] assignedCols = new bool[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = -1;

                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0 && !assignedCols[j])
                    {
                        result[i] = j;
                        assignedCols[j] = true;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
