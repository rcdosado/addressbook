using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddressBook.SearchForm
{
    public partial class SearchFormView : Form
    {
        public SearchFormView()
        {
            InitializeComponent();
        }

        public delegate void ActionListener(object o, EventArgs e);

        public void SearchButtonListener(ActionListener handler)
        {
            btnSearch.Click += new EventHandler(handler);
        }
        public void CancelButtonListener(ActionListener handler)
        {
            btnCancel.Click += new EventHandler(handler);
        }
        public void ClearButtonListener(ActionListener handler)
        {
            btnClear.Click += new EventHandler(handler);
        }
    }
}
