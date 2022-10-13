using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisdanSuper
{
    public class Org
    {
        protected string nama = "Yuninda Intan";
        protected int umur = 19;

        public virtual void GetData()
        {
            Console.WriteLine("Nama : {0}", nama);
            Console.WriteLine("Umur : {0}", umur);
        }
    }
    class Pegawai : Org
    {
        public string gaji = "Rp. 15.000.000";
        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Gaji : {0}", gaji);
        }
    }
    class Murid
    {
        private string username;
        private string password;

        public Murid(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void printMurid()
        {
            Console.WriteLine("Username: {0}\nPassword: {1}", username, password);
        }
    }
    class TestClass
    {
        static void Main()
        {
            Console.WriteLine("Super or Base");
            Pegawai P = new Pegawai();
            P.GetData();
            Console.WriteLine("");
            Console.WriteLine("This");
            Murid M = new Murid("Yuninda", "025");
            M.printMurid();
        }
    }
}