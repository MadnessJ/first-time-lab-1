using System;
using System.Collections;
using System.Collections.Generic;

struct MatHang
{
    public int MaMH;
    public string TenMH;
    public int SoLuong;
    public float DonGia;

    public MatHang(int maMH, string tenMH, int soLuong, float donGia)
    {
        this.MaMH = maMH;
        this.TenMH = tenMH;
        this.SoLuong = soLuong;
        this.DonGia = donGia;
    }

    public float ThanhTien()
    {
        return SoLuong * DonGia;
    }
}

class Program
{
    static void ThemMatHang(Hashtable danhSach, MatHang m)
    {
        if (!danhSach.ContainsKey(m.MaMH))
            danhSach.Add(m.MaMH, m);
        else
            Console.WriteLine("Mat hang voi ma nay da ton tai.");
    }

    static void XoaMatHang(Hashtable danhSach, int maMH)
    {
        if (danhSach.ContainsKey(maMH))
        {
            danhSach.Remove(maMH);
            Console.WriteLine("Mat hang da duoc xoa.");
        }
        else
            Console.WriteLine("Khong tim thay mat hang.");
    }

    static void XuatDanhSach(Hashtable danhSach)
    {
        Console.WriteLine("\nDanh sach mat hang:");
        foreach (MatHang mh in danhSach.Values)
        {
            Console.WriteLine($"Ma: {mh.MaMH}, Ten: {mh.TenMH}, So luong: {mh.SoLuong}, Don gia: {mh.DonGia}, Thanh tien: {mh.ThanhTien()}");
        }
    }

    static void Main()
    {
        Hashtable danhSach = new Hashtable();

        while (true)
        {
            Console.Write("Nhap ma mat hang: ");
            int ma = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten mat hang: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            int soLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            float donGia = float.Parse(Console.ReadLine());

            MatHang mh = new MatHang(ma, ten, soLuong, donGia);
            ThemMatHang(danhSach, mh);

            Console.Write("Ban co muon tiep tuc nhap khong (Y/N)? ");
            string tiepTuc = Console.ReadLine().ToUpper();
            if (tiepTuc != "Y") break;
        }

        XuatDanhSach(danhSach);
    }
}
