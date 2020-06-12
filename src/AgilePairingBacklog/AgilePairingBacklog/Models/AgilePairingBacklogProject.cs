using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilePairingBacklog.Models
{
    public class AgilePairingBacklogProject : ModelBase
    {
        private ObservableCollection<Person> teamMembers = new ObservableCollection<Person>();
        private ObservableCollection<Task> tasks = new ObservableCollection<Task>();

        public ObservableCollection<Person> TeamMembers
        {
            get
            {
                return this.teamMembers;
            }
        }

        public ObservableCollection<Task> Tasks
        {
            get
            {
                return this.tasks;
            }
        }
    }
}
