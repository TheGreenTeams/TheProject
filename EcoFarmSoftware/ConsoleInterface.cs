﻿using System;
using Business;
using Data;
using Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarmSoftware
{
    public class ConsoleInterface
    {
        public ConsoleInterface()
        {
            UserInput();
        }

        #region User Options

        private UsersBusiness usersBusiness = new UsersBusiness();
        private int closeUserOperationId = 6;

        private void ShowUserMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "ACCOUNT SETTINGS" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Log In");
            Console.WriteLine("3. List all accounts");
            Console.WriteLine("4. Forgot password");
            Console.WriteLine("5. Delete account");
            Console.WriteLine("6. Exit");
        }
        private void UserInput()
        {
            var operation = -1;
            do
            {
                ShowUserMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        AddUserAccount();
                        break;
                    case 2:
                        UserLogIn();
                        break;
                    case 3:
                        ListAllUsers();
                        break;
                    case 4:
                        UpdateUser();
                        break;
                    case 5:
                        DeleteUser();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (operation != closeUserOperationId);
            MainInput();
        }
        private void AddUserAccount()
        {
            Users users = new Users();
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "SIGN UP" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.Write("Enter your first name: ");
            users.FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            users.LastName = Console.ReadLine();
            Console.Write("Enter your email: ");
            users.EMail = Console.ReadLine();
            while (!users.EMail.Contains("@email.com"))
            {
                Console.WriteLine("Invalid Email Address! Try again!");
                Console.Write("Enter your email: ");
                users.EMail = Console.ReadLine();
            }
            users.EMail = users.EMail;
            Console.Write("Enter your username: ");
            users.Username = Console.ReadLine();
            Console.Write("Enter a password: ");
            users.Password = Console.ReadLine();
            usersBusiness.Add(users);
            Console.WriteLine("Account created successfully!");
            MainInput();
        }


        public void UserLogIn()
        {
            //var users = new Users();
            var usersContext = new EcoFarmSoftwareContext();
            
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(new string(' ', 16) + "LOG IN" + new string(' ', 16));
                Console.WriteLine(new string('-', 40));
                Console.Write("Enter your username: ");
                string Username = Console.ReadLine();
                Console.Write("Enter your password: ");
                string Password = Console.ReadLine();
                //try
                //{
                    foreach (var item in usersContext.Userss)
                    {
                        if (item.Username == Username && item.Password == Password)
                        {
                            Console.WriteLine("You have successfully logged in!");
                            MainInput();
                            break;
                        }
                    }
                //}
                //catch
                //{
                //    Console.WriteLine("Your username or password may be incorrect, try again!");
                //}
            
        }

        private void ListAllUsers()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "USERS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var users = usersBusiness.GetAll();
            foreach (var item in users)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Id, item.FirstName, item.LastName, item.EMail, item.Username, item.Password);
            }
        }

        private void UpdateUser()
        {
            Console.WriteLine("Enter ID to change username or password: ");
            int id = int.Parse(Console.ReadLine());
            Users users = usersBusiness.Get(id);
            if (users != null)
            {
                Console.WriteLine("Enter first name: ");
                users.FirstName = Console.ReadLine();
                Console.WriteLine("Enter last name: ");
                users.LastName = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                users.EMail = Console.ReadLine();
                Console.WriteLine("Enter username: ");
                users.Username = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                users.Password = Console.ReadLine();
                usersBusiness.Update(users);
                Console.WriteLine("Data changed successfully");
                UserInput();
            }
            else
            {
                Console.WriteLine("User not found!");
                UserInput();
            }
        }

        private void DeleteUser()
        {
            Console.Write("Enter id to delete a user: ");
            int id = int.Parse(Console.ReadLine());
            Users users = usersBusiness.Get(id);
            if (users != null)
            {
                usersBusiness.Delete(id);
                Console.WriteLine("The user is deleted...");
                UserInput();

            }
            else
            {
                Console.WriteLine("User not found!");
                UserInput();
            }
        }


        #endregion

        #region Main

        private int closeMainOperationId = 5;

        private void ShowMainMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Products Commands");
            Console.WriteLine("2. Machines Commands");
            Console.WriteLine("3. Enegry Sources Commands");
            Console.WriteLine("4. Bank Commands");
            Console.WriteLine("5. User Commands");
            Console.WriteLine("6. Exit");

        }
        private void MainInput()
        {
            var operation = -1;
            do
            {
                ShowMainMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ProductInput();
                        break;
                    case 2:
                        MachineInput();
                        break;
                    case 3:
                        EnergySourcesInput();
                        break;
                    case 4:
                        BankInput();
                        break;
                    case 5:
                        UserInput();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (operation != closeMainOperationId);
        }
        #endregion

        #region Product Options
        private int closeProductOperationId = 8;
        private ProductsBusiness productBusiness = new ProductsBusiness();
        private void ShowProductMenu()
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
            Console.WriteLine("7. Exit to Main Menu");
            Console.WriteLine("8. Exit");

        }

        private void ProductInput()
        {
            var operation = -1;
            do
            {
                ShowProductMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAllProducts();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        UpdateProduct();
                        break;
                    case 4:
                        FetchProduct();
                        break;
                    case 5:
                        DeleteProduct();
                        break;
                    case 6:
                        SellProduct();
                        break;
                    case 7:
                        MainInput();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (operation != closeProductOperationId);
        }

        private void DeleteProduct()
        {
            Console.WriteLine("Enter ID to delete a product: ");
            int id = int.Parse(Console.ReadLine());
            productBusiness.Delete(id);
            Console.WriteLine("The product is deleted...");
        }

        private void FetchProduct()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Products product = productBusiness.Get(id);
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

        private void SellProduct()
        {
            Console.WriteLine("Enter ID to sell: ");
            int id = int.Parse(Console.ReadLine());
            Products product = productBusiness.Get(id);
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

        private void UpdateProduct()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Products product = productBusiness.Get(id);
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

        private void AddProduct()
        {
            Products product = new Products();
            Console.WriteLine("Enter name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter availability: ");
            product.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter type: ");
            product.Type = Console.ReadLine();
            productBusiness.Add(product);
            Console.WriteLine("Done.");

        }

        private void ListAllProducts()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "PRODUCTS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var products = productBusiness.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.Id, item.Name, item.Price, item.Stock, item.Type);
            }
        }
        #endregion

        #region Machines Options

        private int closeMachineOperationId = 7;
        private MachinesBusiness machinesBusiness = new MachinesBusiness();

        private void ShowMachineMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MACHINES MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Show Main Menu");
            Console.WriteLine("7. Exit");
        }
        private void MachineInput()
        {
            var operation = -1;
            do
            {
                ShowMachineMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAllMachines();
                        break;
                    case 2:
                        AddMachine();
                        break;
                    case 3:
                        UpdateMachine();
                        break;
                    case 4:
                        FetchMachine();
                        break;
                    case 5:
                        DeleteMachine();
                        break;
                    case 6:
                        MainInput();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (operation != closeMachineOperationId);
        }

        private void DeleteMachine()
        {
            Console.WriteLine("Enter ID to delete a machine: ");
            int id = int.Parse(Console.ReadLine());
            machinesBusiness.Delete(id);
            Console.WriteLine("The machine is deleted...");
        }

        private void FetchMachine()
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

        private void UpdateMachine()
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
                Console.WriteLine("Done.");
            }
            else
            {
                Console.WriteLine("Machine not found!");
            }

        }

        private void AddMachine()
        {
            Machines machines = new Machines();
            Console.WriteLine("Enter name: ");
            machines.Name = Console.ReadLine();
            Console.WriteLine("Enter type: ");
            machines.Type = Console.ReadLine();
            Console.WriteLine("Enter working capacity: ");
            machines.WorkingCapacity = decimal.Parse(Console.ReadLine());
            machinesBusiness.Add(machines);
            Console.WriteLine("Done.");
        }

        private void ListAllMachines()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "MACHINES" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var machines = machinesBusiness.GetAll();
            foreach (var item in machines)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Id, item.Name, item.Type, item.WorkingCapacity); // Type
            }
        }
        #endregion

        #region Energy Sources

        private int closeEnergySourcesOperationId = 7;
        private EnergySourcesBusiness energySourcesBusiness = new EnergySourcesBusiness();

        private void ShowEnergySourcesMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "ENERGY SOURCES MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all energy sources");
            Console.WriteLine("2. Add new energy source");
            Console.WriteLine("3. Update energy source");
            Console.WriteLine("4. Fetch energy source by ID");
            Console.WriteLine("5. Delete energy source by ID");
            Console.WriteLine("6. Show Main Menu");
            Console.WriteLine("7. Exit");

        }
        private void EnergySourcesInput()
        {
            var operation = -1;
            do
            {
                ShowEnergySourcesMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAllEnergySources();
                        break;
                    case 2:
                        AddEnergySources();
                        break;
                    case 3:
                        UpdateEnergySource();
                        break;
                    case 4:
                        FetchEnergySource();
                        break;
                    case 5:
                        DeleteEnergySource();
                        break;
                    case 6:
                        MainInput();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (operation != closeEnergySourcesOperationId);
        }

        private void DeleteEnergySource()
        {
            Console.WriteLine("Enter ID to delete machine: ");
            int id = int.Parse(Console.ReadLine());
            energySourcesBusiness.Delete(id);
            Console.WriteLine("Done.");
        }

        private void FetchEnergySource()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            EnergySources energySources = energySourcesBusiness.Get(id);
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

        private void UpdateEnergySource()
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
                Console.WriteLine("Done.");
            }
            else
            {
                Console.WriteLine("Energy source not found!");
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
            Console.WriteLine("Done.");

        }

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

        #endregion

        #region BankOptions

        private int closeBankOperationId = 7;
        private BankBusiness bankBusiness = new BankBusiness();

        private void ShowBankMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "BANK MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Show Main Menu");
            Console.WriteLine("7. Exit");
        }
        private void BankInput()
        {
            var operation = -1;
            do
            {
                ShowBankMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAllBankAccounts();
                        break;
                    case 2:
                        AddBankAccount();
                        break;
                    case 3:
                        UpdateBankAccount();
                        break;
                    case 4:
                        FetchBankAccount();
                        break;
                    case 5:
                        DeleteBankAccount();
                        break;
                    case 6:
                        MainInput();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (operation != closeBankOperationId);
        }

        private void DeleteBankAccount()
        {
            Console.WriteLine("Enter ID to delete a bank account: ");
            int id = int.Parse(Console.ReadLine());
            bankBusiness.Delete(id);
            Console.WriteLine("The bank account is deleted...");
        }

        private void FetchBankAccount()
        {
            Console.WriteLine("Enter ID to serch: ");
            int id = int.Parse(Console.ReadLine());
            Bank bankAccount = bankBusiness.Get(id);
            if (bankAccount != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + bankAccount.Id);
                Console.WriteLine("Name: " + bankAccount.Name);
                Console.WriteLine("Balance: " + bankAccount.Balance);
            }
        }

        private void UpdateBankAccount()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Bank bankAccount = bankBusiness.Get(id);
            if (bankAccount != null)
            {
                Console.WriteLine("Enter number of the bank account: ");
                bankAccount.Name = Console.ReadLine();
                Console.WriteLine("Enter balance: ");
                bankAccount.Balance = decimal.Parse(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Bank account not found!");
            }
        }

        private void AddBankAccount()
        {
            Bank bankAccount = new Bank();
            Console.WriteLine("Enter number of the bank account: ");
            bankAccount.Name = Console.ReadLine();
            Console.WriteLine("Enter balance: ");
            bankAccount.Balance = decimal.Parse(Console.ReadLine());
            bankBusiness.Add(bankAccount);
        }

        private void ListAllBankAccounts()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "Bank accounts" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var bankAccounts = bankBusiness.GetAll();
            foreach (var item in bankAccounts)
            {
                Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.Balance);
            }
        }

        #endregion
    }
}