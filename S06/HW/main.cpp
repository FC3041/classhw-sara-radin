#include<iostream>
#include<stdlib.h>

using namespace std;

class MyList
{
    public:
        int m_size;
        int m_capacity;
        int* m_pNums;

        MyList():m_size(0),m_capacity(0),m_pNums(nullptr){};

        MyList(int size, int capacity , const int* nums)
        :m_size(size), m_capacity(capacity)
        {
            m_pNums = (int *)malloc(sizeof(int)*capacity);
            for (int i=0; i<m_size;i++)
            {
                m_pNums[i] = nums[i];
            }
        }

        void print_list()
        {
            cout << "size:" << m_size << " capacity:" << m_capacity << endl;
            for(int i=0;i<m_size;i++)
            {
                cout << m_pNums[i] << ",";
            }
            cout << endl;

        }

        int len(){return m_size;}

        void append(int value)
        {
            if (m_size == m_capacity)
            {
                if (m_size ==0){resize(1);}
                else
                {
                    resize(m_capacity*2);
                }
            }
            m_pNums[m_size] = value;
            m_size ++;
        }

        void insert(int index, int value)
        {
            if (m_size==m_capacity)
            {
                if (m_size==0){resize(1);}
                else{resize(m_capacity*2);}
            }
            for(int i=m_size; i>=index ;i--)
            {
                m_pNums[i] = m_pNums[i-1]; 
            }
            m_pNums[index] = value;
            m_size++;
        }

        void clear()
        {
            m_size = 0;
            resize(1);
        }

        void erase(int index) {
            if (index < 0 || index >= m_size) 
            {
                throw out_of_range("Index out of range");
            }
            for (int i = index; i < m_size - 1; i++) 
            {
                m_pNums[i] = m_pNums[i + 1];
            }
            m_size--; 
            
        }

        void reverse()
        {
            for(int i=0;i<int(m_size/2);i++)
            {
                int temp = m_pNums[i];
                m_pNums[i] = m_pNums[m_size-1-i];
                m_pNums[m_size-i-1] = temp;
            }
        }

        int at(int index)
        {
            if((index < m_size) && (index>-1))
                return m_pNums[index];
            throw out_of_range("Out of range");
        }



        void sort()
        {
            int min;
            int* sortednums = new int[m_size];
            int s = m_size;
            for (int i = 0 ; i < s ; i ++)
            {
                min = m_pNums[0];
                for (int j = 1; j<(s-i); j++)
                {
                    if (m_pNums[j]< min)
                    {
                        min = m_pNums[j];
                    }

                }
                sortednums[i] = min;
                erase(index(min));
            }
            delete[] m_pNums;
            m_pNums = sortednums;
            m_size = s;
         
        }


    private:
        void resize(int newsize)
        {
            int* newNums = (int*)malloc(sizeof(int)*(newsize));
            for(int i=0; i<m_size;i++)
            {
                newNums[i] = m_pNums[i];
            }
            free(m_pNums);
            m_pNums = newNums;
            m_capacity = newsize;

        }

        int index(int x)
        {
            for (int i = 0; i<m_size ; i++)
            {
                if (m_pNums[i] == x )
                {
                    return i;
                }
            }
            return 0;
        }

        
};

int main()
{
    MyList l1;

    int nums[5] = {1,2,3,4,5};
    MyList l2(5, 10, nums);

    l2.print_list();
    l2.append(19);

    l2.print_list();

    l2.insert(1, 55);
    l2.print_list();

    l2.erase(1);
    l2.print_list();

    l2.reverse();
    l2.print_list();

    cout << l2.at(3)<< endl;

    // l2.append(75);
    // l2.append(102);
    // l2.append(34);
    // l2.append(58);
    // l2.append(12);


    l2.sort(); //ToDo
    l2.print_list();


    return 0;
}