using System.Drawing;
using Task_Menu;
using Colorful;
using Console = Colorful.Console;
#region LogoConsole
string Logo_Menu = @"
-----------------------------|   Hot Drinks   |---------------------------------
--------------------------------------------------------------------------------
| Number |      Name       |      Price      |      Size      |      Status    |
--------------------------------------------------------------------------------";
string Logo_Menu2 = @"
----------------------------|   Cold drinks   |---------------------------------
--------------------------------------------------------------------------------
| Number |      Name       |      Price      |      Size      |      Status    |";
string LogoLogin = @"_________________________________
  / /  ___   __ _(_)_ __      
 / /  / _ \ / _` | | '_ \     
/ /__| (_) | (_| | | | | |  _ _ 
\____/\___/ \__, |_|_| |_| (_||_)
___________ |___/";
string LogoWelcom = @" __    __     _                              ___            _    
/ / /\ \ \___| | ___ ___  _ __ ___   ___    / __\ __ _  ___| | __
\ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \  /__\/// _` |/ __| |/ /
 \  /\  /  __/ | (_| (_) | | | | | |  __/ / \/  \ (_| | (__|   < 
  \/  \/ \___|_|\___\___/|_| |_| |_|\___| \_____/\__,_|\___|_|\_\
--------------------------------------------------------------------------------";
#endregion 
#region String      
String JD = " JD";
#endregion
#region Start  

#endregion
#region List_Menu
List<Menu> menu_List = new List<Menu>
{
    new Menu
    {
        id = 1 , name = "Al Ameed        " , price = 0.5, size = "medium"  ,status = true
    },
    new Menu
    {
        id = 2 , name = "Arabic Coffee   " , price = 0.5, size = "medium"  ,status = true

    },
     new Menu
    {
        id = 3 , name = "Jordanian Tea   " , price = 0.5,size = "medium"  ,status = true
    },
      new Menu
    {
         id = 4 , name = "American Coffee " , price = 0.5 ,size = "medium"  ,status = false 
    },
        new Menu
    {
        id = 5 , name = "Hot Chocolate   " , price = 0.5 ,size = "medium"  ,status = true
    },
        new Menu
    {
       id = 6 , name = "Turkish Coffee  " , price = 0.6,  size = "medium"  , status = true
    },
};
List<Menu> menu_List1 = new List<Menu>
{
    new Menu
    {
        id = 7    ,   name = "Matrix drink" , size= "250 ml    ", price = 0.55  , status = true ,
    },
    new Menu
    {
        id = 8 ,      name = "Coca-Cola   " , size= "330 ml    ", price = 0.55,   status = false,
    },
     new Menu
    {
        id = 9 ,      name = "Shani       " , size= "500 ml    ", price = 0.75,  status = true,
    },
      new Menu
    {
        id = 10 ,     name = "Rani        " , size= "330 ml    ", price = 0.75,  status = true,
    },
        new Menu
    {
        id = 11 ,     name = "Freez       " , size= "1.5 liters", price = 0.75,  status = true,
    },
        new Menu
    {
        id = 12 ,     name = "Fayrouz     " , size= "500 ml    ", price = 0.75,  status = true,
    },
};
List<Login> log = new List<Login>
{

    new Login
    {
        username = "Admin", password = "Admin"
    },
};
List<Home> home = new List<Home>
{
    new Home ("[1] Drinks menu","Drinks menu",["[1]"] , "1"),
    new Home ("[2] search","search",["2"] , "2"),
    new Home ("[3] Add Item","Add Etim",["3"] , "3"),
};
#endregion
#region MsgBox
string successfully = "logged in successfully";
string Continue = "Login...";
#endregion 
Console.Write(LogoLogin, Color.AliceBlue );
Console.Write("UserName :", Color.AliceBlue);
Console.ForegroundColor = Color.AliceBlue;
string  user  = Console.ReadLine();
Console.Write("________________ password :", Color.AliceBlue);
string pass = Console.ReadLine();
bool isAuthenticated = false;
foreach (var Login in log)
{
    if (user == Login.username && pass == Login.password)
    {
        isAuthenticated = true;
        break;
    }
}
if (isAuthenticated)
{
    #region Timer{++} 


    var cancellationTokenSource = new CancellationTokenSource();
    var loadingTask = Task.Run(() => ShowLoading(cancellationTokenSource.Token));


    SimulateLongProcess();


    cancellationTokenSource.Cancel();
    loadingTask.Wait();
    Console.WriteLine("Process completed.", Color.Lime);
    static void ShowLoading(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            for (int i = 0; i < 4; i++)
            {
                if (token.IsCancellationRequested)
                    break;
                Console.Write("\rLoading" + new string('.', i), Color.Gray);
                Thread.Sleep(500);
            }
        }


        Console.Write("\r                    \r");
    }

    static void SimulateLongProcess()
    {

        Thread.Sleep(5000);
    }

    Console.WriteLine(successfully, Color.Green);
    Console.Read();
    #endregion



    while (true)
    {
        Console.Clear();
        Console.WriteLine(LogoWelcom, Color.DodgerBlue);
        foreach (var _home in home)
        {
            Console.WriteLine(_home.menu1, _home.menu2, _home.menu4, Color.Transparent);
        }

        string number = Console.ReadLine();
        switch (number)
        {
            case "1":
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(Logo_Menu);
                    foreach (var Menus in menu_List)
                    {
                        string status = Menus.status ? "available    " : "not available";
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        Console.WriteLine("    " + Menus.id + "      " + Menus.name + "          " + Menus.price + " ." + JD + "        " + Menus.size + "        " + status);
                    }
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine(Logo_Menu2);
                    foreach (var Menus2 in menu_List1)
                    {

                        string status1 = Menus2.status ? "available    " : "not available";
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        Console.WriteLine("    " + Menus2.id + "      " + Menus2.name + "          " + Menus2.price + " ." + JD + "        " + Menus2.size + "      " + status1);
                    }
                    Console.WriteLine("Type '<' to go the main menu.");
                    string backCommand = Console.ReadLine();
                    if (backCommand == "<") break;
                }
                break;

            case "2":

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the first two letters of the drink to search:");
                    string searchName = Console.ReadLine().ToLower();
                    bool found = false;

                    var allMenus = menu_List.Concat(menu_List1).ToList();

                    foreach (var Menus in allMenus)
                    {
                        if (Menus.name.Trim().ToLower().StartsWith(searchName))
                        {
                            string status = Menus.status ? "available" : "not available";
                            Console.WriteLine(Logo_Menu2);
                            Console.WriteLine("--------------------------------------------------------------------------------");
                            Console.WriteLine("    " + Menus.id + "      " + Menus.name + "       " + Menus.price + "" + JD + "            " + Menus.size + "        " + status);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("drink not found.");
                    }

                    Console.WriteLine("Type '<' to go the main menu.");
                    string backCommand = Console.ReadLine();
                    if (backCommand == "<") break;
                }
                break;
            case "3":
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("enter the name of the drink to add:");
                    string newName = Console.ReadLine();
                    Console.WriteLine("enter the size of the drink:");
                    string newSize = Console.ReadLine();
                    Console.WriteLine("enter the price of the drink:");
                    if (!double.TryParse(Console.ReadLine(), out double newPrice))
                    {
                        Console.WriteLine("Invalid price. Operation aborted.");
                        break;
                    }
                    Console.Write("Is the drink available? (yes/no):");
                    string availabilityInput = Console.ReadLine();
                    bool newStatus = availabilityInput.Equals("yes", StringComparison.OrdinalIgnoreCase);
                    Menu newdrink = new Menu
                    {
                        id = menu_List.Count + menu_List1.Count + 1,
                        name = "\t" + newName,
                        size = "\t" + newSize,
                        price = newPrice,
                        status = newStatus
                    };
                    Console.Write("Is this a hot drink? (yes/no):");
                    string yes = "y";
                    string no = "n";
                    string isHotDrink = Console.ReadLine();
                    if (isHotDrink.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        menu_List.Add(newdrink);
                    }
                    else
                    {
                        menu_List1.Add(newdrink);
                    }
                    Console.WriteLine("drink add successfully", Color.Green);
                    Console.WriteLine("Type '<' to go the main menu.");
                    string backCommand = Console.ReadLine();
                    if (backCommand == "<") break;
                }
                break;
            default:
                Console.WriteLine("Invalid choice.", Color.Red);
                break;
        }
    }
}
else
{
    Console.WriteLine("Invalid user or password", Color.Red);
}
Console.ReadLine();