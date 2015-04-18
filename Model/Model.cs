using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetM.Presenter;

namespace NetM.Model
{
    class Model : IModel
    {
        List<Observable> observers;

        public Model()
        {
            observers = new List<Observable>();
        }

        public override void Subscribe(Observable presenter)
        {
            observers.Add(presenter);
        }

        public override void Unsubscribe(Observable presenter)
        {
            observers.Remove(presenter);
        }
    }
}
