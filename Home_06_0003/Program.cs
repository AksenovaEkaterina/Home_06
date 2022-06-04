void IntersectionPoint (double k1, double b1, double k2, double b2)
{

    double x = (b2-b1)/(k1-k2);
    double y = k1*x + b1;
    Console.WriteLine ($" {x}; {y}");
}
IntersectionPoint (5, 2, 9, 4);
