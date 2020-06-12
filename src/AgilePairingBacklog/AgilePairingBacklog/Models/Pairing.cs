using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilePairingBacklog.Models
{
    public class Pairing : ModelBase
    {
        private Person firstPerson;
        private Person secondPerson;
        private Task task;

        public Person FirstPerson
        {
            get
            {
                return this.firstPerson;
            }

            set
            {
                base.SetValue("FirstPerson", ref this.firstPerson, value);
            }
        }

        public Person SecondPerson
        {
            get
            {
                return this.secondPerson;
            }

            set
            {
                base.SetValue("SecondPerson", ref this.secondPerson, value);
            }
        }

        public Task Task
        {
            get
            {
                return this.task;
            }

            set
            {
                base.SetValue("Task", ref this.task, value);
            }
        }
    }
}
