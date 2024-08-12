internal class Program
{
    private static void Main(string[] args)
    {
        /*bai1();
        bai2();
        bai3();
        bai4();
        bai5();*/
        bai8();
    }
    static void bai1()
    {
        Console.Write("nhập vào a: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhập vào b: ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tổng hai số là: " + (a1 + b1));
    }
    static void bai2()
    {
        Console.Write("nhập vào a: ");
        int a2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhập vào b: ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("trước khi chuyển: a = {0}, b={1}", a2, b2);
        a2 = a2 + b2;
        b2 = a2 - b2;
        a2 = a2 - b2;
        Console.WriteLine("sau khi chuyển: a = {0}, b={1}", a2, b2);
    }

    static void bai3()
    {
        Console.Write("nhập vào a: ");
        double a3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhập vào b: ");
        double b3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Tích hai số là: " + (a3 * b3));

    }
    static void bai4()
    {
        Console.Write("nhập vào số feet: ");
        double a4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{a4} feet = {a4 * 0.3048} meter");
    }
    static void bai5()
    {
        Console.Write("Nhap vào so do muon chuyen (C or F): ");
        double a5 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Loai do ban muon chuyen sang la (C or F): ");
        string b5 = Convert.ToString(Console.ReadLine());
        if (b5 == "C")
        {
            Console.WriteLine("So do C la: " + (5 / 9 * (a5 - 32)));
        }
        else if (b5 == "F") 
        {
            Console.WriteLine("So do F la: " + (9 / 5 * a5 + 32));
        }
        else
        {
            Console.WriteLine("Khong thoa man");
        }

    }
    static void bai8()
    {
        Console.Write("Nhap vao ban kinh r: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dien tich hinh tron la: " + (r * r * 3.14));

    }

}


