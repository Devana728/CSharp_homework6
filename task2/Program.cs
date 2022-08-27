// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    string readValue = Console.ReadLine(); //считывает с консоли строку
    int result = int.Parse(readValue); // преобразует строку в целое число
    return result; //возвращает результат
}



(double, double) CrosslineCheck(double b1, double k1, double b2, double k2)
{
         // y = k2*x +b2
        //y-y = (k1-k2)x -(b1-b2);
    double x = (b2-b1)/(k1-k2);
    double y = k1*x +b1;
    var result =(x,y); 
    return result;
    
    
}

double k1 =  Prompt("Значение к1 : ");
double b1 =  Prompt("Значение b1 : "); 
double k2 =  Prompt("Значение к2 : ");
double b2 =  Prompt("Значение b2 : ");
CrosslineCheck( k1, b1, k2, b2);
if ( b2 == b1 && k2 == k1)
{
    System.Console.WriteLine("прямые совпадают");
}
else
   if(k2==k1)
   {
       System.Console.WriteLine("прямые параллельны");
   }
   else
   {
       (var x, var y)= CrosslineCheck( b1, k1, b2, k2);
       System.Console.WriteLine($"прямые пересекаются в точке ({x:f2};{y:f2})");
   }


