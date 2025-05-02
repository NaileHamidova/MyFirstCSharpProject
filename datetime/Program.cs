using System;
using System.Threading.Tasks;
using System.Globalization;
public class Program{
    public static void  Main(string[] args)
    {


// TASK 1
// string dateStr = Console.ReadLine();
// DateTime dt = DateTime.ParseExact(dateStr, "dd.MM.yyyy", null);
// Console.WriteLine(dt);
// Console.WriteLine("DayOfWeek - " + dt.DayOfWeek);


// TASK 2

// string dateStr = Console.ReadLine();
// DateTime dt2 = DateTime.ParseExact(dateStr, "dd.MM.yyyy", null);
// DateTime dt =DateTime.Now;
// TimeSpan res = dt - dt2;
// Console.WriteLine(res.Days);


// TASK 3

// DateTime dt =DateTime.Now;
// Console.WriteLine(dt.ToString("dd.MM.yyyy")); 
// Console.WriteLine(dt.DayOfWeek); 
// Console.WriteLine(dt.AddDays(40).ToString("dd.MM.yyyy")); 
// Console.WriteLine(dt.AddDays(40).DayOfWeek); 


// TASK 4

// string dtday = Console.ReadLine();
// string dtmonth = Console.ReadLine();
// string dtyear = Console.ReadLine();
// string dt = dtday + "." + dtmonth + "." + dtyear;
// DateTime dtnow = DateTime.Now;
// DateTime dt2 = DateTime.ParseExact(dt, "dd.MM.yyyy", null);
// if ((dtnow.ToShortDateString()) == (dt2.ToShortDateString())){
//     Console.WriteLine("true");
//     }
// else{
//     Console.WriteLine("false");
//     }


// TASK 5 SEHVDIR niye bilmirem

// string dtday = Console.ReadLine();
// string dtmonth = Console.ReadLine();
// string dtyear = Console.ReadLine();
// string dt = dtday + "." + dtmonth + "." + dtyear;
// DateTime dt2 = DateTime.ParseExact(dt, "dd.MM.yyyy", null);
// System.Console.WriteLine("Cari tarix: " + dt2.ToShortDateString());
// while (dt2.DayOfWeek == DayOfWeek.Sunday){
//     if(dt2.DayOfWeek != DayOfWeek.Sunday){
//     dt2 = dt2.AddDays(1);}
// }
// System.Console.WriteLine("Cari tarixde Bazar gunu : " + dt2.ToShortDateString());



// TASK 6

// System.Console.WriteLine("Birinci tarix: ");
// string dtday = Console.ReadLine();
// string dtmonth = Console.ReadLine();
// string dtyear = Console.ReadLine();
// string dt = dtday + "." + dtmonth + "." + dtyear;
// DateTime dt2 = DateTime.ParseExact(dt, "dd.MM.yyyy", CultureInfo.InvariantCulture);
// System.Console.WriteLine("Ikinci tarix: ");
// string dtday1 = Console.ReadLine();
// string dtmonth1 = Console.ReadLine();
// string dtyear1 = Console.ReadLine();
// string dt3 = dtday1 + "." + dtmonth1 + "." + dtyear1;
// DateTime dt4 = DateTime.ParseExact(dt3, "dd.MM.yyyy", CultureInfo.InvariantCulture);
// if(dt2>dt4){
//     TimeSpan res = dt2 - dt4;
//     Console.WriteLine(res.Days);
// }
// else{
//     TimeSpan res = dt4 - dt2;
//     Console.WriteLine(res.Days);
//     }



// // TASK 7
// System.Console.WriteLine("indinin tarixi: ");
// string dtday = Console.ReadLine();
// string dtmonth = Console.ReadLine();
// string dtyear = Console.ReadLine();
// string dt = dtday + "." + dtmonth + "." + dtyear;
// DateTime dt2 = DateTime.ParseExact(dt, "dd.MM.yyyy", CultureInfo.InvariantCulture);
// System.Console.WriteLine("gelcekdeki hadisenin tarixi tarix: ");
// string dtday1 = Console.ReadLine();
// string dtmonth1 = Console.ReadLine();
// string dtyear1 = Console.ReadLine();
// string dt3 = dtday1 + "." + dtmonth1 + "." + dtyear1;
// DateTime dt4 = DateTime.ParseExact(dt3, "dd.MM.yyyy", CultureInfo.InvariantCulture);
// if(dt4>dt2){
//     TimeSpan res = dt4 - dt2;
//     Console.WriteLine(res.Days);
// }
// else{
//     Console.WriteLine("Daxil etdiyiniz tarix yanlisdir!");
//     }

// TASK 8

System.Console.WriteLine("Baslama tarixi: ");
string dtday = Console.ReadLine();
string dtmonth = Console.ReadLine();
string dtyear = Console.ReadLine();
string dthours = Console.ReadLine();
string dtminutes = Console.ReadLine();
string dt = $"{dtday}.{dtmonth}.{dtyear} {dthours}:{dtminutes}";
DateTime dt2 = DateTime.ParseExact(dt, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
System.Console.WriteLine("Bitme tarixi: ");
string dtday1 = Console.ReadLine();
string dtmonth1 = Console.ReadLine();
string dtyear1 = Console.ReadLine();
string dthours1 = Console.ReadLine();
string dtminutes1 = Console.ReadLine();
string dt3 = $"{dtday1}.{dtmonth1}.{dtyear1} {dthours1}:{dtminutes1}";
DateTime dt4 = DateTime.ParseExact(dt3, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
if(dt2>dt4){
    TimeSpan res = dt2 - dt4;
    Console.WriteLine("Tedbir" + res.Hours + "saat davam edecek");
}
else{
    TimeSpan res = dt4 - dt2;
    Console.WriteLine("Tedbir" + res.Hours + "saat davma edecek");
    }


}}

        