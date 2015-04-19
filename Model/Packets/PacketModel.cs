using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetM.Model.Packets
{
    class PacketModel : IPacketModel
    {
        public event EventHandler newPacket;

        private void onNewPacket(NewPacketEventArgs args)
        {
            if(newPacket != null)
            {
                newPacket(this, args);
            }
        }
    }
}
