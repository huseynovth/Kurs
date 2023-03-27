while (true)
{
    Console.WriteLine("Exit-1|Create Kurs-2");
    string response = Console.ReadLine();
    int menu;
    bool tryToInt = int .TryParse(response, out menu);     
    if (tryToInt)
    {
        switch (menu)
        {
            case 0:
                Console.WriteLine("Enter Kurs Name:");
                try
                {
                    string res_Kursname = Console.ReadLine();
                    object res_kursname = null;
                    object Kursservice = null;
                    object value = Kursservice.Create(res_kursname);  
                }
        }
    }
}
