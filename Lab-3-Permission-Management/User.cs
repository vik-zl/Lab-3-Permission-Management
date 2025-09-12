using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        // Getter and Setter for Permissions
        public Permissions GetPermissions()
        {
            return permissions;
        }

        public void SetPermissions(Permissions newPermissions)
        {
            permissions = newPermissions;
        }

        // Extra: Add or Remove a single permission
        public void AddPermission(Permissions permission)
        {
            // complete code to add a permission
        }

        public void RemovePermission(Permissions permission)
        {
            //complete code to remove a permission

        }

        public bool HasPermission(Permissions permission)
        {
            return (permissions & permission) == permission;
        }
    }
}
