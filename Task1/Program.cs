// Найти точку пересечения двух прямых заданных 
//уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double [] Function(double b1,double k1, double b2,double k2)
{
    
    double x= (b2-b1)/(k1-k2);
    double y=  k1 * x + b1;
    double[]array = new double [2];
    array[0] = x;
    array[1] = y;
    return array;
}
void PrintArrayDouble(double[] array)                     
{
    Console.Write(String.Join(':', array));
    Console.WriteLine();
}

double k1 =ReadInt("Введите k1: ");
double b1 =ReadInt("Введите b1: ");
double k2= ReadInt("Введите k2: ");
double b2 =ReadInt("Введите b2: ");

double [] Fun=Function( b1, k1, b2, k2);

Console.Write("Координаты пересечения прямых x:y : ");
PrintArrayDouble(Fun);


