using System;
using System.Threading.Tasks;
using System.Globalization;

public class Program{

    public static void  Main(string[] args)
    {

       
// Task 1
  
// int gun=int.Parse(Console.ReadLine());

// switch (gun){
//     case 1:
//     Console.WriteLine("Bazar ertəsi");
//     break;
//     case 2:
//     Console.WriteLine("Çərşənbə axşamı");
//     break;
//     case 3:
//     Console.WriteLine("Çərşənbə");
//     break;
//     case 4:
//     Console.WriteLine("Cümə axşamı");
//     break;
//     case 5:
//     Console.WriteLine("Cümə");
//     break;
//     case 6:
//     Console.WriteLine("Senbe");
//     break;
//     case 7:
//     Console.WriteLine("Bazar");
//     break;
//     default:
//     Console.WriteLine("Həftənin adı tapılmadı");
//     break;
//         }

// Task 2

// int ay=int.Parse(Console.ReadLine());
// switch (ay){
//     case 12:
//     case 1:
//     case 2:
//     Console.WriteLine("qis");
//     break;
//     case 3:
//     case 4:
//     case 5:
//     Console.WriteLine("Yaz");
//     break;
//     case 6:
//     case 7:
//     case 8:
//     Console.WriteLine("Yay");
//     break;
//     case 9:
//     case 10:
//     case 11:
//     Console.WriteLine("Payiz");
//     break;
//     default:
//     Console.WriteLine("Sehv daxil etdiniz");
//     break;
// }

//Task 4 Kalkulyator

// char emel =char.Parse(Console.ReadLine());
// int a=int.Parse(Console.ReadLine());
// int b=int.Parse(Console.ReadLine());
// switch (emel){
//     case '+' :
//     Console.WriteLine(a+b);
//     break;
//     case '-' :
//     Console.WriteLine(a-b);
//     break;
//     case '/' :
//     Console.WriteLine(a/b);
//     break;
//     case '*':
//     Console.WriteLine(a*b);
//     break;
//     default:
//     Console.WriteLine("Emelde yanlisliq var");
//     break;
// }
 
// TASK 5

// char eded=char.Parse(Console.ReadLine());
// switch(eded){
//     case 'A' :
//     Console.WriteLine("ELA");
//     break;
//     case 'B' :
//     Console.WriteLine("Yaxsi");
//     break;
//     case 'C' :
//     Console.WriteLine("Kafi");
//     break;
//     case 'D' :
//     Console.WriteLine("normal");
//     break;
//     case 'E' :
//     Console.WriteLine("Pis");
//     break;
//     case 'F' :
//     Console.WriteLine("berbad");
//     break;
//     default:
//     Console.WriteLine("Duzgun daxil edin");
//     break;
// }
 
// int a=int.Parse(Console.ReadLine());
// int b = a;
// int count = 0 ;
// while(a>0){
//     if (a%2!=0){
//         count += 1;
//         a /= 2;
//     }
// }
//  Console.WriteLine("Daxil edilmis eded: ");
// Console.WriteLine(b); 
//  Console.WriteLine("Ededdeki birlerin sayi "); 
//  Console.WriteLine(count);

// string password = "naile19";
// string try_password;
// while(true){
//     Console.WriteLine("Daxil edilmis eded: ");
//     try_password=Console.ReadLine();

// if (password == try_password ){
    
// Console.WriteLine("daxil oldunuz :)");
// break;
// }
// else {
// Console.WriteLine("tekrar sina :(");
// }
// }


// int eded =int.Parse(Console.ReadLine()); 
// int fact =1;
// // while(eded>0){
// //     fact = eded*fact;
// //     eded = eded - 1;
// // }
// // Console.WriteLine(fact);

// for (int i = eded; i>0; i--){
// fact = i* fact;
// }
//  Console.WriteLine(fact);




// loop task 2
// int n =int.Parse(Console.ReadLine()); 
// int s = 0;
// for(int i = 1; i<n; i+=2){
//  s += i;
// }
// Console.WriteLine(s);


// loop task 3
// string n =Console.ReadLine(); 
// int s = n.Length;
// int k = int.Parse(n);
// if(s>=1 && s<=6){
//     switch(s){
//         case 1:
//         for(int i = 0; i<10; i++){
//             Console.Write(i);
//             Console.Write(" ");
//         }
//         break;

//         case 2:
//         for(int i = 10; i<100; i++){
//             int sum = 0;
//             int j = i;
//             while(j>0){
//                 sum += (j%10);
//                 j /= 10;}
                
//             if (sum>0 && sum<= 54){
//                 Console.Write(sum);
//                 Console.Write(" ");
//             }}
//             break;

//             case 3:
//         for(int i = 100; i<1000; i++){
//             int sum = 0;
//             int j = i;
//             while(j>0){
//                 sum += (j%10);
//                 j /= 10;
//             }
//             if (sum>0 && sum<= 54){
//                 Console.Write(sum);
//                 Console.Write(" ");
//             }}
//             break;

//             case 4:
//         for(int i = 1000; i<10000; i++){
//             int sum = 0;
//             int j = i;
//             while(j>0){
//                 sum += (j%10);
//                 j /= 10;
//             }
//             if (sum>0 && sum<= 54){
//                 Console.Write(sum);
//                 Console.Write(" ");
//             }}
//             break;

//             case 5:
//         for(int i = 10000; i<100000; i++){
//             int sum = 0;
//             int j = i;
//             while(j>0){
//                 sum += (j%10);
//                 j /= 10;
//             }
//             if (sum>0 && sum<= 54){
//                 Console.Write(sum);
//                 Console.Write(" ");
//             }}
//             break;

//             case 6:
//         for(int i = 100000; i<1000000; i++){
//             int sum = 0;
//             int j = i;
//             while(j>0){
//                 sum += (j%10);
//                 j /= 10;
//             }
//             if (sum>0 && sum<= 54){
//                 Console.Write(sum);
//                 Console.Write(" ");
//             }}
//             break;
//             default:
//             Console.WriteLine("Alinmadi:(");
//             break;
//     }



//   }
//   else{
//     Console.WriteLine("alinmadi");
// }

// Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        int eded1 = 0;
//        int eded2 = 0;
//        if (n > 1 && n <= 6)
//        {
//            string ededs1 = "1", ededs2 = "1";

//            for (int i = 1; i < n; i++)
//            {
   
//                ededs1 += "0";
//                ededs2 += "0";
//            }

//            ededs2 += "0";

//            eded1 = int.Parse(ededs1.Trim());
//            eded2 = int.Parse(ededs2.Trim());
//        }

//        Console.Write("s = ");
//        int s = int.Parse(Console.ReadLine());
//        if (s>0 && s<= 54){
//        for(int i = eded1; i<eded2; i++){
//             int sum = 0;
//             int j = i;
//             while(j>0){
//                 sum += (j%10);
//                 j /= 10;
//             }
//             if (sum == s){
//                 Console.Write(i);
//                 Console.Write(" ");
//   }}}



// TASK 1
// string dateStr = Console.ReadLine();
// DateTime dt = DateTime.ParseExact(dateStr, "dd.MM.yyyy", null);
// Console.WriteLine(dt);
// Console.WriteLine("DayOfWeek - " + dt.DayOfWeek);


// TASK 2

// string dateStr = Console.ReadLine();
// DateTime dt2 = DateTime.ParseExact(dateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture);
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

  }}

