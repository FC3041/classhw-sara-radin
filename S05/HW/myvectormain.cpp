#include <iostream>
using namespace std;


class vector_int
{
    public:
    int* vector; 
    size_t size;
    size_t capacity;

    vector_int()
    {
        vector = nullptr;
        size = 0;
        capacity=0;
    }

    ~vector_int()
    {
        delete[] vector;
    }

    void resize(size_t newcapacity)
    {
        int* newvector = new int[newcapacity];
        for(size_t i =0 ; i<size ; ++i)
            newvector[i] = vector[i];
        delete[] vector;
        vector = newvector;
        capacity = newcapacity;
    }

    void if_size_equal_capacity()
    {
        size_t newcapacity;
            if (capacity== 0)
                newcapacity = 1;
            else
                newcapacity = capacity*2;
            resize(newcapacity);
    }


    void push_back(int value)
    {
        if(size == capacity)
        {
           if_size_equal_capacity();
        }
        vector[size]=value;
        size++;
    }


    void insert(int index,int value)
    {
        if (index> size)
            throw out_of_range("Index out of range");
        if (size == capacity)
        {
            if_size_equal_capacity();
        }
        for (size_t i = size; i > index ; i--)
        {
            vector[i] = vector[i-1];
        }
        vector[index] = value;
        size++;
    }

    void erase(int index)
    {
        if (index >= size)
        throw out_of_range("Index out of range");
        for(size_t i = index ; i<size-1 ; i++)
            vector[i] = vector[i+1];
        size--;
    }

    int at(size_t index)const
    {
        if (index>=size)
        throw out_of_range("Index out of range");
        return vector[index];
    }
    

    size_t Size() const {
        return size;
    }

    int begin()
    {
        return 0;
    }

    size_t Capacity() const
    {
        return capacity;
    }

    void clear() {
        size = 0;
    }




};





int main()
{
    vector_int nums;; // TODO1 vector_int
    nums.push_back(5); // TODO2
    nums.push_back(10);
    for(int i=0; i<nums.Size(); i++)  // TODO3
        cout << nums.at(i) << endl; // TODO4
    // cout << nums[i] << endl;
    //nums.insert(0, 2); // 5, 10 ==> 2, 5, 10
    nums.insert(nums.begin(), 2); // 5, 10 ==> 2, 5, 10
                                     // TODO5
    nums.erase(nums.begin()); // 2, 5, 10 ==> 5, 10
    // nums.erase(3) // TODO6
    cout << nums.Capacity() << endl; //TODO7
    nums.clear(); // TODO8
    // int num = 10;
    // num << 1;
    // num >> 1;
    

    return 0;


}    