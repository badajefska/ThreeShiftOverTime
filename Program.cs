// See https://aka.ms/new-console-template for more information
using System;

public class Example
{
    public static void Main()
    {
        string st;
        Console.Write("日付を入力してください");
        st = Console.ReadLine();
        Console.WriteLine(st);

        // 今日の日付をシリアル値出力(OLE オートメーション日付)
        DateTime dt = DateTime.Parse(st);
        double oadate = dt.ToOADate();
        Console.WriteLine(oadate);

        // ダブルからロングに変換　＋数字で各groupの流れに乗せる
        long serial = ((long)oadate);
        long serial002 = serial + 6;
        Console.WriteLine(serial002);

        // 10進法から16進法に変換
        // 最終文字出力
        string str = serial002.ToString("x");
        Console.WriteLine(str);
        int len = str.Length;
        string result = str.Substring(len-1, 1);
        Console.WriteLine(result);

        // switchで当番を出力
        switch (result)
        {
            case "0":
            case "5":
            case "a":
            case "f":
                Console.WriteLine("休");
                break;
            case "1":
                Console.WriteLine("甲①");
                break ;
            case "2":
                Console.WriteLine("甲②");
                break;
            case "3":
                Console.WriteLine("甲③");
                break;
            case "4":
                Console.WriteLine("甲④");
                break ;
            case "6":
                Console.WriteLine("乙①");
                break ;
            case "7":
                Console.WriteLine("乙②");
                break;
            case "8":
                Console.WriteLine("乙③");
                break;
            case "9":
                Console.WriteLine("乙④");
                break;
            case "b":
                Console.WriteLine("丙①");
                break;
            case "c":
                Console.WriteLine("丙②");
                break;
            case "d":
                Console.WriteLine("丙③");
                break;
            case "e":
                Console.WriteLine("丙④");
                break;
        }
    }
}
