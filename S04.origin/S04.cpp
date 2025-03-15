#include<iostream>
#include<stdlib.h>
using namespace std;


class MyList
{
    public:
        int m_size;
        int* m_Pnums;

    MyList(int size, int *nums)
    :m_size(size)
    {
        m_Pnums = (int*)malloc(sizeof(int)*size);
        int i;
        for(i=0; i<m_size;i++)
        {
            m_Pnums[i] = nums[i];
        }
    }

    ~MyList() 
    {
    }

    void append(int x)
    {
        resize(m_size+1);
        m_Pnums[m_size-1] = x;
    }

    void pop()
    {
        if (m_size > 0)
            resize(m_size-1);
    }

    void print()
    {
        for(int i=0;i<m_size;i++)
        {
            std::cout<<m_Pnums[i]<<std::endl;
        }
    }

    int count(int x) const
    {
        int count = 0;
        for (int i =0;i<m_size;i++)
        {
            if (m_Pnums[i] == x)
                count++;
        }
        return count;
    }



    private:
    void resize(int newsize)
    {
        int* newMem = (int*)malloc(sizeof(int)*newsize);
        int i=0;
        for(i=0; i < m_size && i < newsize;i++)
        {
            newMem[i] = m_Pnums[i];
        }
        free(m_Pnums);
        m_size = newsize;
        m_Pnums = newMem;
        //newMem = NULL;
    }

    
};

int main()
{
    int nums[6] = {1,1,2,3,4,5};
    MyList m(5, nums);
    m.append(14);
    m.print();
    m.pop();
    m.print();
    std::cout<< m.count(1) << std::endl;
    m.append(1);
    std::cout<< m.count(1) << std::endl;
}