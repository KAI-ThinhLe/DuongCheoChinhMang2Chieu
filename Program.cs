using System;

class Program
{
    static void Main()
    {
        int size;

        // Yêu cầu người dùng nhập kích thước của ma trận và kiểm tra đầu vào
        while (true)
        {
            Console.WriteLine("Enter the size of the square matrix:");
            if (Int32.TryParse(Console.ReadLine(), out size) && size > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        double[,] matrix = new double[size, size];

        // Nhập giá trị cho ma trận từ người dùng và kiểm tra đầu vào
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                while (true)
                {
                    Console.WriteLine($"Enter value for element at position ({i}, {j}):");
                    if (Double.TryParse(Console.ReadLine(), out double value))
                    {
                        matrix[i, j] = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }
        }

        // Tính tổng các số ở đường chéo chính của ma trận
        double diagonalSum = 0;
        for (int i = 0; i < size; i++)
        {
            diagonalSum += matrix[i, i];
        }

        // Hiển thị kết quả
        Console.WriteLine("Sum of the diagonal elements: " + diagonalSum);
    }
}
