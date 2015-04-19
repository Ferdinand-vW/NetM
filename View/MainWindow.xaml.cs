using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using NetM.Model;
using NetM.Presenter;

namespace NetM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IPacketView packetView;
        IMainPresenter mainPresenter;

        public MainWindow()
        {
            InitializeComponent();

            packetView = new PacketView();
            this.Content = packetView;
            mainPresenter = new MainPresenter(this);
        } 
      
        public IPacketView PacketView
        {
            get { return packetView; }
        }
    }
}
