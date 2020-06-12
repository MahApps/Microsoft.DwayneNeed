using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilePairingBacklog.Models
{
    public class Person : ModelBase
    {
        private string id = String.Empty;
        private string name = string.Empty;
        private string role = string.Empty;
        private ObservableCollection<Pairing> pairings = new ObservableCollection<Pairing>();// this should really be a filter!

        public string Id
        {
            get
            {
                return this.name;
            }

            set
            {
                base.SetValue("Id", ref this.id, value);
            }
        }

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

        public string Role
        {
            get
            {
                return this.role;
            }

            set
            {
                base.SetValue("Role", ref this.role, value);
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
