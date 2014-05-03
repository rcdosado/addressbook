using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Helpers
{
    class GuiTools
    {
        public static  void ClearControls(Control ctrl)
        {
            if (ctrl is TextBox && ctrl.Text!=string.Empty)
            {
                    ctrl.Text = String.Empty;
            }

            foreach (Control ctrlChild in ctrl.Controls)
            {
                ClearControls(ctrlChild);
            }

        }

        public static bool HasBlankControls(Control ctrl,Type type)
        {

            if (ctrl is TextBox && ctrl.Text == string.Empty)
            {
                return true;
            }

            foreach (Control ctrlChild in ctrl.Controls)
            {
                if (HasBlankControls(ctrlChild,type))
                    return true;
            }
            return false;

        }


    }
}
