using System;
using System.Windows.Forms;
using AddressBook.AddingForm;
using AddressBook.EditingForm;
using AddressBook.SearchForm;

namespace AddressBook
{
    class MainFormController
    {
        private MainFormModel _model = new MainFormModel();
        private MainFormView _view = new MainFormView();


        public MainFormModel  Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public MainFormView View
        {
            get { return _view; }
            set { _view = value; }
        }

        public MainFormController(MainFormModel model, MainFormView view)
        {
            //todo check model and view if null
            _model = model;
            _view = view;

            _view.AddButtonListener(AddButtonClick);
            _view.EditButtonListener(EditButtonClick);
            _view.DeleteButtonListener(DeleteButtonClick);
            _view.SearchButtonListener(SearchButtonClick);
            _view.PrintButtonListener(PrintButtonClick);

            
        }
        private static void AddButtonClick(object o, EventArgs e)
        {
            var view = new AddFormView();
            var model = new AddFormModel();
            var controller = new AddFormController(model, view);

            view.ShowDialog();

        }
        private static void EditButtonClick(object o, EventArgs e)
        {
            var view = new EditFormView();
            var model = new EditFormModel();
            var controller = new EditFormController(model, view);

            view.ShowDialog();
        }

        private static void DeleteButtonClick(object o, EventArgs e)
        {
            /*
             * get the location of the datagrid selector
             * then get a handle to that,extract necessary data
             * pass as parameter to delete method
             * 
             * 
             */
             
            MessageBox.Show("Delete Button is clicked");
        }

        private static void SearchButtonClick(object o, EventArgs e)
        {
            var view = new SearchFormView();
            var model = new SearchFormModel();
            var controller = new SearchFormController(model, view);

            view.ShowDialog();
        }

        private static void PrintButtonClick(object o, EventArgs e)
        {
            MessageBox.Show("Print Button is clicked");
        }
    }
}
