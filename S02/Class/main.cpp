#include<iostream>
#include<math.h>

using namespace std;


class point
{
    public:
        double x;
        double y;
        point(double t,double r)
        {
            x =t;
            y =r;
            cout << "x in c:"<< x <<", y in c:"<<y<<endl;
        }

        point (double w)
        {
            x=w;
            y=w;
        }

        // point (point*  q)
        // {
        //     x=q->x;
        //     y=q->y;
        // }

        point (const point&  q)
        {
            x=q.x;
            // q.y+=1;
            y=q.y;
        }


        void print_point()
        {
            cout <<"x: " <<x<< ",y:" <<y<<endl;
        
        }
        double points_distance(point w)
        {
            double x_diff = x -w.x;
            double y_diff = y -w.y;
            return sqrt(x_diff*x_diff + y_diff*y_diff);
        
        }

        ~point ()
        {
            cout << "x in d:"<< x <<", y in d:"<<y<<endl;
        }


};



int main()
{
    point p1(1,1);
    int c =5;
    if (c>3)
    {
        point p2(2,2);
    }
    else
    {
        point p2(3,3);
    }
}




int main1()
{
    point p0(9);
    p0.print_point();
    // point p1;
    point p1(4,5);
    // p1.x=4;
    // p1.y = 5;

    p1.print_point();

    // point p2;
    // p2.x = -5;
    // p2.y =10;
    point p2(-5,10);

    p2.print_point();
    point p3(p2);
    p3.print_point();
    cout << p1.x << endl;

    double r = p1.points_distance(p2);
    int a;
    std:: cin>>a;
    std:: cout<<"a:" <<a<<std::endl;
    return 0;
}