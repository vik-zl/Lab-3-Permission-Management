using System;

namespace Lab_3_Permission_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add 4 users with none permissions (Admin, Operator, Manager, Senior)
            User operatorUser = new User("operator");
            User seniorUser = new User("senior");
            User managerUser = new User("manager");
            User adminUser = new User("admin");

            // Add read permission to operator
            operatorUser.AddPermission(Permissions.Read);
            if (operatorUser.HasPermission(Permissions.Read))
                Console.WriteLine("Operator has read permission");
            else
                Console.WriteLine("Operator does not have read permission");

            // Add read, write, execute permissions to manager
            managerUser.AddMultiplePermissions(Permissions.Read, Permissions.Write);
            managerUser.AddPermission(Permissions.Execute);

            // Add read, write permissions to senior
            seniorUser.AddMultiplePermissions(Permissions.Read, Permissions.Write);

            // Add full permissions (read, write, execute) to admin
            adminUser.AddMultiplePermissions(Permissions.Read, Permissions.Write);
            adminUser.AddPermission(Permissions.Execute);

            // Remove Write permission from Senior
            seniorUser.RemovePermission(Permissions.Write);

            Console.WriteLine("\n--- Permission Checks ---");

            // Check if Senior has Write permission
            if (seniorUser.HasPermission(Permissions.Write))
                Console.WriteLine("Senior has Write permission");
            else
                Console.WriteLine("Senior does NOT have Write permission");

            // Check if Manager has Execute permission
            if (managerUser.HasPermission(Permissions.Execute))
                Console.WriteLine("Manager has Execute permission");
            else
                Console.WriteLine("Manager does NOT have Execute permission");

            // Check if Admin has full permissions (Read + Write + Execute)
            Permissions full = Permissions.Read | Permissions.Write | Permissions.Execute;
            if (adminUser.HasPermission(full))
                Console.WriteLine("Admin has FULL permissions");
            else
                Console.WriteLine("Admin does NOT have full permissions");

            Console.ReadLine(); // Keep console open
        }
    }
}
