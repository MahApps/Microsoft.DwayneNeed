using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilePairingBacklog.Models
{
    public class Task : ModelBase
    {
        private string name = string.Empty;
        private string description = string.Empty;
        private TaskStatus status = TaskStatus.Proposed;
        private ObservableCollection<Pairing> pairings = new ObservableCollection<Pairing>(); // this should really be a filter!

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                base.SetValue("Name", ref this.name, value);
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                base.SetValue("Description", ref this.description, value);
            }
        }

        public TaskStatus Status
        {
            get
            {
                return this.status;
            }

            set
            {
                base.SetValue("Status", ref this.status, value);
            }
        }

        public ObservableCollection<Pairing> Pairings
        {
            get
            {
                return this.pairings;
            }
        }
    }
}
