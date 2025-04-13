#include<iostream>
#include<math.h>

using namespace std;

class Point
{
    public:
    double x , y;

    Point(double t, double r)
    {
        x = t;
        y = r;
        cout<<"x c : "<<x<<endl<<"y c : "<<y<<endl;
    }

    void print_point()
    {
        cout<<x<<endl<<y;
    }

    Point (Point* q)
    {
        x = q->x;
        y = q->y;
    }

    // Point (const Point& q) //const correctness
    // {
    //     x = q.x;
    //     //const avoids : q1 += 1; . Meaning it wouldn't let user to make changes in the input variable.
    //     y = q.y;
    // }

    double distance(Point p2)
    {
        return sqrt((x - p2.x) * (x - p2.x) + (y - p2.y) * (y - p2.y));
    }

    ~Point() 
    {
        cout<<"x d : "<<x<<endl<<"y d : "<<y<<endl;
    }
};

// void print_point(Point p)
// {
//     cout<<p.x<<endl<<p.y;
// }

// double distance(Point p1, Point p2)
// {
//     return sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
// }

int main1()
{
    Point p1(4,5);
    // Point p1;
    // p1.x = 4;
    // p1.y = 5;

    p1.print_point();

    // Point p2;
    // p2.x = -5;
    // p2.y = 3.7;
    // p2.print_point();

    // double r = p1.distance(p2);

    Point p3(p1);
    p3.print_point();

    cout << p1.x << endl;
    
    // int a;
    // cin>>a;
    return 0;
}

int main()
{
    Point p1(3,5);
    int c = 5;
    if (c>3)
    {
        Point p2(2,2);
        p2.x = 70;
        p2.y = 74;
    }
    else 
    {
        Point p3(4,3);
    }
    return 0;
}