using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class Display
    {
        public Display()
        {
            Input();
        }

        public void Input()
        {

            while (true)
            {
                Console.Write(new string('-', 25));
                Console.Write("MENU");
                Console.Write(new string('-', 25));
                Console.WriteLine();
                Console.WriteLine("1. Add lost animal");
                Console.WriteLine("2. Add found animal");
                Console.WriteLine("3. Check for matches if you have found a pet");
                Console.WriteLine("4. Edit lost animal");
                Console.WriteLine("5. Edit found animal");
                Console.WriteLine("6. Delete lost animal");
                Console.WriteLine("7. Delete found animal");
                Console.WriteLine("8. See all lost animals");
                Console.WriteLine("9. See all found animals");
                Console.WriteLine("10. Visual display (Open Windows Forms App)");
                Console.WriteLine("11. Exit");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("If you want to leave a field empty, type '-' (If a field is marked with '*', you cannot leave it empty as it is obligatory data)");
                        Console.WriteLine("Insert data for pet: (Please note that image insertion is possible only in the Windows Forms App interface)");

                        Console.Write("Name*: ");
                        string name = Console.ReadLine();

                        Console.Write("Gender* (if castrated, type 'castrated'): ");
                        string gender = Console.ReadLine();

                        Console.Write("Color*: ");
                        string color = Console.ReadLine();

                        Console.Write("Location* (Format: {city}, {country}): ");
                        string[] location = Console.ReadLine().Split(", ").ToArray();

                        Console.Write("Date lost* (Format: {dd/MM/yyyy}): ");
                        string date = Console.ReadLine();
                        DateOnly dateLost;
                        if (!DateOnly.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateLost))
                        {
                            throw new FormatException("Invalid date format. Expected format: dd/MM/yyyy.");
                        }

                        Console.WriteLine("Choose a species*: ");
                        Console.WriteLine("1. Cat");
                        Console.WriteLine("2. Dog");
                        Console.WriteLine("3. Rabbit");
                        Console.WriteLine("4. Parrot");
                        Console.WriteLine("5. Hamster");
                        Console.WriteLine("6. Guinea pig");
                        Console.WriteLine("7. Other");
                        int pet = int.Parse(Console.ReadLine());

                        Console.Write("Age (Type the closest age to the real one in years): ");
                        string age = Console.ReadLine();

                        Console.Write("Breed: ");
                        string breed = Console.ReadLine();

                        Console.WriteLine("Description:");
                        string description = Console.ReadLine();


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

                    case 7:

                        break;

                    case 8:
                        Console.Write(new string('-', 25));
                        Console.Write("LOST ANIMALS");
                        Console.Write(new string('-', 25));

                        break;

                    case 9:
                        Console.Write(new string('-', 25));
                        Console.Write("FOUND ANIMALS");
                        Console.Write(new string('-', 25));

                        break;

                    case 10:
                        Console.WriteLine("Opening Windows Forms App...");
                        Task.Run(() => Application.Run(new Form1()));
                        break;

                    case 11:
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
