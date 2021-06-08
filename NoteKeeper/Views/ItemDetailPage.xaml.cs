using NoteKeeper.Models;
using NoteKeeper.Services;
using NoteKeeper.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public ItemDetailPage()
        {
            InitializeComponent();

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
        }

        async public void Cancel_Clicked(object sensder, EventArgs eventArgs)
        {
            await Shell.Current.GoToAsync("..");
        }
        public async void Save_Clicked(object sensder, EventArgs eventArgs)
        {
            MessagingCenter.Send(this, "SaveNote", viewModel.Note);
            await Shell.Current.GoToAsync("..");
        }
    }
}