using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Laboratorul2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (Window3D example = new Window3D())
            {
                example.Run(30.0, 0.0);
            }
        }
    }
}
