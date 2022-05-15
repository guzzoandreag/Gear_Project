using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gear_Desktop.Controller.DAL
{
    public class DALConnectionREST
    {
        private string url = "http://localhost:8091/api/";

        public string Url { get => url; set => url = value; }

        public DALConnectionREST()
        {
            // Construtor
        }

        public DALConnectionREST(string url)
        {
            // Construtor
            Url = url;
        }

        ~DALConnectionREST()
        {
            // Destroyer
        }
    }
}
