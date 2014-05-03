using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AddressBook.EditingForm
{
    class EditFormController
    {
        private EditFormModel _model;
        private EditFormView _view;

        public EditFormModel Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public EditFormView View
        {
            get { return _view; }
            set { _view = value; }
        }

        public EditFormController(EditFormModel model,EditFormView view)
        {
            _model = model;
            _view = view;

            _view.UpdateButtonListener(UpdateButtonClick);
            _view.CancelButtonListener(CancelButtonClick);
        }

        private static void UpdateButtonClick(object o, EventArgs e)
        {
            MessageBox.Show(@"Clicked");
        }

        private static void CancelButtonClick(object o, EventArgs e)
        {
            MessageBox.Show(@"Cancelled");
           
        }

    }
}
