using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class ClientModel
    {
        public ClientModel()
        {
        }

        public ClientModel(int id, string name, string password, string email)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.email = email;
        }
        public ClientModel( string name, string password, string email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }

        public ClientModel(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
