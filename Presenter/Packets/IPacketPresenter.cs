﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetM.Presenter.Packets
{
    interface IPacketPresenter
    {
        void OnNewPacket(object obj, EventArgs args);
    }
}