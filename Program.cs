using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using zeus.Forms;

using zeus.Classess;

namespace zeus
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Getting Database Connection method to the application
            DB.connect("sql", "Data Source=DESKTOP-CJL1KH7\\SQLEXPRESS;Database=zeus;Initial Catalog=zeus;Integrated Security=True; MultipleActiveResultSets=True;");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());
        }
    }
}
