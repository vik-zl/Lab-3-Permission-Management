using System;

namespace Lab_3_Permission_Management
{
    public class User
    {
        private Permissions permissions;
        private string name;

        public User(string name, Permissions initialPermissions = Permissions.None)
        {
            this.name = name;
            this.permissions = initialPermissions;
        }

        // Getter and Setter for Name
        public string GetName() => name;
        public void SetName(string newName) => name = newName;

        // Getter and Setter for Permissions
        public Permissions GetPermissions() => permissions;
        public void SetPermissions(Permissions newPermissions) => permissions = newPermissions;

        // Add a single permission
        public void AddPermission(Permissions permission)
        {
            permissions |= permission; // Bitwise OR adds permission
        }

        // Remove a single permission
        public void RemovePermission(Permissions permission)
        {
            permissions &= ~permission; // Bitwise AND with NOT removes permission
        }

        // Add multiple permissions
        public void AddMultiplePermissions(Permissions permission1, Permissions permission2)
        {
            permissions |= (permission1 | permission2); // Add both
        }

        // Remove multiple permissions
        public void RemoveMultiplePermissions(Permissions permission1, Permissions permission2)
        {
            permissions &= ~(permission1 | permission2); // Remove both
        }

        // Check if user has a specific permission
        public bool HasPermission(Permissions permission)
        {
            return (permissions & permission) == permission;
        }
    }
}
