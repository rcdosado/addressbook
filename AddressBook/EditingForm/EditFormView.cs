using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddressBook.EditingForm
{
    public partial class EditFormView : Form
    {
        public EditFormView()
        {
            InitializeComponent();
        }

        public delegate void ActionListener(object o, EventArgs e);

        public string FirstName
        {
            get
            {
                return txtFirstName.ToString();
            }
        }
        public string LastName
        {
            get
            {
                return txtLastName.ToString();

            }
        }
        public enum Gender { Male, Female }

        public Gender Sex
        {
            get
            {
                if (rbMale.Checked)
                    return Gender.Male;
                else
                    return Gender.Female;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return dtpBirthDate.Value;
            }
        }

        public void UpdateButtonListener(ActionListener handler)
        {
            btnUpdate.Click += new EventHandler(handler);
        }
        public void CancelButtonListener(ActionListener handler)
        {
            btnCancel.Click += new EventHandler(handler);
        }


    }
}
