using System;
namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
           
           object o1 = "x";
           object o2 = "y";
           object o3 = 5;
           object o4 = 2.1;


           //string ifadeler

           string str1 = string.Empty;
           str1 = "Cansel Gürsoy";
           string ad = "Cansel";
           string soyad = "Gürsoy";
           string tamisim = ad + "" + soyad;

            //integer tanımlama şekilleri

            int integer1 = 2;
            int integer2 = 5;
            int integer3 = integer1 * integer2;


            //boolean

            bool bool1 = 10>2;

            //değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeğer = str20 + int20.ToString();

            Console.WriteLine(yeniDeğer);


            int int21 =int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);


            //dateTime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //saat
            
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);







        }
    }
}


