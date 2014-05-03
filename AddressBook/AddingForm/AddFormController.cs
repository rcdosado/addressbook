using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using AddressBook.AddingForm;

namespace AddressBook.AddingForm
{
    public class AddFormController
    {
        private AddFormModel _model;
        private AddFormView _view;

        public AddFormModel Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public AddFormView View
        {
            get { return _view; }
            set { _view = value; }
        }

        public AddFormController(AddFormModel model,AddFormView view)
        {
            _model = model;
            _view = view;

            _view.OkButtonListener(OkButtonClick);
            _view.CancelButtonListener(CancelButtonClick);
        }

        private void OkButtonClick(object o, EventArgs e)
        {
            var r =_view.GetRecord();
            var p = _model.SaveRecord(r);        
        }

        private  void CancelButtonClick(object o, EventArgs e)
        {
            _view.Close();
           
        }

    }
}