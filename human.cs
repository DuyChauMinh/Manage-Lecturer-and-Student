using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    abstract class human
    {
        protected string ID, Name, Email, Address, DoB; 
        public human()
        {

        }
        public human(string ID, string Name, string Email, string Address, string DoB)
        {
            this.ID = ID;
            this.Name = Name;
            this.Email = Email;
            this.Address = Address;
            this.DoB = DoB;
        }
        public abstract void Add();
        public abstract void View();
        public abstract void Search();
        public abstract void Delete();
        public abstract void Update();
        public abstract void Back();
    }
}
