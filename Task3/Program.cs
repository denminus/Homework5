// Написать программу масштабирования фигуры
//(0,0) (2,0) (2,2) (0,2)

    int[]array = new int[8];
    int[]arrayizm = new int[8];
    Console.Write("коэффициент масштабирования k: ");
    int k = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты вершин фигуры в формате (x1,y1) (x2,y2) (x3,y3) (x4,y4) : ");
    string stroka= Console.ReadLine();
    array[0]=int.Parse(Convert.ToString(stroka[1])!); 
    array[1]=int.Parse(Convert.ToString(stroka[3])!);
    array[2]=int.Parse(Convert.ToString(stroka[7])!);
    array[3]=int.Parse(Convert.ToString(stroka[9])!);
    array[4]=int.Parse(Convert.ToString(stroka[13])!);
    array[5]=int.Parse(Convert.ToString(stroka[15])!); 
    array[6]=int.Parse(Convert.ToString(stroka[19])!);
    array[7]=int.Parse(Convert.ToString(stroka[21])!);

    for (int i=0; i< array.Length; i++) 
    {
        arrayizm[i] = array[i]*k;
    }
Console.WriteLine ("Координаты после масштабирования: ");
Console.WriteLine($"({arrayizm[0]},{arrayizm[1]}) ({arrayizm[2]},{arrayizm[3]}) ({arrayizm[4]},{arrayizm[5]}) ({arrayizm[6]},{arrayizm[7]})");
