using System;

namespace firstsample
{
    public class MoreAskiArt
    {
        public static float eulers_constant(float precision) {
            float e = 1.0f;
            float factorial = 1.0f;
            int n = 1;
            
            while ((1.0f / factorial) >= precision) {
                factorial *= n;
                e += (1.0f / factorial);
                n++;
            }
            return e;
        }

        public static int power(int x, int y) {
            int p = 1;
            for (int i = 0; i < y; i++) {
                p *= x;
            }
            return p;
        }

        public static int factorial(int n) {
            int f = 1;
            for (int i = 1; i <= n; i++) {
                f *= i;
            }
            return f;
        }

        public static float exp_approx(int x, float precision) {
            float sum = 1.0f;
            float term = 1.0f;
            int n = 1;

            while (term >= precision) {
                term *= (float)x / n;
                sum += term;
                n++;
            }
            return sum;
        }

        public static int abs(int x) {
            return (x < 0) ? -x : x;
        }

        public static bool near(int x, int y, float closeness) {
            return abs(x - y) <= closeness * Math.Max(abs(x), abs(y));
        }

        public static double degrees_to_radians(int degrees) {
            return (degrees * 3.1415) / 180.0;
        }

        public static float sine(int x, float precision) {
            double radians = degrees_to_radians(x);
            float term = (float)radians;
            float sum = (float)radians;
            int n = 1;
            int sign = -1;

            while (Math.Abs(term) > precision) {
                term *= (float)(radians * radians / ((2 * n) * (2 * n + 1)));
                sum += sign * term;
                sign *= -1;
                n++;
            }
            return sum;
        }

        public static float square_root(int x, float precision) {
            if (x < 0) return 0.0f;

            float lower_bound = 0.0f;
            float upper_bound = Math.Max(1, x);
            float mid;

            while (upper_bound - lower_bound > precision) {
                mid = (lower_bound + upper_bound) / 2.0f;
                if (mid * mid < x) {
                    lower_bound = mid;
                } else {
                    upper_bound = mid;
                }
            }
            return (lower_bound + upper_bound) / 2.0f;
        }

        public static float ln(float x, float precision) {
            if (x <= 0) return 0.0f;

            float lower_bound = 0.0f;
            float upper_bound = x;
            float mid;

            while (upper_bound - lower_bound > precision) {
                mid = (lower_bound + upper_bound) / 2.0f;
                if (exp_approx((int)mid, precision) < x) {
                    lower_bound = mid;
                } else {
                    upper_bound = mid;
                }
            }
            return (lower_bound + upper_bound) / 2.0f;
        }

        public static void Main() {
            Console.WriteLine("Square root of 2: " + square_root(2, 0.000001f));
            Console.WriteLine("Sine of 45 degrees: " + sine(45, 0.000001f));
            Console.WriteLine("Sine of 90 degrees: " + sine(90, 0.000001f));
            Console.WriteLine("Sine of 0 degrees: " + sine(0, 0.000001f));
            Console.WriteLine("Natural logarithm of e: " + ln(2.71828f, 0.000001f));
            Console.WriteLine("Natural logarithm of 1: " + ln(1, 0.000001f));
        }
    }
}
