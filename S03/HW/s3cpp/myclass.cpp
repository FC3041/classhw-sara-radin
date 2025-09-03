#include<iostream>
#include<string.h>
#include<stdlib.h>

class student
{
    public:
    int sN;
    char stu_name[20];
    char stu_lastname[20];
    int course;
    char* courses_name[40];
    double courses_grade[40];
    int courses_credit[40];

     student(const char* name,const char* lastname,int stNumber)
     {
        strncpy(stu_name,name,sizeof(stu_name)-1);
        stu_name[sizeof(stu_name)-1]='/0';
        strncpy(stu_name,lastname,sizeof(stu_name)-1);
        stu_lastname[sizeof(stu_name)-1]= '/0';
        sN = stNumber;
        course = 0;

     }

      void studentscourses(const char* name,int credit,double grade)
      {
        char* aloname = new char[sizeof(name)+1];
        strcpy(aloname,name);
        courses_name[course] = aloname;
        courses_credit[course] = credit;
        courses_grade[course]=grade;
        course++;       
      }

      double stu_avr()
      {
        double sum_grade=0;
        int sum_credit=0;
        for(int i =0;i<course;i++)
        {
            sum_grade+= courses_grade[i];
            sum_credit+=courses_credit[i];
            
        }

        return sum_grade/ sum_credit;
      }

      void show_stuinfo()
      {
        for(int i = 0;i<course;i++)
            std::cout<< courses_name[i] << "(" << courses_credit << ")" << courses_grade << std::endl;
        
      }

      ~student ()
      {
        std::cout << "student" << stu_name << " " << stu_lastname << "has been deleted";
        
      }

      void receive_info()
      {
        while (true)
        {
            std::cout << "please type course name";
            std::cin >> courses_name[course];
            std::cout << "please type course credit";
            std::cin >> courses_credit[course];
            std::cout << "please type course grade";
            std::cin >> courses_grade[course];
                        
        }
      }

};

int main()
{
    student first_Stu("Sara","Radin",403521312);

}