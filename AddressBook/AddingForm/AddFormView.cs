using System;
using System.Windows.Forms;
using AddressBook.Helpers;
using AddressBook.Modules;

namespace AddressBook.AddingForm
{
    public partial class AddFormView : Form
    {

        public AddFormView()
        {

             InitializeComponent();
             SetDefault();
        }

        public delegate void ActionListener(object o, EventArgs e);

        private void SetDefault()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            rbMale.Checked = true;
            BirthDate = new DateTime(1981,09,10);
        }

        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
            set
            {
                txtFirstName.Text = value;
            }
        }


        
        public string LastName
        {
            get
            {
                return txtLastName.Text;                 
            }
            set
            {
                txtLastName.Text = value;
            }
        }
        public enum Gender { M,F}

        public Gender Sex
        {
            get
            {
                if (rbMale.Checked)
                    return Gender.M;
                else
                    return Gender.F;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return dtpBirthDate.Value;
            }
            set
            {
                dtpBirthDate.Value=value;
            }
        }

        public Record GetRecord()
        {


            if (!GuiTools.HasBlankControls(this,typeof(TextBox)))
            {
                var r = new Record
                            {
                                _firstname = FirstName,
                                _lastname = LastName,
                                _sex = Sex.ToString(),
                                _age = new Age(BirthDate).Years
                            };

                return r;
            }
            else
            {
                MessageBox.Show(@"Please fill the necessary informations.Thanks");
            }
            return null;
            
            
        }



        public void OkButtonListener(ActionListener handler)
        {
            btnOk.Click += new EventHandler(handler);
        }
        public void CancelButtonListener(ActionListener handler)
        {
            btnCancel.Click += new EventHandler(handler);
        }

    }
}
