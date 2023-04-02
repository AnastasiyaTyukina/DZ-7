// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 16);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int[] ReadPosition()
{
    Console.Write("What element do you want: ");
    int[] Position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    return Position;
}

void FindElement(int[,] matrix, int[] Position)
{
    
       if(Position[0] < matrix.GetLength(0) && Position[1] < matrix.GetLength(1))
    {
        Console.Write($"{matrix[Position[0],Position[1]]}");
    }
    else
        Console.Write("Элемента нет!");
    
}

Console.Write("Enter the size of your matrix: ");
int[] Size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] Matrix = new int[Size[0], Size[1]];
InputMatrix(Matrix);
int[] Indexes = ReadPosition();
FindElement(Matrix, Indexes);