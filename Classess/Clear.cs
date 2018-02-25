using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace zeus.Classess
{
    class Clear
    {
        public static void ClearFormFields(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if(c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }

                if (c.HasChildren)
                {
                    ClearFormFields(c);
                }
            }
        }
    }
}
