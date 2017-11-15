using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Main.Model;
using Xamarin.Forms;

namespace Main.View
{
    public partial class StudentView : ContentPage
    {
        Students studentsList;

        public StudentView()
        {
            InitializeComponent();
            studentsList = new Students();
            studentsList.studentsList.Add(Student.GetStudent());
            StudentsView.ItemsSource = studentsList.studentsList;
            StudentsView.IsPullToRefreshEnabled = true;

        }


        public void btnNew_Clicked(object sender, EventArgs e){
            Navigation.PushAsync(new NewStudentView(studentsList.studentsList));
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e){
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
        }

        public void OnMore(object sender, EventArgs e){
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e){
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }
    }
}
