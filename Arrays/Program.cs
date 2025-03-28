using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Working with 2D Array: Student Grades Matrix");

        int[,] grades = { { 60, 65, 70 },{ 75, 80, 85 },{ 90, 85, 100 },{ 95, 95, 95 },{ 100, 100, 100 } };

        Console.WriteLine("Grades: ");
        for (int i = 0; i < 5; i++){
            for (int j = 0; j < 3; j++){
                Console.Write(grades[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nAverage Grades:");
        for (int i = 0; i < 5; i++){
            int sum = 0;
            for (int j = 0; j < 3; j++){
                sum += grades[i, j];
            }
            double average = (double)sum / 3;
            Console.WriteLine($"Student {i + 1}: {average:F2}");
        }
        Console.WriteLine("\nHighest Grades Among First 3 Students (Per Subject):");
        for (int j = 0; j < 3; j++) {
            int highestGrade = grades[0, j];
            for (int i = 1; i < 3; i++) {
                if (grades[i, j] > highestGrade){
                    highestGrade = grades[i, j];
                }
            }
            Console.WriteLine($"Subject {j + 1}: {highestGrade}");
        }
    }
}

          