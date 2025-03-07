#include<iostream>
using namespace std;

class point
{
    double m_x;
    double m_y;
    double DistanceTo(point p)
    {
        double x_diff = m_x - p.m_x;
        double y_diff = m_y - p.m_y;
    }

    void print_point()
    {
        cout<< "x:" << m_x << ",y:" << m_y << endl;
    }
};


class Circle
{
    point m_o;
    double m_r;

    Circle(const point& o , double r)
    {

    }

    Circle(const point & o , double r):m_o(o),m_r(r){};
    Circle (){};    

    double Distanceto(const Circle& c)
    {
        return Distanceto(c.m_o);
    }

    double dis

}