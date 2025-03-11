using modul4_103022300043;

KodeProduk[] listKodeProduk = new KodeProduk[10];

listKodeProduk[0] = new KodeProduk("Laptop", "E100");
listKodeProduk[1] = new KodeProduk("Smartphone", "E101");
listKodeProduk[2] = new KodeProduk("Tablet", "E102");
listKodeProduk[3] = new KodeProduk("Headset", "E103");
listKodeProduk[4] = new KodeProduk("Keyboard", "E104");
listKodeProduk[5] = new KodeProduk("Mouse", "E105");
listKodeProduk[6] = new KodeProduk("Printer", "E106");
listKodeProduk[7] = new KodeProduk("Monitor", "E107");
listKodeProduk[8] = new KodeProduk("Smartwatch", "E108");
listKodeProduk[9] = new KodeProduk("Kamera", "E109");

Console.WriteLine("Produk Elektronik | Kode Produk ");


foreach (KodeProduk kodeProduk in listKodeProduk)
{
    if (kodeProduk.produkElektronik.Length > 7)
    {
        Console.WriteLine(kodeProduk.produkElektronik + "\t\t" + kodeProduk.getKodeProduk());
    }
    else
    {
        Console.WriteLine(kodeProduk.produkElektronik + "\t\t\t" + kodeProduk.getKodeProduk());
    }
}

Console.WriteLine("\n");

FanLaptop fanLaptop = new FanLaptop();

fanLaptop.kecepatanFan();
fanLaptop.turboShortcut();
fanLaptop.kecepatanFan();
fanLaptop.turboShortcut();
fanLaptop.kecepatanFan();
fanLaptop.kecepatanUp();
fanLaptop.kecepatanFan();
fanLaptop.kecepatanUp();
fanLaptop.kecepatanFan();
fanLaptop.kecepatanDown();
fanLaptop.kecepatanFan();