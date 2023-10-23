//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numSecond = Convert.ToInt32(Console.ReadLine());
if (numFirst > numSecond) {
    Console.WriteLine("max = " + numFirst);
    Console.WriteLine("min = " + numSecond);
}
else {
    Console.WriteLine("max = " + numSecond);
    Console.WriteLine("min = " + numFirst);
}
