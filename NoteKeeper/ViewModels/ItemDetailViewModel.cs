using NoteKeeper.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoteKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }

        public String NoteHeading
        {
            get { return Note.Heading; }
            set { Note.Heading = value; OnPropertyChanged(); }
        }
        public String NoteText
        {
            get { return Note.Text; }
            set { Note.Text = value; OnPropertyChanged(); }
        }
        public String NoteCourse
        {
            get { return Note.Course; }
            set { Note.Course = value; OnPropertyChanged(); }
        }

        public ItemDetailViewModel(Note note = null)
        {
            Title = "Edit note";
            InitializeCourseList();
            Note = note ?? new Note();
        }
        async void InitializeCourseList()
        {
            CourseList = await pluralsightDataStore.GetCoursesAsync();
        }
    }



    //[QueryProperty(nameof(ItemId), nameof(ItemId))]
    //public class ItemDetailViewModel : BaseViewModel
    //{
    //    private string itemId;
    //    private string text;
    //    private string description;
    //    public string Id { get; set; }

    //    public string Text
    //    {
    //        get => text;
    //        set => SetProperty(ref text, value);
    //    }

    //    public string Description
    //    {
    //        get => description;
    //        set => SetProperty(ref description, value);
    //    }

    //    public string ItemId
    //    {
    //        get
    //        {
    //            return itemId;
    //        }
    //        set
    //        {
    //            itemId = value;
    //            LoadItemId(value);
    //        }
    //    }

    //    public async void LoadItemId(string itemId)
    //    {
    //        try
    //        {
    //            var item = await DataStore.GetItemAsync(itemId);
    //            Id = item.Id;
    //            Text = item.Text;
    //            Description = item.Description;
    //        }
    //        catch (Exception)
    //        {
    //            Debug.WriteLine("Failed to Load Item");
    //        }
    //    }
    //}
}
