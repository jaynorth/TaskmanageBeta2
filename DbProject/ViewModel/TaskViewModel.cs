using Business.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.ViewModel
{
    public class TaskViewModel : ConnectionDB
    {

        private List<Task> _taskList;

        public List<Task> TaskList
        {
            get { return _taskList; }
            set { _taskList = value; }
        }

        private Task _selectedTask;

        public Task SelectedTask
        {   
            get { return _selectedTask; }
            set { _selectedTask = value; }
        }


        public TaskViewModel()
        {

        }



    }
}
