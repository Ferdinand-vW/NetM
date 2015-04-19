using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetM.Model.Packets
{
    class NewPacketEventArgs : EventArgs
    {
        public Packet packet { get; set; }
    }
}
