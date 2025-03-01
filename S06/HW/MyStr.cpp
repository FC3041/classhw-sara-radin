#include<iostream>

using namespace std;

class MyStr
{
    public:
    int m_size;
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }

    void printStr()
    {
        cout << m_PChars << endl;
    }

    bool checkSubstr(const char* chars)
    {
        for(int i = 0 ; i<=m_size-len(chars) ; i++)
        {
            int s = 0;
            while(chars[s] == m_PChars[s+i] )
            {
                s++;
                if (s == len(chars)-1)
                {
                    return true;
                }
            }
        }
        
        return false;
    }

    int len()
    {
        int len = 0;
        int i = 0;
        while (m_PChars[i]!='\0')
        {
            len++;
            i++;
        }
        return len;
    }

    int len(const char* chars)
    {
        int len = 0;
        int i = 0;
        while (chars[i]!='\0')
        {
            len++;
            i++;
        }
        return len;
    }

    
    char* add(const MyStr& chars)
    {
        int size = m_size + chars.m_size -1;
        char* newS = new char[size];
        for (int i = 0;i<m_size-1;i++)
        {
            newS[i] = m_PChars[i];
        }
        for (int i = 0;i<chars.m_size-1;i++)
        {
            newS[i+m_size-1] = chars.m_PChars[i];
        }
        delete[] m_PChars;
        m_PChars = newS ;
        m_size = size;
        return m_PChars;
    
    }
};


int main()
{
    MyStr s1(" is our professor");

    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();

    cout << s2.checkSubstr("haji")  << endl; // TODO1
    cout << s2.len() << endl; //TODO2
    cout << s2.add(s1)<< endl; // TODO3 

    MyStr s3("Sara is studying computer engineering");
    MyStr s4(" and now she is doing her Saturday AP homework");
    cout << s3.checkSubstr("Sara")  << endl;
    cout << s3.len() << endl; 
    cout << s3.add(s4); 
    return 0;
}