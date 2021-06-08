using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using NoteKeeper.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoteKeeper.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            //base.OnAppearing();
            //_viewModel.OnAppearing();

            base.OnAppearing();
            if (_viewModel.Notes.Count == 0)
                _viewModel.LoadItemsCommand.Execute(null);
        }
    }
}