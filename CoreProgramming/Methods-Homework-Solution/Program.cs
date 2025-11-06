using System;

namespace UserSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = CommandInput();

            string[,] userTable = UserTable();

            // main loop
            while (command != "end")
            {
                string[] commandArgs = command.Split(" ");
                switch (commandArgs[0])
                {
                    case "register":
                        {
                            // validate arguments
                            if (!LengthValidation(commandArgs.Length, "Too few parameters."))
                            {
                                break;
                            }

                            string username = commandArgs[1];
                            string password = commandArgs[2];

                            // validate username
                            if (!LengthValidation(username.Length, "Username must be at least 3 characters long."))
                            {
                                break;
                            }

                            // validate password
                            if (!LengthValidation(password.Length, "Password must be at least 3 characters long."))
                            {
                                break;
                            }

                            // check if username exists
                            bool usernameExists = FindUser(userTable, username);

                            if (usernameExists)
                            {
                                PrintColorMessage(ConsoleColor.Red, "Username already exists.");
                                break;
                            }

                            // find free slot
                            int freeSlotIndex = FindFreeSlot(userTable);

                            // no free slots
                            if (freeSlotIndex == -1)
                            {
                                PrintColorMessage(ConsoleColor.Red, "The system supports a maximum number of 4 users.");
                                break;
                            }

                            // save user
                            SaveUser(userTable, freeSlotIndex, username, password);
                            PrintColorMessage(ConsoleColor.DarkGreen, "Registered user.");
                            break;
                        }
                    case "delete":
                        {
                            // validate arguments
                            if (!LengthValidation(commandArgs.Length, "Too few parameters."))
                            {
                                break;
                            }

                            string username = commandArgs[1];
                            string password = commandArgs[2];

                            // validate username
                            if (!LengthValidation(username.Length, "Username must be at least 3 characters long"))
                            {
                                break;
                            }

                            // validate password
                            if (!LengthValidation(password.Length, "Password must be at least 3 characters long."))
                            {
                                break;
                            }

                            // find account to delete
                            int accountIndex = FindingUserSlot(userTable, username, password);

                            if (accountIndex == -1)
                            {
                                PrintColorMessage(ConsoleColor.Red, "Invalid account/password.");
                                break;
                            }

                            DeletingUser(userTable, accountIndex);
                            PrintColorMessage(ConsoleColor.DarkGreen, "Deleted account.");
                            break;
                        }
                }

                Console.ResetColor();
                // read next command
                command = Console.ReadLine();
            }


        }

        //Command Method
        static string CommandInput()
        {
            string command = Console.ReadLine();
            return command;
        }

        //Table Method with optional parameters
        static string[,] UserTable(int x = 4, int y = 2)
        {
            string[,] userTable = new string[x, y];
            return userTable;
        }

        //Method for Length Validation
        static bool LengthValidation(int length, string errorMessage)
        {
            if (length < 3)
            {
                PrintColorMessage(ConsoleColor.Red, errorMessage);
                return false;
            }
            return true;
        }

        //Method if user exists
        static bool FindUser(string[,] userTable, string username)
        {
            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                if (userTable[i, 0] == username)
                {
                    return true;
                }
            }
            return false;
        }

        //Method for Color and Message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }

        //Method for Free Slot
        static int FindFreeSlot(string[,] userTable)
        {
            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                if (userTable[i, 0] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        //Method for Saving the user
        static void SaveUser(string[,] userTable, int freeSlotIndex, string username, string password)
        {
            userTable[freeSlotIndex, 0] = username;
            userTable[freeSlotIndex, 1] = password;
        }

        //Method for Finding an User slot ( possible for deletion )
        static int FindingUserSlot(string[,] userTable, string username, string password)
        {
            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                if (userTable[i, 0] == username &&
                    userTable[i, 1] == password)
                {
                    return i;
                }
            }
            return -1;
        }

        //Method for deleting the user
        static void DeletingUser(string[,] userTable, int accountIndex)
        {
            userTable[accountIndex, 0] = null;
            userTable[accountIndex, 1] = null;
        }
    }
}
