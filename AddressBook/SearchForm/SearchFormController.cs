using System;
using System.Windows.Forms;

namespace AddressBook.SearchForm
{
    class SearchFormController
    {
        private SearchFormModel _model = new SearchFormModel();
        private SearchFormView _view = new SearchFormView();


        public SearchFormModel Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public SearchFormView View
        {
            get { return _view; }
            set { _view = value; }
        }

        public SearchFormController(SearchFormModel model, SearchFormView view)
        {
            //todo check model and view if null
            _model = model;
            _view = view;

            _view.SearchButtonListener(SearchButton_Click);
            _view.CancelButtonListener(CancelButton_Click);
            _view.ClearButtonListener(ClearButton_Click);

        }

        private static void SearchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Search..");
        }

        private static void CancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Goodbye");
            Environment.Exit(0);
        }

        private static void ClearButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Clear..");

        }
    }
}
