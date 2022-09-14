//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.


{
 Console.WriteLine("Введите пятизначное число: ");
 string array = (Console.ReadLine());

 if (array[0] == array[4] && array[1] == array[3])
    {
 Console.WriteLine("Число является палиндромом!");
    }
 else
    {
 Console.WriteLine("Число не является палиндромом!");
    }
}
