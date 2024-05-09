using System;
using System.Collections.Generic;

namespace ChuyenSoThanhChu
{
    class Program
    {
    public static void Main(string[] args)
    {
        int i;
        string Donvi = "" , HangChuc = "" , HangTram = "";
        Console.WriteLine("Nhap so bat ky : ");
        i = Int32.Parse(Console.ReadLine());
    
switch (i%10)
{
    case 0:
    Donvi = "Khong" ;
    break;
    case 1:
    Donvi ="Mot";
    break;
    case 2:
    Donvi ="Hai";
    break;
    case 3:
    Donvi ="Ba";
    break;
    case 4:
    Donvi ="Bon";
    break;
    case 5:
    Donvi ="Nam";
    break;
    case 6:
    Donvi ="Sau";
    break;
    case 7:
   Donvi ="Bay";
    break;
    case 8:
    Donvi ="Tam";
    break;
    case 9:
    Donvi ="Chin";
    break;
    }
    
switch (i/10)
{
    case 0:
    HangChuc ="Muoi";
    break ;
    case 1:
    HangChuc ="Mot";
    break;
    case 2:
    HangChuc ="Hai";
    break;
    case 3:
    HangChuc ="Ba";
    break;
    case 4:
    HangChuc ="Bon";
    break;
    case 5:
    HangChuc ="Nam";
    break;
    case 6:
    HangChuc ="Sau";
    break;
    case 7:
   HangChuc ="Bay";
    break;
    case 8:
    HangChuc ="Tam";
    break;
    case 9:
    HangChuc ="Chin";
    break;
    }
      
    Console.WriteLine("So can chuyen la: {0} {1}", HangChuc,Donvi);
    }
    }
}




