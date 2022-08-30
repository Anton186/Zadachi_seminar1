// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if((number>7) || (number<=0))
{
    Console.WriteLine("Это не день недели");
}
else
{

switch(number)
{
  case 1:
    Console.WriteLine("Понедельник");
    break;
  case 2:
    Console.WriteLine("Вторник");
    break;
  case 3:
    Console.WriteLine("Среда");
    break;
  case 4:
    Console.WriteLine("Четверг");
    break;
  case 5:
    Console.WriteLine("Пятница");
    break;
  case 6:
    Console.WriteLine("Суббота");
    break;
  case 7:
    Console.WriteLine("Воскресенье");
    break;
}
}