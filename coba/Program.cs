using System;
using System.ComponentModel;

namespace belajarCsharp
{
    class Program
    {
        // deklarasi variable

        static string kasir, password, pelanggan;
        static int total_harga, Tunai, Kembalian;
        //deklarasi array 
        static string[] menu = { "AYAM", "IKAN", "RENDANG SAPI", "KOPI", "TEH", "AIR MINERAL" };
        static int[] jumlah_pesanan = { 0, 0, 0, 0, 0, 0 };
        static int[] harga_menu = { 15000, 25000, 35000, 7000, 6000, 5000 };
        //deklarasi variable
        static int jumlah1, hargamenu1;
        static int jumlah2, hargamenu2;
        static int jumlah3, hargamenu3;
        static int jumlah4, hargamenu4;
        static int jumlah5, hargamenu5;
        static int jumlah6, hargamenu6;



        static void Main(string[] args)
        {
            MenuAplikasi();
            Input();
            TampilanMenu();


        }

        static void MenuAplikasi()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("     SELAMAT DATANG DAN SELAMAT MENIKMATI   ");
            Console.WriteLine("           WARUNG MAKAN SEDERHANA           ");
            Console.WriteLine("============================================");
            Console.WriteLine("");
            Console.WriteLine("1.MENU LOGIN");
            Console.WriteLine("2.ABOUT ME");

            Console.Write("PILIH MENU = ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    Login();
                    break;
                case 2:
                    Console.WriteLine("MESIN KASIR INI UNTUK WARUNG MAKAN SEDERHANA DAN MEMUDAHKAN DALAM HAL TRANSAKSI");
                    Console.WriteLine("");
                    Console.WriteLine("ENTER UNTUK PILIH MENU LAGI");
                    Console.ReadLine();
                    Console.Clear();
                    BackMenuAplikasi();
                    break;

            }

        }


        static void Login()
        {
            Console.Clear();
            //username = rony , password = 123
            Console.WriteLine("=============================");
            Console.WriteLine("Masukan Username dan Password");
            Console.WriteLine("=============================");
            Console.Write("Username : ");
            kasir = Console.ReadLine();
            Console.Write("Password : ");
            password = Console.ReadLine();

            if (kasir == "rony" && password == "123")
            {
                Console.WriteLine("LOGIN BERHASIL !!!");
                Input();

            }
            else
            {
                Console.WriteLine("LOGIN GAGAL!!!");
                Console.WriteLine("Username atau password salah!!!");
                Console.WriteLine("");
                Console.WriteLine("ENTER UNTUK COBA LAGI");
                Console.ReadLine();
                Console.Clear();
                BackLogin();
            }



        }


        static void Input()
        {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("SELAMAT DATANG DI WARUNG MAKAN SEDERHANA ");
            Console.WriteLine("       MENU INPUT NAMA PELANGGAN         ");
            Console.WriteLine("=========================================");
            Console.WriteLine("");
            Console.WriteLine("SILAHKAN KAK " + kasir + " INPUT NAMA PELANGGAN");
            //Display masukan nama pelangan
            Console.Write("Masukan Nama Pelanggan : ");

            pelanggan = Console.ReadLine();
            TampilanMenu();

        }

        static void TampilanMenu()
        {
            Console.Clear();
            int pilih;
            do
            {
                //Tampilan Menu
                Console.WriteLine("============================================");
                Console.WriteLine("     SELAMAT DATANG DAN SELAMAT MENIKMATI   ");
                Console.WriteLine("           WARUNG MAKAN SEDERHANA           ");
                Console.WriteLine("============================================");
                Console.WriteLine("");
                Console.WriteLine("============ MENU PESANAN ==================");
                Console.WriteLine("1. AYAM                   Rp.15000");
                Console.WriteLine("2. IKAN                   Rp.25000");
                Console.WriteLine("3. RENDANG SAPI           Rp.35000");
                Console.WriteLine("4. KOPI                   Rp.7000 ");
                Console.WriteLine("5. TEH                    Rp.6000 ");
                Console.WriteLine("6. AIR MINERAL            Rp.5000 ");
                Console.WriteLine("7. SELESAI");
                Console.WriteLine("");
                Console.Write("SILAHKAN PILIH MENU =  ");
                //Pilih Menu
                pilih = Convert.ToInt32(Console.ReadLine());
                switch (pilih)
                {
                    case 1:
                        Ayam();
                        Console.WriteLine();
                        break;
                    case 2:
                        Ikan();
                        Console.WriteLine();
                        break;
                    case 3:
                        RendangSapi();
                        Console.WriteLine();
                        break;
                    case 4:
                        Kopi();
                        Console.WriteLine();
                        break;
                    case 5:
                        Teh();
                        Console.WriteLine();
                        break;
                    case 6:
                        AirMineral();
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.Clear();
                        Pembayaran();
                        break;
                }

            } while (pilih < 7);
            {
                StrukPembayaran();
            }

        }


        static void Ayam()
        {

            //display jumlah pesanan
            Console.Write("Jumlah menu Ayam : ");
            jumlah1 = Convert.ToInt32(Console.ReadLine());

            hargamenu1 = jumlah1 * harga_menu[0];
            Console.WriteLine("Pesanan berhasil disimpan");

            //update harga total
            jumlah_pesanan[0] += hargamenu1;
        }
       static void Ikan()
        {

            //display jumlah pesanan
            Console.Write("Jumlah menu Ikan : ");
            jumlah2 = Convert.ToInt32(Console.ReadLine());

            hargamenu2 = jumlah2 * harga_menu[1];
            Console.WriteLine("Pesanan berhasil disimpan");

            //update harga total
            jumlah_pesanan[1] += hargamenu2;
        }
        static void RendangSapi()
        {

            //display jumlah pesanan
            Console.Write("Jumlah menu Rendang Sapi : ");
            jumlah3 = Convert.ToInt32(Console.ReadLine());

            hargamenu3 = jumlah3 * harga_menu[2];
            Console.WriteLine("Pesanan berhasil disimpan");

            //update harga total
            jumlah_pesanan[2] += hargamenu3;
        }

        static void Kopi()
        {

            //display jumlah pesanan
            Console.Write("Jumlah menu Kopi : ");
            jumlah4 = Convert.ToInt32(Console.ReadLine());

            hargamenu4 = jumlah4 * harga_menu[3];
            Console.WriteLine("Pesanan berhasil disimpan");

            //update harga total
            jumlah_pesanan[3] += hargamenu4;
        }

        static void Teh()
        {

            //display jumlah pesanan
            Console.Write("Jumlah menu Teh : ");
            jumlah5 = Convert.ToInt32(Console.ReadLine());

            hargamenu5 = jumlah5 * harga_menu[4];
            Console.WriteLine("Pesanan berhasil disimpan");

            //update harga total
            jumlah_pesanan[4] += hargamenu5;
        }

        static void AirMineral()
        {

            //display jumlah pesanan
            Console.Write("Jumlah menu Teh : ");
            jumlah6 = Convert.ToInt32(Console.ReadLine());

            hargamenu6 = jumlah6 * harga_menu[5];
            Console.WriteLine("Pesanan berhasil disimpan");

            //update harga total
            jumlah_pesanan[5] += hargamenu6;
        }

        static int TotalHarga() {

            //membaca array dengan perulangn for
            for (int i = 0; i < 6; i++)
            {
               
                if (jumlah_pesanan[i] > 0)
                {
                    int jmlh_beli = jumlah_pesanan[i] / harga_menu[i];
                    Console.WriteLine(menu[i] + "\tx " + jmlh_beli + "\t\tRp. " + jumlah_pesanan[i].ToString());

                    //update harga total
                    total_harga += jumlah_pesanan[i];

                }
            }return total_harga;
           
        }
        static void TotalBayar() {
            do
            {
                Console.Write("Bayar\t\t\t\tRp. ");
                Tunai = Convert.ToInt32(Console.ReadLine());
               
            } while (Tunai < total_harga);
            if (Tunai > total_harga)
            {
                Kembalian = Tunai - total_harga;
            }

        }
        static void Pembayaran()
        {
            Console.Clear();
            Console.WriteLine("======== PEMBAYARAN ==========");
            Console.WriteLine("Menu\t\tJumlah\t\tTotal Harga");
            Console.WriteLine("=============================");


            TotalHarga();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Total Harga \t\t\t Rp.{0}", total_harga);
            TotalBayar();
           
            Console.WriteLine("Kembalian\t\t\tRp. {0}", Kembalian);
            Console.WriteLine("");
            Console.WriteLine(" Transaksi Berhasil !");
            Console.ReadLine();
        }

        static void StrukPembayaran()
        {
            Console.Clear();
            //Struk Pembayaran
            Console.WriteLine("======================================");
            Console.WriteLine("========== STRUK PEMBAYARAN ==========");
            Console.WriteLine("========== WARUNG KOPI RONY ==========");
            Console.WriteLine("======================================");
            Console.WriteLine("");
            Console.WriteLine("Kasir    : {0}", kasir);
            Console.WriteLine("Pelanggan : {0}", pelanggan);
            Console.WriteLine("");
            Console.WriteLine("Menu\t\t\tJumlah\t\tTotal Harga");
            Console.WriteLine("============================");

            for (int i = 0; i < 6; i++)
            {
                if (jumlah_pesanan[i] > 0)
                {
                    int jmlh_beli = jumlah_pesanan[i] / harga_menu[i];
                    Console.WriteLine(menu[i] + "\t\tx " + jmlh_beli + "\t\t\t Rp. " + jumlah_pesanan[i].ToString());
                }
            }

            Console.WriteLine("\t\t\t\tTotal Harga\t Rp.{0}", total_harga);
            Console.WriteLine("\t\t\t\tTunai\t\t Rp.{0}", Tunai);
            Console.WriteLine("\t\t\t\tKembalian\t Rp.{0}", Kembalian);
            Console.WriteLine("");
            Console.WriteLine("======================================");
            Console.WriteLine("TERIMA KASIH TELAH MAKAN DAN MINUM DIWARUNG KAMI");
            Console.WriteLine("SELAMAT MENIKMATI DAN SEHAT SELALU UNTUK ANDA");
            Console.WriteLine("======================================");
            Console.WriteLine("");
            Console.WriteLine("BACK TAMPILAN MENU HIDANGAN <  TEKAN ENTER");
            Console.ReadLine();


        }

        static void BackTampilanMenu()
        {
            TampilanMenu();

        }
        static void BackMenuAplikasi()
        {
            MenuAplikasi();

        }
        static void BackLogin()
        {
            Login();
        }

        ///////////
    }
}
