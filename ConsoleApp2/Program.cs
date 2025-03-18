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
Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр. мови
Console.WriteLine("---------- Welcome to Gas Staton BDCM ----------");

Console.WriteLine("\tMENU:");
Console.WriteLine("\t1. Refill the petrol station with the appropriate type of fuel");
Console.WriteLine("\t2. View available fuel of each type");
Console.WriteLine("\t3. Change the price of fuel");
Console.WriteLine("\t4. Refuelling, a coffee machine");
Console.WriteLine("\t5. Cache withdrawal (for fuel, for coffee)");
Console.WriteLine("\t6. Display of statistics on fuel sales in litres and UAH.");
Console.WriteLine("\t7. Withdrawal of earned funds (each category separately and in total)");

Fuel fl = new();

while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter product name: ");
            fl.Type = Console.ReadLine();
            Console.Write("Enter product price: ");
            fl.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter product volume: ");
            fl.Volume = Convert.ToInt32(Console.ReadLine());
            break;


        case 2:
            Console.Write("Petlor");
            Console.Write("Gas");
            Console.Write("Disel");
            Console.Write("Bio-Disel");
            
            break;
    }
}
public class Fuel
{
    public string Type { get; set; }
    public double Price { get; set; }
    public double Volume { get; set; }
    
}