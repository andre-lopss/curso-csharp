using System;
using System.Globalization;

namespace CourseAula
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ////Inferência de tipo: palavra var
            Console.WriteLine("Inferência de tipo: palavra var ===============================");
            var v = 10;
            var y = 10.6;
            var z = "Maria";

            Console.WriteLine($"{v}, {y}, {z}");

            ////Switch Case
            Console.WriteLine("Switch Case ===============================");
            int dayIndex = int.Parse(Console.ReadLine());
            string day;
            switch (dayIndex)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);

            //Espressao ternária
            Console.WriteLine("Espressao ternária ===============================");       
            Console.Write("Digite o valor da compra: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine("Total a pagar: R$" + (preco - desconto).ToString("F2", CultureInfo.InvariantCulture) + ". Desconto de: R$:" + desconto.ToString("F2", CultureInfo.InvariantCulture));

            //Funções para String
            Console.WriteLine("Funções para String ===============================");
            string original = "abcde FGHIJ ABC abc DEFG    ";
            Console.WriteLine("ORIGINAL: -" + original + "-");
            Console.WriteLine("TO UPPER: -" + original.ToUpper() + "-");
            Console.WriteLine("TO LOWER: -" + original.ToLower() + "-");
            Console.WriteLine("TRIM: -" + original.Trim() + "-");
            Console.WriteLine("Index OF: -" + original.IndexOf("bc") + "-");
            Console.WriteLine("Last Index OF: -" + original.LastIndexOf("bc") + "-");
            Console.WriteLine("SUBSTRING(3): -" + original.Substring(3) + "-");
            Console.WriteLine("SUBSTRING(3, 5): -" + original.Substring(3, 5) + "-");
            Console.WriteLine("REPLACE(a, x): -" + original.Replace('a', 'x') + "-");
            Console.WriteLine("IsNullOrEmpty: -" + String.IsNullOrEmpty(original) + "-");
            Console.WriteLine("IsNullOrWhiteSpace: -" + String.IsNullOrWhiteSpace(original) + "-");

            //Datetime
            Console.WriteLine("Datetime ===============================");
            DateTime d1 = DateTime.Now; //recebe a hr atual
            DateTime d2 = new DateTime(2022, 11, 23);
            DateTime d3 = new DateTime(2022, 11, 20, 13, 42, 50);
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Parse("2000-08-15");
            DateTime d7 = DateTime.Parse("2000-08-15 13:05:08");
            DateTime d8 = DateTime.Parse("15/08/2022 13:05:08");
            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);

            //TimesSpan
            Console.WriteLine("TimesSpan ===============================");
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(0, 1, 30); // hora, minuto e segundo
            TimeSpan t4 = new TimeSpan(1, 23, 1, 30); // Dia, hora, minuto e segundo
            TimeSpan t5 = new TimeSpan(1, 23, 1, 30, 500); // Dia, hora, minuto segundo e milesegundo
            TimeSpan t6 = TimeSpan.FromDays(1.3);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.3);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);

            //Propriedades e operações com DateTime
            Console.WriteLine("Propriedades e operações com DateTime ===============================");
            DateTime d = new DateTime(1999, 10, 4, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            string ss1 = d.ToLongDateString();
            string ss2 = d.ToLongTimeString();
            string ss3 = d.ToShortDateString();
            string ss4 = d.ToShortTimeString();
            string ss5 = d.ToString();
            string ss6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string ss7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(ss1);
            Console.WriteLine(ss2);
            Console.WriteLine(ss3);
            Console.WriteLine(ss4);
            Console.WriteLine(ss5);
            Console.WriteLine(ss6);
            Console.WriteLine(ss7);

            //Operaçoes com DateTime

            Console.WriteLine("Operaçoes com DateTime ===============================");
            DateTime x = new DateTime(2000, 10, 4, 13, 45, 58, 275);
            DateTime y1 = x.AddDays(3);
            DateTime y2 = x.AddHours(2);
            DateTime y3 = x.AddMilliseconds(500);
            DateTime y4 = x.AddMinutes(2.5);
            DateTime y5 = x.AddMonths(1);
            DateTime y6 = x.AddSeconds(10);
            DateTime y7 = x.AddTicks(900000000L);
            DateTime y8 = x.AddYears(2);
            DateTime da1 = new DateTime(2000, 10, 08);
            DateTime da2 = new DateTime(2000, 12, 08);
            TimeSpan t = da2.Subtract(da1);

            //Operaçoes com TimeSpan

            Console.WriteLine("Operaçoes com TimeSpan ===============================");
            TimeSpan ttt = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(ttt);
            Console.WriteLine("Days: " + ttt.Days);
            Console.WriteLine("Hours: " + ttt.Hours);
            Console.WriteLine("Minutes: " + ttt.Minutes);
            Console.WriteLine("Milliseconds: " + ttt.Milliseconds);
            Console.WriteLine("Seconds: " + ttt.Seconds);
            Console.WriteLine("Ticks: " + ttt.Ticks);
            Console.WriteLine("TotalDays: " + ttt.TotalDays);
            Console.WriteLine("TotalHours: " + ttt.TotalHours);
            Console.WriteLine("TotalMinutes: " + ttt.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + ttt.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + ttt.TotalMilliseconds);            Console.WriteLine("===============================");
            TimeSpan tt11 = new TimeSpan(1, 30, 10);
            TimeSpan tt22 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t11.Add(tt22);
            TimeSpan dif = t11.Subtract(tt22);
            //TimeSpan mult = t22.Multiply(2.0);
            //TimeSpan div = t22.Divide(2.0);
            Console.WriteLine(tt11);
            Console.WriteLine(tt22);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);

            Console.WriteLine("===============================");

            DateTime d111 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d222= new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d333 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d111);
            Console.WriteLine("d1 Kind: " + d111.Kind);
            Console.WriteLine("d1 to Local: " + d111.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d111.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("d2: " + d222);
            Console.WriteLine("d2 Kind: " + d222.Kind);
            Console.WriteLine("d2 to Local: " + d222.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d222.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("d3: " + d333);
            Console.WriteLine("d3 Kind: " + d333.Kind);
            Console.WriteLine("d3 to Local: " + d333.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d333.ToUniversalTime());

            Console.WriteLine("================================================");
            DateTime dd1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime dd2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + dd1);
            Console.WriteLine("d1 Kind: " + dd1.Kind);
            Console.WriteLine("d1 to Local: " + dd1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + dd1.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("d2: " + dd2);
            Console.WriteLine("d2 Kind: " + dd2.Kind);
            Console.WriteLine("d2 to Local: " + dd2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + dd2.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine(dd2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(dd2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

            Console.ReadLine();
        }
    }
}
