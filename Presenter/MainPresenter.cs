using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetM.Presenter
{
    class MainPresenter : Observer
    {
        public override void Update()
        {
            Console.WriteLine("updated");
        }
    }
}
