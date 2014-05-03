using System;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class MainFormView : Form
    {
        public MainFormView()
        {
            InitializeComponent();
        }

        public DataGridView DataGrid
        {
            get
            {
                return dataGridView1;
            }
            

        }

        public delegate void ActionListener(object o, EventArgs e);

        public void AddButtonListener(ActionListener handler)
        {
            btnAdd.Click += new EventHandler(handler);
        }

        public void EditButtonListener(ActionListener handler)
        {
            btnEdit.Click += new EventHandler(handler);
        }

        public void DeleteButtonListener(ActionListener handler)
        {
            btnDelete.Click += new EventHandler(handler);
        }
        public void SearchButtonListener(ActionListener handler)
        {
            btnSearch.Click += new EventHandler(handler);
        }

        public void PrintButtonListener(ActionListener handler)
        {
            btnPrint.Click += new EventHandler(handler);
        }

    }
}
