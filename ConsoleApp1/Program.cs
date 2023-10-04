using System;
int[,] nums = new int[5, 5]
{
    {0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0}
};
int w = nums.GetLength(0);
int h = nums.GetLength(1);
int n = w * h;
{
    Console.WriteLine("Что двигаем на пустое(0)?");
    int b = Convert.ToInt32(Console.ReadLine());

    int line3 = -1, tab3 = -1;
    int line4 = -1, tab4 = -1;

    for (int i = 0; i < w; i++)
    {
        for (int j = 0; j < h; j++)
        {
            if (nums[i, j] == 0)
            {
                line3 = i;
                tab3 = j;
            }
            if (nums[i, j] == b)
            {
                line4 = i;
                tab4 = j;
            }
        }
    }
    if ((Math.Abs(line3 - line4) == 1 && tab3 == tab4) || (Math.Abs(tab3 - tab4) == 1 && line3 == line4))
    {
        int temp = nums[line3, tab3];
        nums[line3, tab3] = nums[line4, tab4];
        nums[line4, tab4] = temp;
    }
    else
    {
        Console.WriteLine("Так нельзя");
    }
    isCorrectOrder = CheckCorrectOrder(nums);
}
Console.WriteLine("Ура победа");
bool CheckCorrectOrder(int[,] array)
{
    int value = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != value % (w * h))
            {
                return false;
            }
            value++;
        }
    }
    return true;
}