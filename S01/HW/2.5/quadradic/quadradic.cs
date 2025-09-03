using System;

public class Q
{
    public static void quadradic(int A,int B,int C){
        int delta = B*B - 4*A*C;
        if (delta < 0) { Console.WriteLine("The equation has complex roots."); }
        else {
            double x1 = (-(B) - Math.Sqrt(delta))/ (2*A);
            double x2 = (-(B) + Math.Sqrt(delta))/ (2*A);
            Console.Write("x1 = " + x1 + "\n");
            Console.Write("x2 = " + x2 );
        }
    }

    static void Main(){
        quadradic(-4,-3,8);
    }
}