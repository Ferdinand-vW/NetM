﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetM.Presenter
{
    interface IPresenter : Observer
    {
        public override void update();
    }
}