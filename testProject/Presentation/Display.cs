using testProject.Data;
using testProject.Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject.Presentation
{
    class Display
    {
        private int closeOperationId = 6;
        private int closeProductOperationId = 8;
        private int closeMachineOperationId = 7;
        private int closeEnergySourcesOperationId = 7;
        private int closeBankOperationId = 7;

        private ProductBusiness productBusiness = new ProductBusiness();
        private MachinesBusiness machinesBusiness = new MachinesBusiness(); 
        private EnergySourcesBusiness energySourcesBusiness = new EnergySourcesBusiness();  
        private BankBusiness bankBusiness = new BankBusiness();  

        public Display()
        {
            ShowMenu();
            InputMenu();
        }

        //Main Menu
        private void ShowMenu() 
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Main Menu");
            Console.WriteLine("2. Products Commands");
            Console.WriteLine("3. Machines Commands");
            Console.WriteLine("4. Enegry Sources Commands");
            Console.WriteLine("5. Bank Commands");
            Console.WriteLine("6. Exit");
        }

        //Product Menu
        private void ShowProductsMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "PRODUCTS MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Sell");
            Console.WriteLine("7. Show Main Menu");
            Console.WriteLine("8. Exit");
        }

        //Machines Menu
        private void ShowMachinesMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MACHINES MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Show Main Menu");
            Console.WriteLine("2. List all entries");
            Console.WriteLine("3. Add new entry");
            Console.WriteLine("4. Update entry");
            Console.WriteLine("5. Fetch entry by ID");
            Console.WriteLine("6. Delete entry by ID");
            Console.WriteLine("7. Exit");
        }

        //Energy Sources Menu
        private void ShowEnergySourcesMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "ENERGY SOURCES MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Show Main Menu");
            Console.WriteLine("2. List all entries");
            Console.WriteLine("3. Add new entry");
            Console.WriteLine("4. Update entry");
            Console.WriteLine("5. Fetch entry by ID");
            Console.WriteLine("6. Delete entry by ID");
            Console.WriteLine("7. Exit");
        }

        //Bank Menu
        private void ShowBankMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "BANK MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Show Main Menu");
            Console.WriteLine("2. List all entries");
            Console.WriteLine("3. Add new entry");
            Console.WriteLine("4. Update entry");
            Console.WriteLine("5. Fetch entry by ID");
            Console.WriteLine("6. Delete entry by ID");
            Console.WriteLine("7. Exit");
        }

        //Cases For The Main Menu
        private void InputMenu()
        {
            var operation = -1;
            do
            {
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ShowMenu();
                        break;
                    case 2:
                        ShowProductsMenu();
                        InputProucts();
                        break;
                    case 3:
                        ShowMachinesMenu();
                        InputMachines();
                        break;
                    case 4:
                        ShowEnergySourcesMenu();
                        InputEnergySource();
                        break;
                    case 5:
                        ShowBankMenu();
                        InputBank();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        //Cases For The Products Menu
        private void InputProucts() 
        {
            var operation = -1;
            do
            {
                ShowProductsMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAllProducts();
                        break;
                    case 2:
                        AddProducts();
                        break;
                    case 3:
                        UpdateProducts();
                        break;
                    case 4:
                        FetchProducts();
                        break;
                    case 5:
                        DeleteProducts();
                        break;
                    case 6:
                        SellProducts();
                        break;
                    case 7:
                        ShowMenu();
                        break;
                    default:
                        break;
                }
            } while (operation != closeProductOperationId);
        }

        //Cases For The Machines Menu
        private void InputMachines()
        {
            var operation = -1;
            do
            {
                ShowMachinesMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ShowMenu();
                        break;
                    case 2:
                        ListAllMachines();
                        break;
                    case 3:
                        AddMachines();
                        break;
                    case 4:
                        UpdateMachines();
                        break;
                    case 5:
                        FetchMachines();
                        break;
                    case 6:
                        DeleteMachines();
                        break;
                    default:
                        break;
                }
            } while (operation != closeMachineOperationId);
        }

        //Cases For The Energy Sources Menu
        private void InputEnergySource()
        {
            var operation = -1;
            do
            {
                ShowEnergySourcesMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ShowMenu();
                        break;
                    case 2:
                        ListAllEnergySources();
                        break;
                    case 3:
                        AddEnergySources();
                        break;
                    case 4:
                        UpdateEnergySources();
                        break;
                    case 5:
                        FetchEnergySources();
                        break;
                    case 6:
                        DeleteEnergySources();
                        break;
                    default:
                        break;
                }
            } while (operation != closeMachineOperationId);
        }

        //Cases For The Bank Menu   To Do
        private void InputBank()
        {
            var operation = -1;
            do
            {
                ShowBankMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ShowMenu();
                        break;
                    case 2:
                        ListAllBank();
                        break;
                    case 3:
                        AddBank();
                        break;
                    case 4:
                        UpdateBank();
                        break;
                    case 5:
                        FetchBank();
                        break;
                    case 6:
                        DeleteBank();
                        break;
                    default:
                        break;
                }
            } while (operation != closeMachineOperationId);
        }

        //Products Commands
        private void DeleteProducts()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            productBusiness.Delete(id);
            Console.WriteLine("Done.");
        }

        private void FetchProducts()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBusiness.Get(id);
            if (product != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("Stock: " + product.Stock);
                Console.WriteLine("Type: " + product.Type);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private void UpdateProducts()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBusiness.Get(id);
            if (product != null)
            {
                Console.WriteLine("Enter name: ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                product.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter availability: ");
                product.Stock = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter type: ");
                product.Type = Console.ReadLine();
                productBusiness.Update(product);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private void SellProducts()
        {
            Console.WriteLine("Enter ID to sell: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBusiness.Get(id);
            if (product != null)
            {
                Console.WriteLine("Enter quantity to sell: ");
                int q = int.Parse(Console.ReadLine());
                if (q <= product.Stock)
                {
                    product.Stock = product.Stock - q;
                    Console.WriteLine($"You sold {q} {product.Name}.");
                    Console.WriteLine($"You now have {product.Stock} {product.Name} left.");
                    productBusiness.Update(product);
                }
                else
                {
                    Console.WriteLine("Invalid quantity value!");
                }
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private void AddProducts()
        {
            Product product = new Product();
            Console.WriteLine("Enter name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter availability: ");
            product.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter type: ");
            product.Type = Console.ReadLine();
            productBusiness.Add(product);
        }

        private void ListAllProducts()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "PRODUCTS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var products = productBusiness.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.Id, item.Name, item.Price, item.Stock, item.Type); // Type
            }
        }

        //Machines Commands
        private void ListAllMachines()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "MACHINES" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var products = machinesBusiness.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Id, item.Name, item.Type, item.WorkingCapacity); // Type
            }
        }

        private void AddMachines()
        {
            Machines machines = new Machines();
            Console.WriteLine("Enter name: ");
            machines.Name = Console.ReadLine();
            Console.WriteLine("Enter type: ");
            machines.Type = Console.ReadLine();
            Console.WriteLine("Enter working capacity: ");
            machines.WorkingCapacity = decimal.Parse(Console.ReadLine());
            machinesBusiness.Add(machines);
        }

        private void UpdateMachines()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Machines machines = machinesBusiness.Get(id);
            if (machines != null)
            {
                Console.WriteLine("Enter name: ");
                machines.Name = Console.ReadLine();
                Console.WriteLine("Enter type: ");
                machines.Type = Console.ReadLine();
                Console.WriteLine("Enter working capacity: ");
                machines.WorkingCapacity = decimal.Parse(Console.ReadLine());
                machinesBusiness.Update(machines);
            }
            else
            {
                Console.WriteLine("Machine not found!");
            }
        }

        private void FetchMachines()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Machines machines = machinesBusiness.Get(id);
            if (machines != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + machines.Id);
                Console.WriteLine("Name: " + machines.Name);
                Console.WriteLine("Type: " + machines.Type);
                Console.WriteLine("Working Capacity: " + machines.WorkingCapacity);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Machine not found!");
            }
        }

        private void DeleteMachines()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            machinesBusiness.Delete(id);
            Console.WriteLine("Done.");
        }

        //Energy Sources Commands
        private void ListAllEnergySources()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "ENERGY SOURCES" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var products = energySourcesBusiness.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Id, item.Name, item.Price, item.Type, item.KWh, item.Area);
            }
        }

        private void AddEnergySources()
        {
            EnergySources energySources = new EnergySources();
            Console.WriteLine("Enter name: ");
            energySources.Name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            energySources.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter type: ");
            energySources.Type = Console.ReadLine();
            Console.WriteLine("Enter power: ");
            energySources.KWh = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter area: ");
            energySources.Area = decimal.Parse(Console.ReadLine());
            energySourcesBusiness.Add(energySources);
        }

        private void UpdateEnergySources()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            EnergySources energySources = energySourcesBusiness.Get(id);
            if (energySources != null)
            {
                Console.WriteLine("Enter name: ");
                energySources.Name = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                energySources.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter type: ");
                energySources.Type = Console.ReadLine();
                Console.WriteLine("Enter power: ");
                energySources.KWh = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter area: ");
                energySources.Area = decimal.Parse(Console.ReadLine()); 
                energySourcesBusiness.Update(energySources);
            }
            else
            {
                Console.WriteLine("Energy source not found!");
            }
        }

        private void FetchEnergySources()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            EnergySources energySources= energySourcesBusiness.Get(id);
            if (energySources != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + energySources.Id);
                Console.WriteLine("Name: " + energySources.Name);
                Console.WriteLine("Price: " + energySources.Price);
                Console.WriteLine("Type: " + energySources.Type);
                Console.WriteLine("Power: " + energySources.KWh);
                Console.WriteLine("Area: " + energySources.Area);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Energy source not found!");
            }
        }

        private void DeleteEnergySources()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            energySourcesBusiness.Delete(id);
            Console.WriteLine("Done.");
        }

        //Bank Commands
        //Lists all bank accounts
        private void ListAllBank() 
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "BANK" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var products = bankBusiness.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Id, item.Name, item.Balance, item.Type);
            }
        }

        //Adds new bank account
        private void AddBank()
        {
            Bank bank = new Bank();
            Console.WriteLine("Enter name: ");
            bank.Name = Console.ReadLine();
            Console.WriteLine("Balance: ");
            bank.Balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter type: ");
            bank.Type = Console.ReadLine();
            bankBusiness.Add(bank);
        }

        //Updates a certain bank account
        private void UpdateBank()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Bank bank = bankBusiness.Get(id);
            if (bank != null)
            {
                Console.WriteLine("Enter name: ");
                bank.Name = Console.ReadLine();
                Console.WriteLine("Enter balance: ");
                bank.Balance = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter type: ");
                bank.Type = Console.ReadLine();
                bankBusiness.Update(bank);
            }
            else
            {
                Console.WriteLine("Bank account not found!");
            }
        }

        //Shows the info for a certain bank account
        private void FetchBank()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Bank bank = bankBusiness.Get(id);
            if (bank != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + bank.Id);
                Console.WriteLine("Name: " + bank.Name);
                Console.WriteLine("Balance: " + bank.Balance);
                Console.WriteLine("Type: " + bank.Type);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Bank account not found!");
            }
        }

        //Deletes a bank account
        private void DeleteBank()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            bankBusiness.Delete(id);
            Console.WriteLine("Done.");
        }
    }
}
 