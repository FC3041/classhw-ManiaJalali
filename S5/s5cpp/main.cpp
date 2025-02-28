#include<iostream>
using namespace std;

class Vector_int
{
    public:
    int size_vector;
    int* vector_array;
    int capacity_vector; 

    Vector_int()
    {
        capacity_vector = 4;
        size_vector = 0;
        vector_array = new int[capacity_vector];
    }

    ~Vector_int()
    {
        delete[] vector_array;
    }

    void push_back(int n)
    {
        if (size_vector == capacity_vector)
        {
            capacity_vector += 1;
            int* new_array = new int[capacity_vector];
            for (int i = 0; i < size_vector; i++)
            {
                new_array[i] = vector_array[i];
            }
            delete[] vector_array;
            vector_array = new_array;
        }
        vector_array[size_vector] = n;
        size_vector++;
        
        // there is another way to allocate memory with realloc which is way easier. 
        //int* new_array = (int*) realloc(vector_array, (size + 1) * sizeof(int));
        // it would do the same thing as line 30 to 34
        // Resize Memory Block: realloc resizes the memory block pointed to by vector_array. If it needs to move the memory block to a new location (e.g., because the current block can't be expanded), it automatically copies the existing data to the new location.
        // Free Old Memory Block: If realloc moves the memory block to a new location, it automatically frees the old memory block. You don't need to manually delete the old memory.
        //In other words, realloc combines the steps of resizing the memory, copying the data, and freeing the old memory into a single function call. This is why we don't need to explicitly delete[] vector_array; when using realloc.
    }

    int size()
    {
        return size_vector;
    }

    int capacity() const
    {
        return capacity_vector;
    }

    bool empty() 
    {
        if (size_vector == 0) 
        {
            cout << "true"<<endl;
        }
        cout<<"false"<<endl;
        return size_vector == 0;
    }

    int at(int n)
    {
        return vector_array[n];
    }

    void insert(int place, int input)
    {
        if (size_vector == capacity_vector)
        {
            capacity_vector *= 2;
            int* new_array = new int[capacity_vector];
            for (int i = 0; i < size_vector; i++)
            {
                new_array[i] = vector_array[i];
            }
            delete[] vector_array;
            vector_array = new_array;
        }

        for (int i = size_vector; i > place; i--)
        {
            vector_array[i] = vector_array[i - 1];
        }

        vector_array[place] = input;
        size_vector++;
    }

    void erase(int place)
    {
        place--;
        for (int i = place; i < size_vector - 1; i++)
        {
            vector_array[i] = vector_array[i + 1];
        }
        size_vector--;
    }

    void clear()
    {
        delete[] vector_array;
        vector_array = nullptr;
        size_vector = 0;
        capacity_vector = 4;
    }

    void print()
    {
        for(int i = 0; i < size_vector; i++)
        {
            cout << vector_array[i] << ",";
        }
        cout<<endl;
    }

};

class String
{
    public:

    int size_string;
    char* string_array;
    String(const char* s)
    {
        size_string = string_size(s);
        string_array = new char[size_string];
        for (int i = 0; i < size_string; i++)
        {
            string_array[i] = s[i];
        }
    }

    ~String()
    {
        delete[] string_array;
    }
    
    void assign(string s)
    {
        for (int i = 0; i < size_string; i++)
        {
            string_array[i] = s[i];
        }
        size_string = string_size(s);
    }

    int size()
    {
        return size_string;
    }

    int string_size(const char* s)
    {
        int count = 0, i = 0;
        while(s[i] != '\0')
        {
            count++;
        }
        return count;
    }

    int string_size(string s)
    {
        int count = 0 , i = 0;
        while(string_array[i] != '\0')
        {
            count++;
        }
        return count;
    }

    void append(string s)
    {
        int to_add_size = string_size(s);
        char* new_string = new char[size_string + to_add_size];
        for (int i = 0; i < size_string; i++)
        {
            new_string[i] = string_array[i];
        }
        for (int i = size_string; i < size_string + to_add_size; i++)
        {
            new_string[i] = s[i];
        }
        delete[] string_array;
        string_array = new_string;
        size_string += to_add_size;
    }
    void c_str()
    {
        for(int i = 0; i < size_string; i++)
        {
            cout << string_array[i];
        }
        cout<<endl;
    }
};

int main()
{
    int nums[] = {1, 2, 3} , a;
    Vector_int vec;//todo1

    vec.push_back(4);
    vec.push_back(3);//todo2
    vec.push_back(12);
    vec.print();
    vec.insert(1, 5);//todo5
    vec.push_back(7);
    cout << vec.size() << endl;//todo3
    vec.print();
    vec.empty();
    vec.erase(2);//todo6
    vec.print();
    cout <<"size: "<< vec.size() << endl;
    cout <<"capacity: "<< vec.capacity() << endl;//todo7
    cout << vec.at(3) << endl; //todo4
    vec.clear();//todo8
    vec.print();
    vec.empty();

    string name2; // todo2
    string name("ali"); //todo1
    cout<< name.c_str()<<endl; 
    name2.assign("mozhdeh");  // todo3
    cout << name2.c_str() << ":" << name2.size() << endl; // TODO 4, 5
    name2.append(" + "); // TODO 6
    name2.append(name2); // TODO 7
    name2.append("\n");
    cout << name2.c_str() << endl;
    return 0;
}

// int main()
// {
//     vector<int> nums; // TODO1 vector_int
//     nums.push_back(5); // TODO2
//     nums.push_back(10);
//     for(int i=0; i<nums.size(); i++)  // TODO3
//         cout << nums.at(i) << endl; // TODO4 
//     // cout << nums[i] << endl;
//     //nums.insert(0, 2); // 5, 10 ==> 2, 5, 10
//     nums.insert(nums.begin(), 2); // 5, 10 ==> 2, 5, 10
//                                      // TODO5
//     nums.erase(nums.begin()); // 2, 5, 10 ==> 5, 10
//     // nums.erase(3) // TODO6
//     cout << nums.capacity() << endl; //TODO7
//     nums.clear(); // TODO8
//     int num = 10;
//     num << 1;
//     num >> 1;

//     return 0;
// }    

// int main()
// {
//     string name("ali"); // TODO1
//     string name2; // TODO2
//     name2.assign("mozhdeh"); // TODO3
//     cout << name.c_str() << ":" << name.size() << endl; // TODO 4, 5
//     name.append(" + "); // TODO 6
//     name.append(name2); // TODO 7
//     name.append("\n");
//     cout << name.c_str() << endl;
//     return 0;
// }

// int main2()
// {
//     string name = "ali";
//     string name2 = "zhale";
//     cout << name << ":" << name.size() << endl;
//     name += " + " + name2 + "\n";
//     cout << name << endl;
//     return 0;
// }