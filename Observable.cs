using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetM.Presenter;

namespace NetM
{
    abstract class Observable
    {
        public delegate void Update();
        public event Update onUpdate = null;

        public void Subscribe(Observer observer)
        {
            onUpdate += new Update(observer.update);
        }

        public void Subscribe(Observer observer)
        {
            onUpdate -= new Update(observer.update);
        }

    }
}
