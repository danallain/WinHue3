﻿using MahApps.Metro.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using WinHue3.Philips_Hue.BridgeObject;

namespace WinHue3.Functions.BridgePairing
{
    /// <summary>
    /// Interaction logic for Form_BridgeDetectionPairing.xaml
    /// </summary>
    public partial class Form_BridgeDetectionPairing : MetroWindow
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private BridgePairingViewModel _bpvm;

        public Form_BridgeDetectionPairing(ObservableCollection<Bridge> listBridges = null)
        {
            InitializeComponent();
            _bpvm = this.DataContext as BridgePairingViewModel;
            if (listBridges != null)
                _bpvm.ListBridges = listBridges;
        }

        public BridgePairingViewModel ViewModel => _bpvm;

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
