using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo7
{
    class User
    {
        private string _name;
        private string _email;
        private string _sdt;
        private string _dc;

        public string name { get => _name; set => _name = value; }
        public string email { get => _email; set => _email = value; }
        public string sdt { get => _sdt; set => _sdt = value; }
        public string dc { get => _dc; set => _dc = value; }
    }
}
