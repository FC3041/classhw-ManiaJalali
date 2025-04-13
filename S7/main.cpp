#include<iostream>
#include<Windows.h>

using namespace std;

class KeepTime
{
    public:
    unsigned long long firstSecond;
    string towrite;

    KeepTime(string s)
    :firstSecond(GetTickCount64()), towrite(s)
    {}
    ~KeepTime()
    {
        unsigned long long lastSecond = GetTickCount64();
        cout << towrite << lastSecond - firstSecond;
    }
};

int main()
{
    {
        KeepTime t("for loop 365 double mul");
        double d = 1;
        for (int i = 0; i < (1000000); i++) {
            d = d * 1.01;
        }
    }

}
