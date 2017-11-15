using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Main.Model;
using Xamarin.Forms;

namespace Main.View
{
    public partial class NewStudentView : ContentPage
    {
        ObservableCollection<Student> studentsList;

        public NewStudentView(ObservableCollection<Student> studentsList)
        {
            this.studentsList = studentsList;
            InitializeComponent();
        }


        public void btnSave_Clicked(object sender, EventArgs e){
            Student student = new Student()
            {
                Id = Guid.NewGuid(),
                RM = txtRM.Text,
                Name = txtName.Text,
                Mail = txtMail.Text
            };
            studentsList.Add(student);
            Navigation.PopAsync();
        }
    }
}
