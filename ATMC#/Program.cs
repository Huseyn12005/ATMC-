using ATMC_;



BankCard bankCard1 = new BankCard("KapitalBank","Huseyn148","1234567812345678","1234",2030,9);
BankCard bankCard2 = new BankCard("AtaBank", "Ali123", "8765432112345678", "2005", 2027, 5);
BankCard bankCard3 = new BankCard("PashaBank", "Xeyal123", "9182736464738291", "1945", 2026, 3);
BankCard bankCard4 = new BankCard("LeoBank", "Hikmet123", "4321876556781234", "2732", 2028, 11);
BankCard bankCard5 = new BankCard("AccessBank", "Hidayet123", "1092834746574123", "2222", 2035, 1);

Client client1 = new Client("Huseyn","Orucov",18,bankCard1);
Client client2 = new Client("Ali", "Aliyev", 16, bankCard2);
Client client3 = new Client("Xeyal", "Melikov", 20, bankCard3);
Client client4 = new Client("Hikmet", "Hikmetli", 15, bankCard4);
Client client5 = new Client("Hidayet", "Memmedli", 16, bankCard5);

Client[] clients = new Client[5] { client1, client2, client3, client4, client5 };


Dictionary<DateTime,string> emeliyatlar = new Dictionary<DateTime,string>();   


string[] menu = { "Balance","Nagd Pul", "Edilen emeliyyatlarin siyahisi", "Kartdan karta kocurme","Diger Kartlarin Balansini yoxlamaq" };
string[] emeliyyat = { "10 AZN", "20 AZN", "50 AZN","100 AZN", "Diger" };
int choice_menu = 0;
int choice_emeliyyat = 0;
bool a = true;
bool b = true;
bool c = true;
bool d = true;
int Current_Client = 0;

do
{
    Console.Clear();
    Console.Write("                                                        ");
    Console.Write("Please enter PIN code : ");
    string? PIN_ = Console.ReadLine();
    Console.Clear();

    for (int i = 0; i < 5;i++)
    {
        if (clients[i].Card.Pin == PIN_)
        {
            Current_Client = i;
            Console.Write("                         ");
            Console.Write($"{clients[i].Name} {clients[i].Surname} xos gelmisiniz zehmet olmasa asagidakilardan birini secin");
            a = false;
            break;
        }
    }
    if(a == true)
    {
        Console.WriteLine("Bu PIN-e uygun Client tapilmadi(Press any button for continue)");
        Console.ReadKey();
    }

} while (a);

do
{
    if (a == false)
    {
        a = true;
    }
    else
        Console.Clear();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine();
    for (int i = 0; i < menu.Length; i++)
    {
        if (choice_menu == i)
        {
            Console.Write("                                                        ");
            Console.Write("-> ");
        }
        else
        {
            Console.Write("                                                        ");
            Console.Write("   ");
        }

        Console.WriteLine(menu[i]); ;
    }

    ConsoleKeyInfo choice = Console.ReadKey();

    switch (choice.Key)
    {
        case ConsoleKey.UpArrow:
            if (choice_menu == 0)
                choice_menu = 4;
            else
                --choice_menu;
            break;

        case ConsoleKey.DownArrow:
            if (choice_menu == 4)
                choice_menu = 0;
            else
                ++choice_menu;
            break;

        case ConsoleKey.Enter:
            if (choice_menu == 0)
            {
                Console.Clear();
                Console.Write("                                                        ");
                Console.WriteLine($"Your current balance : {clients[Current_Client].Card.balance} AZN");
                Console.WriteLine("Press any button for continue...");
                Console.ReadKey();
            }

            else if (choice_menu == 1)
            {
                do {
                b = true;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine();
                for (int i = 0; i < emeliyyat.Length; i++)
                {
                    if (choice_emeliyyat == i)
                    {
                        Console.Write("                                                        ");
                        Console.Write("-> ");
                    }
                    else
                    {
                        Console.Write("                                                        ");
                        Console.Write("   ");
                    }

                    Console.WriteLine(emeliyyat[i]); ;
                }

                ConsoleKeyInfo choice_em = Console.ReadKey();

                    switch (choice_em.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (choice_emeliyyat == 0)
                                choice_emeliyyat = 4;
                            else
                                --choice_emeliyyat;
                            break;

                        case ConsoleKey.DownArrow:
                            if (choice_emeliyyat == 4)
                                choice_emeliyyat = 0;
                            else
                                ++choice_emeliyyat;
                            break;

                        case ConsoleKey.Enter:
                            if (choice_emeliyyat == 0)
                            {
                                Console.Clear();
                                if (clients[Current_Client].Card.balance < 10)
                                {
                                    Console.WriteLine("Kartda kifayet qeder balans yoxdur");
                                }
                                else
                                {
                                    clients[Current_Client].Card.balance -= 10;
                                    Console.WriteLine("Emeliyyat ugurla yerine yetirildi");
                                    emeliyatlar.Add(DateTime.Now, "+10 Azn");
                                }
                                Console.WriteLine("Press any button for continue...");
                                Console.ReadKey();
                            }
                            else if (choice_emeliyyat == 1)
                            {
                                Console.Clear();
                                if (clients[Current_Client].Card.balance < 20)
                                {
                                    Console.WriteLine("Kartda kifayet qeder balans yoxdur");
                                }
                                else
                                {
                                    clients[Current_Client].Card.balance -= 20;
                                    Console.WriteLine("Emeliyyat ugurla yerine yetirildi");
                                    emeliyatlar.Add(DateTime.Now, "+20 Azn");
                                }
                                Console.WriteLine("Press any button for continue...");
                                Console.ReadKey();
                            }
                            else if (choice_emeliyyat == 2)
                            {
                                Console.Clear();
                                if (clients[Current_Client].Card.balance < 50)
                                {
                                    Console.WriteLine("Kartda kifayet qeder balans yoxdur");
                                }
                                else
                                {
                                    clients[Current_Client].Card.balance -= 50;
                                    Console.WriteLine("Emeliyyat ugurla yerine yetirildi");
                                    emeliyatlar.Add(DateTime.Now, "+50 Azn");
                                }
                                Console.WriteLine("Press any button for continue...");
                                Console.ReadKey();
                            }
                            else if (choice_emeliyyat == 3)
                            {
                                Console.Clear();
                                if (clients[Current_Client].Card.balance < 100)
                                {
                                    Console.WriteLine("Kartda kifayet qeder balans yoxdur");
                                }
                                else
                                {
                                    clients[Current_Client].Card.balance -= 100;
                                    Console.WriteLine("Emeliyyat ugurla yerine yetirildi");
                                    emeliyatlar.Add(DateTime.Now, "+100 Azn");
                                }
                                Console.WriteLine("Press any button for continue...");
                                Console.ReadKey();
                            }
                            else if (choice_emeliyyat == 4)
                            {
                                Console.Clear();
                                Console.Write("Pulu daxil edin: ");
                                int nagd;
                                bool netice = int.TryParse(Console.ReadLine(), out nagd);
                                if (netice == true)
                                {
                                    Console.Clear();
                                    if (clients[Current_Client].Card.balance < nagd)
                                    {
                                        Console.WriteLine("Kartda kifayet qeder balans yoxdur");
                                    }
                                    else
                                    {
                                        clients[Current_Client].Card.balance -= nagd;
                                        Console.WriteLine("Emeliyyat ugurla yerine yetirildi");
                                        emeliyatlar.Add(DateTime.Now, $"+{nagd} Azn");
                                    }
                                    Console.WriteLine("Press any button for continue...");
                                    Console.ReadKey();
                                }
                                else
                                    throw new Exception("Ancaq eded daxil olunmalidir !!!");
                            }
                            b = false;
                            break;
                    }
                } while (b) ;

            }

            else if(choice_menu == 2)
            {
                Console.Clear();
                foreach (var item in emeliyatlar)
                {
                    Console.WriteLine($"Data: {item.Key}\nEmeliyyat: {item.Value}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("Press any button for continue...");
                Console.ReadKey();
            }

            else if(choice_menu == 3)
            {
                do
                {
                    Console.Clear();
                    Console.Write("                                     ");
                    Console.Write("Pul gondermek istediyiniz kartin PIN-in daxil edin : ");
                    string? PIN_ = Console.ReadLine();
                    Console.Clear();

                    for (int i = 0; i < 5; i++)
                    {
                        if (clients[i].Card.Pin == PIN_)
                        {
                            Console.Clear();
                            Console.Write("Pulu daxil edin: ");
                            int nagd;
                            bool netice = int.TryParse(Console.ReadLine(), out nagd);
                            if (netice == true)
                            {
                                clients[Current_Client].Card.balance -= nagd;
                                clients[i].Card.balance += nagd;
                                Console.WriteLine("Emeliyyat ugurla yerine yetirildi");
                                Console.WriteLine("Press any button for continue...");
                                Console.ReadKey();
                                emeliyatlar.Add(DateTime.Now, $"+{nagd} Azn to {clients[i].Card.Pin} Card PIN");
                            }
                            else
                                throw new Exception("Ancaq eded daxil olunmalidir !!!");

                            c = false;
                            break;
                        }
                    }
                    if (c == true)
                    {
                        Console.WriteLine("Bu PIN-e uygun Client tapilmadi(Press any button for continue)");
                        Console.ReadKey();
                    }

                } while (c);
            }

            else if(choice_menu == 4)
            {
                do
                {
                    Console.Clear();
                    Console.Write("                                     ");
                    Console.Write("Balansini yoxlamaq istediyiniz kartin PIN-in daxil edin : ");
                    string? PIN_ = Console.ReadLine();
                    Console.Clear();

                    for (int i = 0; i < 5; i++)
                    {
                        if (clients[i].Card.Pin == PIN_)
                        {
                            Console.Clear();
                            Console.Write("                                            ");
                            Console.WriteLine($"{clients[i].Card.Pin} Card's current balance : {clients[i].Card.balance} AZN");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Press any button for continue...");
                            Console.ReadKey();
                            d = false;
                            break;
                        }
                    }
                    if (d == true)
                    {
                        Console.WriteLine("Bu PIN-e uygun Client tapilmadi(Press any button for continue)");
                        Console.ReadKey();
                    }

                } while (d);

            }

 
            break;



    }
    if (choice.Key == ConsoleKey.Escape)
        break;


} while (true);
