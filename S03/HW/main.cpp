#include<iostream>
#include<string.h>
#include<stdlib.h>

class Student
{
public:
    int m_stdNum;
    char m_FirstName[20];
    char m_LastName[20];
    int m_CoursesPassed;
    int m_Credits[40];
    double m_Grades[40];
    char* m_CourseNames[40];

    void stringcpy(char* s, const char* c)
    {
        int k = 0;
        while(c[k] != '\0')
        {
            s[k] = c[k];
            k++;
        }
        s[k] = '\0';
    }

    Student(int stdnum, const char* fname, const char* lname)
    {
        m_stdNum = stdnum;
        stringcpy(m_FirstName, fname);
        stringcpy(m_LastName, lname);
    }
    ~Student()
    {
        std::cout << "Deleted successfully."<<endl;
    }
    double GetGPA()
    {
        double sumGrade = 0;
        int sumCredit = 0;
        for(int i=0; i<m_CoursesPassed; i++) {
            sumGrade += m_Credits[i] * m_Grades[i];
            sumCredit += m_Credits[i];
        }
        return sumGrade / sumCredit;
    }

    void list_courses()
    {
        for(int i=0; i<m_CoursesPassed; i++) {
            std::cout << m_CourseNames[i] << ": "
                      << m_Credits[i] << " : "
                      << m_Grades[i] << std::endl;        
        }
    }

    void register_course(int credits, const char* name, double grade)
    {
        m_Credits[m_CoursesPassed] = credits;
        m_Grades[m_CoursesPassed] = grade;
        char* namecopy = new char[strlen(name) + 1];
            //(char*) malloc(strlen(name) + 1);
        strcpy(namecopy, name);
        m_CourseNames[m_CoursesPassed] = namecopy;
        m_CoursesPassed++;
    }
    Student(){}
};

int main()
{
    Student s(3423, "asdf", "lasdkfj");
    Student* s2 = new Student(3423, "asdf", "lasdkfj");
    Student* s3 = &s;
    int * pn = new int[10];
    s.m_CoursesPassed = 0;
    char bufc[20];
    double grade;
    int credits;
    while(true)
    {
        std::cout << "course name?" ;
        std::cin >> bufc ;
        if (*bufc == 'A')
            break;
        std::cout << "course credits?" ;
        std::cin >> credits ;
        std::cout << "course grade?" ;
        std::cin >> grade ;
        s.register_course(credits, bufc, grade);
    }
    s.list_courses();
    std::cout << s.GetGPA() << std::endl;
    return 0;
}
