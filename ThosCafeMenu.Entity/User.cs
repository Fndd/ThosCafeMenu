using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThosCafeMenu.Entity
{
    public class User
    {
        public int Id { get; set; } 
        public string NAME { get; set; } = String.Empty;
        public string SURNAME { get; set; } = String.Empty;
        public string EMAIL { get; set; } = String.Empty;
        public byte[] HASHPASSWORD { get; set; } 
        public byte[] SALTPASSWORD { get; set; } 
    }
}
