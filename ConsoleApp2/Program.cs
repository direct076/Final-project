/*
 Створити програму для роботи Автозаправки у  режимах адміна та користувача
 У режимі адміна передбачити 	
	Поповнення заправки   пальним відповідного типу 
	Перегляд наявного пального кожного типу
	Зміна цін на пальне
	заправка кавового автомату
	Вилучення кешу(за пальне, за каву)
	Вивід статистики про продажі пального у літрах та грн.
	Вивід зароблених коштів(кожна  категорія окремо та сумарно)
У режимі користувача передбачити 		
	Заправка авто потрібним пальним( з видачею талона по оплаті)
		- на певну суму
		- певну кількість літрів
	замовлення кави
 */
using System.Diagnostics;
using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр. мови
Console.WriteLine("---------- Welcome to Gas Staton BDCM ----------");

Console.WriteLine("\tMENU:");
Console.WriteLine("\t0. Exit");
Console.WriteLine("\t1. Refill the petrol station with the appropriate type of fuel");
Console.WriteLine("\t2. View available fuel of each type");
Console.WriteLine("\t3. Save to file");
Console.WriteLine("\t4. Load from file");
Console.WriteLine("\t5. Delete fuel");
Console.WriteLine("\t6. Find Product");
Console.WriteLine("\t7. Change the price of fuel");
Console.WriteLine("\t8. Refuelling, a coffee machine");
Console.WriteLine("\t9. Cache withdrawal (for fuel, for coffee)");
Console.WriteLine("\t10. Display of statistics on fuel sales in litres and UAH.");
Console.WriteLine("\t11. Withdrawal of earned funds (each category separately and in total)");


while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 0:
            Environment.Exit(0);
            break;

        case 1:

            break;


        case 2:
           

            break;


        case 3:
           
            break;
        case 4:
           
            break;

        case 5:
           
            break;

        case 6:
          

           
            break;


    }



}
