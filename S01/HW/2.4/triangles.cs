using System;

namespace firstsample
{
public class Triangle
{
    public static void print_left_triangle(int n, char character) {
        for (int i = 1; i <= n; i++) {
            for (int j = 0; j < i; j++) {
                Console.Write(character);
            }
            Console.Write("\n");
        }
    }

    public static void print_right_triangle(int n , char character) {
        for (int i = n; i > 0; i--) {
            for (int j = 1; j < i; j++) {
                Console.Write(" ");
            }
            for (int h = 0; h <= n - i; h++) {
                Console.Write(character);
            }
            Console.Write("\n");
        }
    }

    static void Main() {
        print_left_triangle(20,'%'); //part2
        print_left_triangle(20,'*'); //part2
        print_right_triangle(5,'*'); //part3
        print_right_triangle(20,'*'); //part3
    }
}
}