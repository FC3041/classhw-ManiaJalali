#include<iostream>
#include<math.h>
using namespace std;

class Circle
{
    public:
        double center_x, center_y ,radius;
        
        double center_distance(Circle c1)
        {
            return sqrt((center_x - c1.center_x) * (center_x - c1.center_x) + (center_y - c1.center_y) * (center_y - c1.center_y));
        }

        double point_distance(double px, double py)
        {
            return sqrt((center_x - px) * (center_x - px) + (center_y - py) * (center_y - py));
        }

        void TellIfPointIsinCircle(int px, int py)
        {
            double dis = point_distance(px, py);
            if (dis < radius)
                cout<<"the point is placed in the circle"<<endl;
            else if (dis == radius)
                cout<<"the point is placed on the circle"<<endl;
            else
                cout<<"the point is placed outside of the circle"<<endl;
        }

        double compute_area()
        {
            return radius * radius * M_PI;
        }

        double compute_circumference()
        {
            return radius * 2 * M_PI;
        }
};

int main()
{
    Circle c0;
    c0.center_x = 1;
    c0.center_y = 3;
    c0.radius = 4;

    Circle c1;
    c1.center_x = 8;
    c1.center_y = 5;
    c1.radius = 3;

    double CenterDis = c0.center_distance(c1);
    double PointDis = c0.point_distance(4, 7);
    c0.TellIfPointIsinCircle(3,2);
    double area = c0.compute_area();
    double cir = c0.compute_circumference();

    cout << CenterDis << endl << PointDis << endl << area << endl << cir;

    return 0;
}