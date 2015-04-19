using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetM.Model;
using NetM.Model.Packets;
using NetM.Presenter.Packets;
using NetM.View;

namespace NetM.Presenter
{
    class MainPresenter : IMainPresenter
    {
        //Models
        IPacketModel packetModel;

        //Presenters
        IPacketPresenter packetPresenter;

        public MainPresenter(MainWindow mainWindow)
        {
            //initialize models
            packetModel = new PacketModel();

            //initialize presenters and pass model and view to presenter
            packetPresenter = new PacketPresenter(packetModel, mainWindow.PacketView);

            //bind presenters to models
            packetModel.newPacket += new EventHandler(packetPresenter.OnNewPacket);
        }
    }
}
