using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetM.Model.Packets;
using NetM.View;

namespace NetM.Presenter.Packets
{
    class PacketPresenter : IPacketPresenter
    {
        IPacketModel packetModel;
        IPacketView packetView;

        public PacketPresenter(IPacketModel packetModel, IPacketView packetView)
        {
            this.packetModel = packetModel;
        }

        public void OnNewPacket(object obj, EventArgs args)
        {

        }
    }
}
