#include<iostream>

using namespace std;

class Student
{
    public:
    int m_stdNum;
    char m_FirstName[20];
    char m_LastName[20];
    double m_GPA;
    int m_CoursesPassed;
    int m_Credits[40];
    double m_Grades[40];
    char* m_CoursesNames[40];

    double GetGPA()
    {
        double sumGrade = 0;
        int sumCredits = 0;
        for (int i = 0; i < m_CoursesPassed; i++)
        {
            sumGrade += (m_Credits[i] * m_Grades[i]);
            sumCredits += m_Credits[i];
        }
        return sumGrade / sumCredits;
    }

    void list_courses()
    {
        for (int i = 0; i < m_CoursesPassed; i++)
        {
            cout << m_CoursesNames[i] << " : " << m_Credits[i] << " : " << m_Grades[i] << endl;
        }
    }

    void register_course(int credits, const char* name, double grades)
    {

    }
};

int main()
{
    Student s;
    cout << s.GetGPA() << endl;
    return 0;
}