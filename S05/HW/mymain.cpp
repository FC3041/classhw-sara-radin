#include <iostream>
#include <cstring> 
#include <string> 
using namespace std;

class String
{
    public:
    char* Name;
    size_t length;
    mutable char* c_style_string;
   

    String(const std::string& newName)
    {
        length = newName.size();
        Name = new char[length + 1];
        for (size_t i = 0; i < length; ++i) {
            Name[i] = newName[i];
        }
        Name[length] = '\0';
    }

    String() : Name(nullptr), length(0), c_style_string(nullptr) {}


    ~String() 
    {
        delete[] Name;
    };


    size_t size() const {
        return length;
    }


    const char* c_str() const
    {
        delete[] c_style_string; 
        c_style_string = new char[length + 1];
        for (size_t i = 0; i < length; ++i) {
            c_style_string[i] = Name[i];
        }
        c_style_string[length] = '\0';
        return c_style_string; 

    }


    const std::string str_c()
    {
        std::string std_string;
        for (size_t i = 0; i < length; ++i) 
        {
            std_string.push_back(Name[i]);
        }
        return std_string; 

    }

    void assign(const std::string& newName)
    {
        delete[] Name;
        length = newName.size();
        Name = new char[length + 1];
        for (size_t i = 0; i < length; ++i) 
        {
            Name[i] = newName[i];
        }
        Name[length] = '\0';
    }


    void append(const std::string& appenD)
    {
        length += appenD.size();
        std::string Namecopy = str_c() ;
        delete[] Name;
        Name = new char[length + 1];
        for (size_t i = 0; i < length-appenD.size(); i++)
        {
            Name[i] = Namecopy[i];
        }
        
        for (size_t i = 0; i < appenD.size(); ++i)
        {
            Name[length-appenD.size()+ i] = appenD[i];
        }
        Name[length]= '\0';
    }

    void append(const String& other) {
        append(other.c_str());
    }

};



int main()
{
    String name("ali"); // TODO1
    String name2; // TODO2
    name2.assign("mozhdeh"); // TODO3
    const char* temp = name.c_str();
    cout << temp << ":" << name.size() << endl; // TODO 4, 5
    delete[] temp;
    name.append(" + "); // TODO 6
    name.append(name2); // TODO 7
    name.append("\n");
    cout << name.c_str() << endl;
    return 0;
}