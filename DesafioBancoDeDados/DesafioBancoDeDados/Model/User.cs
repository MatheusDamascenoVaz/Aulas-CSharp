using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1;

namespace DesafioBancoDeDados.Model
{
    class User
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }


        public User(int iduser, string name, string email, DateTime createdAt)
        {
            IdUser = iduser;
            Name = name;
            Email = email;
            CreatedAt = createdAt;

        }
        public string GetAllUsers()
        {
            return "1234";
        }
        public string AddUser()
        {
           
        }

    }
}