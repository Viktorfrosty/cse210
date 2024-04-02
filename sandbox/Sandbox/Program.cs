using Test;

class Program
{

    static void Main(string[] args)
    {

        Generation1 a = new Generation1();

        a.ShowName();

        a.ShowMessage();

        Generation2B b = new Generation2B();

        b.ShowName();

        b.ShowMessage();

        Generation3 c = new Generation3();

        c.ShowName();
        
        c.ShowMessage();

    }

}