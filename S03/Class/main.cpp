#include<iostream>

class Student
{
    int m_stdNum;
    char m_FirstName[20];
    char m_LastName[20];
    double m_GPA;
    int m_coursesPassed;
    int m_Credits[40];
    double m_Gtades[40];
    char m_CourseNames[40];
    

    double GetGPA()
    {
        double sumGrade =0;
        int sumCredit =0 ;
        for (int i =0;i<m_coursesPassed; i++)
        {
            sumGrade += m_Credits[i] * m_Gtades[i] ;
            sumGrade += m_Credits[i];

        }

        return sumGrade/sumCredit;
    }


    void list_courses()
    {
        for (int i = 0;i<m_coursesPassed;i++)
        {
            std::cout << m_CourseNames

            
        }

    }


    void register_COURSE(int credits,const char* name , double gra)
    {

    }
};



int main ()
{
    Student s;
    std::cout << s.GetGPA() << std::endl ;
    return 0 ;
}