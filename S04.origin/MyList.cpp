#include<iostream>
#include<stdlib.h>
using namespace std;


class MyList
{
    public:
        int m_size;
        int m_capacity; // TODO1: new_size = size*2
        int* m_Pnums;

    MyList(int size, int *nums , int capacity)
    :m_size(size)
    {
        m_Pnums = (int*)malloc(sizeof(int)*size);
        m_capacity = capacity;
        int i;
        for(i=0; i<m_size;i++)
        {
            m_Pnums[i] = nums[i];
        }
    }


    ~MyList() {
        free(m_Pnums);
    }
    

    void append(int x)
    {
        if (m_size == m_capacity)
        {
            to_do();
        }
        else
        {
            m_size++;
            m_Pnums[m_size-1] = x;
        }
    }  

    void erase(int pos)
    {
        if (pos<0 || pos >= m_size)
        {
            throw out_of_range("Position out of range");
        }
        for (int i = pos; i< m_size-1  ; i++)
        {
            m_Pnums[i] = m_Pnums[i+1];
        }
        m_size--;
    }

    void to_do()
    {
        m_capacity = 2 * m_capacity; 
        int* newMem = (int*)malloc(sizeof(int)* m_capacity);
        int i=0;
        for(i=0; i<m_size;i++)
        {
            newMem[i] = m_Pnums[i];
        }
        free(m_Pnums);
        m_Pnums = newMem;
        //newMem = NULL;
    

    }

    private:


    void resize(int newsize)
    {
        if (newsize <= m_capacity)
            return;

        int* newMem = (int*)malloc(sizeof(int)*newsize);
        int i=0;
        for(i=0; i<m_size;i++)
        {
            newMem[i] = m_Pnums[i];
        }
        free(m_Pnums);
        m_capacity = newsize;
        m_Pnums = newMem;
        //newMem = NULL;
    }
};

int main()
{
    int nums[5] = {1,2,3,4,5};
    MyList m(5, nums , 5);
    m.append(14);
}