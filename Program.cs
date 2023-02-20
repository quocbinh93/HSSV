using System;
namespace HSSV
{
    class Program
    {
        struct SinhVien
        {
            public string maSV;
            public string hoTen;
            public double diemToan;
            public double diemLy;
            public double diemHoa;
            public double diemTB;
            public void NhapDuLieu(){
                Console.Write("Nhap ma sinh vien: ");
                maSV = Console.ReadLine();
                Console.Write("Nhap ho ten sinh vien: ");
                hoTen = Console.ReadLine();
                Console.Write("Nhap diem toan: ");
                diemToan = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem ly: ");
                diemLy = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem hoa: ");
                diemHoa = double.Parse(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            SinhVien[] sv = new SinhVien[100];
            int n;
            Console.Write("Nhap so sinh vien: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sv[i].NhapDuLieu();
            }
            Console.WriteLine("Danh sach sinh vien vua nhap la: ");
            Console.WriteLine("Ma SV\tHo ten\tDiem toan\tDiem ly\tDiem hoa\tDiem TB");
            for (int i = 0; i < n; i++)
            {
                sv[i].diemTB = (sv[i].diemToan + sv[i].diemLy + sv[i].diemHoa) / 3;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", sv[i].maSV, sv[i].hoTen, sv[i].diemToan, sv[i].diemLy, sv[i].diemHoa, sv[i].diemTB);
            }
            Console.WriteLine("Nhap vao noi dung muon tiep tuc:");
            Console.WriteLine("1. Tim va hien thi thong tin sinh vien co diem trung binh cong cao nhat");
            Console.WriteLine("2. Tim va hien thi thong tin sinh vien co diem trung binh cong thap nhat");
            Console.WriteLine("3. Tinh va hien thi diem trung binh cong cua cot trung binh cong cua ca lop");
            Console.WriteLine("4. Hien thi danh sach sinh vien co diem trung binh cong be hon 5");
            Console.WriteLine("5. Thoat\n");
            int chon;
            chon = int.Parse(Console.ReadLine());
            switch (chon){
                case 1:
                    double max = sv[0].diemTB;
                    for (int i = 0; i < n; i++)
                    {
                        if (sv[i].diemTB > max)
                        {
                            max = sv[i].diemTB;
                        }
                    }
                    Console.WriteLine("Sinh vien co diem trung binh cong cao nhat la: ");
                    Console.WriteLine("Ma SV\tHo ten\tDiem toan\tDiem ly\tDiem hoa\tDiem TB");
                    for (int i = 0; i < n; i++)
                    {
                        if (sv[i].diemTB == max)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", sv[i].maSV, sv[i].hoTen, sv[i].diemToan, sv[i].diemLy, sv[i].diemHoa, sv[i].diemTB);
                        }
                    }
                    break;
                    case 2:
                    double min = sv[0].diemTB;
                    for (int i = 0; i < n; i++)
                    {
                        if (sv[i].diemTB < min)
                        {
                            min = sv[i].diemTB;
                        }
                    }
                    Console.WriteLine("Sinh vien co diem trung binh cong thap nhat la: ");
                    Console.WriteLine("Ma SV\tHo ten\tDiem toan\tDiem ly\tDiem hoa\tDiem TB");
                    for (int i = 0; i < n; i++)
                    {
                        if (sv[i].diemTB == min)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", sv[i].maSV, sv[i].hoTen, sv[i].diemToan, sv[i].diemLy, sv[i].diemHoa, sv[i].diemTB);
                        }
                    }
                    break;
                    case 3:
                    double tong = 0;
                    for (int i = 0; i < n; i++)
                    {
                        tong += sv[i].diemTB;
                    }
                    double dtb = tong / n;
                    Console.WriteLine("Diem trung binh cong cua lop la: {0}", dtb);
                    break;
                    case 4:
                    Console.WriteLine("Danh sach sinh vien co diem trung binh cong be hon 5 la: ");
                    Console.WriteLine("Ma SV\tHo ten\tDiem toan\tDiem ly\tDiem hoa\tDiem TB");
                    for (int i = 0; i < n; i++)
                    {
                        if (sv[i].diemTB < 5)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", sv[i].maSV, sv[i].hoTen, sv[i].diemToan, sv[i].diemLy, sv[i].diemHoa, sv[i].diemTB);
                        }
                    }
                    break;
                    case 5:
                    Console.WriteLine("Thoat");
                    break;
                    default:
                    Console.WriteLine("Nhap sai");
                    break;
            }
            Console.WriteLine("Ban muon tiep tuc khong? (Y/N)");
            string tieptuc = Console.ReadLine();
            if (tieptuc == "Y" || tieptuc == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Cam on ban da su dung chuong trinh");
            }
            Console.ReadLine();
        }
    }
}
