using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructor
{
    class User
    {
        public User()
        {
            Console.WriteLine("Instance Class Sudah Dibuat");
        }
        // Destructor
        ~User()
        {
            Console.WriteLine("Instance Class Sudah di Destroy");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
            GC.Collect();

        }
        public static void Run()
        {
            // Membuat Instance Class
            User user = new User();
        }
    }
}