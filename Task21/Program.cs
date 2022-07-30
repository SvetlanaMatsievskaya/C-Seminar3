double x1=0;
double y1=0;
double z1=0;
double x2=0;
double y2=0;
double z2=0;

double distance = 0;
Console.Write("x1=");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1=");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1=");
z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2=");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2=");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2=");
z2 = Convert.ToDouble(Console.ReadLine()); 

double PowToTwo (double number){
    double result = 0;
    result = number*number;
    return result;

}
   
distance = Math.Round(Math.Sqrt((PowToTwo(x2-x1))+(PowToTwo(y2-y1))+(PowToTwo(z2-z1))),2);
Console.WriteLine($" distance:  {distance}");
