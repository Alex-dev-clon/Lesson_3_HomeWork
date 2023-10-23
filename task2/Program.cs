// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numThird = Convert.ToInt32(Console.ReadLine());
if (numFirst >= numSecond && numFirst >= numThird){
    Console.WriteLine("Максимальное число " + numFirst);
}
else if (numSecond >= numFirst && numSecond >= numThird){
    Console.WriteLine("Максимальное число " + numSecond);
}
else {
    Console.WriteLine("Максимальное число " + numThird);
}