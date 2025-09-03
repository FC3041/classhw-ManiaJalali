namespace S12;

class Program
{
    static void Main(string[] args)
    {
        ICar[] shapes = new ICar[]{
            new Van(4,3,1),
            new Bus(10,3,2),
            new Truck(3,2,1)
        };
        
        double people_sum = 0;
        double Area_sum = 0;

        for(int i=0; i<shapes.Length;i++)
        {
            Area_sum += shapes[i].Area();
            people_sum += shapes[i].NumberOfPeople();
            System.Console.WriteLine(shapes[i].Requiered_license_type());
        }

        System.Console.WriteLine(people_sum);
        System.Console.WriteLine(Area_sum);

    }
}
