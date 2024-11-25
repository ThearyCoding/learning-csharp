using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_OOP
{
    public abstract class Action : IAction
    {
        public virtual void Display()
        {
            throw new NotImplementedException();
        }
        public virtual void Add()
        {
            throw new NotImplementedException();
        }

        public virtual void Delete()
        {
            throw new NotImplementedException();
        }


        public virtual void Search()
        {
            throw new NotImplementedException();
        }

        public virtual void Update()
        {
            throw new NotImplementedException();
        }

        public virtual string Login()
        {
            throw new NotImplementedException();
        }
    }
}
