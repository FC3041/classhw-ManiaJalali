
public interface ICar
{
    public double NumberOfPeople();
    public double Area();
    public double Requiered_license_type();
}

class Bus:ICar
{
    public double L; //length
    public double W; //width
    public double license;

    public Bus(double ll, double ww,double li)
    {
        L = ll;
        W = ww;
        license = li;
    }

    public double NumberOfPeople()
    {
        return 26;
    }

    public double Area()
    {
        return L*W;
    }
    public double Requiered_license_type()
    {
        return license;
    }
}

class Truck:ICar
{
    public double L;
    public double W;
    public double license;


    public Truck(double ll, double ww,double li)
    {
        L = ll;
        W = ww;
        license = li;

    }
    public double NumberOfPeople()
    {
        return 2;
    }

    public double Area()
    {
        return L*W;
    }
        public double Requiered_license_type()
    {
        return license;
    }
}

class Van:ICar
{
    public double L;
    public double W;
    public double license;

    public Van(double ll, double ww,double li)
    {
        L = ll;
        W = ww;
        license = li;

    }
    public double NumberOfPeople()
    {
        return 12;
    }

    public double Area()
    {
        return L*W;
    }
        public double Requiered_license_type()
    {
        return license;
    }
}