Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

switch (number){
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
    default:
        Console.WriteLine("Число не соответствует запрашиваемому");
        break;
}


/*
if(number == 1) Console.WriteLine("Понедельник");
else if(number == 2) Console.WriteLine("Вторник");
else if(number == 3) Console.WriteLine("Среда");
else if(number == 4) Console.WriteLine("Четверг");
else if(number == 5) Console.WriteLine("Пятница");
else if(number == 6) Console.WriteLine("Суббота");
else if(number == 7) Console.WriteLine("Воскресенье");

else Console.WriteLine("Число не соответствует запрашиваемому");
*/
