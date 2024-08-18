using System.Formats.Asn1;

internal class Program
{
    private static void Main(string[] args)
    {
        bai1();
        bai2();
        bai3();
        bai4();
        bai5();
        bai6();
        bai8();
        bai9();
        bai10();
        
    }
    static void bai1()
    {
        Console.Write("nhap vao so a: ");
        int num_a1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap vao so b: ");
        int num_b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tong hai so la: " + (num_a1 + num_b1));
    }
    static void bai2()
    {
        Console.Write("nhap vao so a: ");
        int a2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap vao so b: ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("truoc khi chuyen: a = {0}, b={1}", a2, b2);
        a2 = a2 + b2;
        b2 = a2 - b2;
        a2 = a2 - b2;
        Console.WriteLine("sau khi chuyen: a = {0}, b={1}", a2, b2);
    }

    static void bai3()
    {
        Console.Write("nhap vao so a: ");
        double num_a3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap vao so b: ");
        double num_b3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Tich hai so la: " + (num_a3 * num_b3));

    }
    static void bai4()
    {
        Console.Write("nhap vao so feet: ");
        double a4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{a4} feet = {a4 * 0.3048} meter");
    }
    static void bai5()
    {
        
        Console.Write("Loai do ban muon chuyen sang la (C or F): ");
        string a5 = Convert.ToString(Console.ReadLine());
        a5 = a5.ToUpper();
        if (a5 == "C")
        {
            Console.Write("Nhap vao so do F : ");
            double b5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("So do C la: " + ((b5-32)/1.8));
        }
        else if (a5 == "F") 
        {
            Console.Write("Nhap vao so do C : ");
            double b5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("So do F la: " + (1.8 * b5 + 32));
        }
        else
        {
            Console.WriteLine("Khong thoa man yeu cau");
        }

    }
    static void bai6()
    {
        Console.WriteLine("Kich thuoc cua kieu bool la: " + sizeof(bool) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu byte la: " + sizeof(byte) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu char la: " + sizeof(char) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu decimal la: " + sizeof(decimal) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu double la: " + sizeof(double) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu float la: " + sizeof(float) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu int la: " + sizeof(int) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu long la: " + sizeof(long) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu sbyte la: " + sizeof(sbyte) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu short la: " + sizeof(short) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu unit la: " + sizeof(uint) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu ulong la: " + sizeof(ulong) + " bytes");
        Console.WriteLine("Kich thuoc cua kieu ushort la: " + sizeof(ushort) + " bytes");

    }
    //bỏ bài 7
    static void bai8()
    {
        Console.Write("Nhap vao ban kinh r (cm): ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dien tich hinh tron ban kinh " + r + " cm la: " + (r * r * 3.14) + " cm^2" );
    }
    static void bai9()
    {
        Console.Write("Nhap vao canh a9 (cm): ");
        double a9 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dien tich hinh vuong canh " + a9 + " cm la: " + (a9 * a9) + " cm^2");
    }
    static void bai10()
    {
        Console.Write("Nhap vao so ngay can chuyen: ");
        int day_a10 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($" Ta co: {day_a10 / 365} nam va {(day_a10 % 365)/7} tuan va {(day_a10 % 365)%7} ngay ");
    }
}


