using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bullshit
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //у меня английская винда
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Object2D obj = new Object2D();
            obj.Move();

            Console.ReadKey();
            Application.Exit();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lobby());
        }
    }
}
