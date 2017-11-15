using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Main.Model
{
    public class Students
    {
        public ObservableCollection<Student> studentsList { get; set; }

        public Students()
        {
            studentsList = new ObservableCollection<Student>();
        }


    }
}
