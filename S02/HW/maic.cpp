#include<iostream>
#include<math.h>
#include <cmath>

using namespace std;

class point
{
    public:
        double x;
        double y;
        double r;

        point(double p , double q)
        {
            x=p;
            y=q;
        }
        point(double p, double q,double w)
        {
            x =p;
            y =q; 
            r=w;  
        }

        void circle_perimeter()
        {
            double perimeter = 2* M_PI * r;
            std::cout << "perimeter =   "<< perimeter << std::endl;
        }


        void circle_area()
        {
            double area =  M_PI * r * r;
            std::cout << "area =   "<< area << std::endl;
        }

        void two_circle_distance(point b)
        {
            double x_diff = x -b.x;
            double y_diff = y -b.y;
            std::cout << "two_circle_distance =   "<< sqrt(x_diff*x_diff + y_diff*y_diff)  << std::endl;
        }

        void inside_or_outside(point c)
        {
            double x_diff = x - c.x;
            double y_diff = y -c.y;
            double rt =sqrt(x_diff*x_diff + y_diff*y_diff);
            if (rt < r)
                cout << "the point is inside the circle"<<endl;
            if (rt==r)
                cout << "the point is on the circle"<<endl;
            else
                cout << "the point is outside the circle"<<endl;
        }

        void distance_point_circlecenter(point c)
        {
            double x_diff = x - c.x;
            double y_diff = y -c.y;
            double rt =sqrt(x_diff*x_diff + y_diff*y_diff);
            cout <<"distance_point_circlecenter =   "<<rt<<endl;
        }


};


int main()
{
    point p0(0,0,3);
    point p1(3,4,5);
    point c(2,5);
    p0.circle_perimeter();
    p0.circle_area();
    p0.two_circle_distance(p1);
    p0.inside_or_outside(c);
    p0.distance_point_circlecenter(c);

}