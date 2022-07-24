// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// Console.WriteLine("введите основание степени ");
// int BasisDegree = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите неотрицательный показатель степени ");
// int DegreeIndicator = Convert.ToInt32(Console.ReadLine());
// if (DegreeIndicator < 0)
// {
//     Console.WriteLine("показатель стерпени отрицательный");
// }
// if (DegreeIndicator >= 0)
// {
//     int result = 1;
//     for (int i = 1; i <= DegreeIndicator; i++)
//     {
//         result = result * BasisDegree;

//     }

//     Console.WriteLine(result);
// }


// программа, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// while (number != 0)
// {
//    int temp = number % 10;
//    result = result + temp;
//    number = number / 10;

// }

//  Console.WriteLine(result);


//  программа задаёт массив из 8 элементов и выводит их на экран.

int [] RandomArraay = new int[8];
for (int i = 0; i < 8; i++)
{
   RandomArraay[i] = new Random().Next(1, 1001);
}


void ShowArraay (int[] array)
{
for (int i = 0; i < 8; i++)
{
   Console.Write(array[i] + ",");
}
Console.WriteLine();
}


ShowArraay(RandomArraay);
