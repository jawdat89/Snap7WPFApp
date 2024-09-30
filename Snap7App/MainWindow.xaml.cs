using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Snap7App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Sharp7.S7Client Client;
        public static int Rack = 0;
        public static int Slot = 1;
        public static bool Connection = false;
        public static string IP = "192.168.0.100";

        public MainWindow()
        {
            InitializeComponent();

            Client = new Sharp7.S7Client();
        }

        private void ConnectPLC(object sender, RoutedEventArgs e)
        {
            try
            {
                int Result = Client.ConnectTo(IP, Rack, Slot);
                if (Result == 0)
                {
                    //MessageBox.Show("Connected to PLC");
                    Connection = true;

                    // Adjust buttons
                    ConnectButton.IsEnabled = false;
                    DisconnectButton.IsEnabled = true;

                    // Update status
                    ConnectionStatus.Foreground = Brushes.Green;
                    ConnectionStatus.Text = $"Connected to: {IP}";
                }
                else
                {
                    //MessageBox.Show("Failed to connect to PLC");
                    Connection = false;
                    // Adjust Toolstrip buttons
                    ConnectButton.IsEnabled = true;
                    DisconnectButton.IsEnabled = false;

                    // Update status
                    ConnectionStatus.Foreground = Brushes.Red;
                    ConnectionStatus.Text = "PLC Connection Error";

                    // TODO: Add error log 
                    // ErrorLog($"Connection failed: {IP} {Client.ErrorText(Result)}")

                    MessageBox.Show($"Connection failed: {IP}  {Client.ErrorText(Result)}", null, button: MessageBoxButton.OK);
                }
            }
            catch (Exception ex)
            {
                Connection = false;
                // Adjust Toolstrip buttons
                ConnectButton.IsEnabled = true;
                DisconnectButton.IsEnabled = false;

                // Update status
                ConnectionStatus.Foreground = Brushes.Red;
                ConnectionStatus.Text = "PLC Connection Error";

                // TODO: Add error log 
                // ErrorLog($"Connection failed: {IP} {Client.ErrorText(Result)}")

                MessageBox.Show($"Connection failed: {IP}  {ex.Message}", null, button: MessageBoxButton.OK);
            }
        }

        private void DisconnectPLC(object sender, RoutedEventArgs e)
        {
            try
            {
                Client.Disconnect();
                Connection = false;

                // Adjust Toolstrip buttons
                ConnectButton.IsEnabled = true;
                DisconnectButton.IsEnabled = false;

                // Update status
                ConnectionStatus.Foreground = Brushes.Red;
                ConnectionStatus.Text = "Disconnected";
            }
            catch (Exception ex)
            {
                Connection = false;
                // Adjust Toolstrip buttons
                ConnectButton.IsEnabled = true;
                DisconnectButton.IsEnabled = false;

                // Update status
                ConnectionStatus.Foreground = Brushes.Red;
                ConnectionStatus.Text = "PLC Disconnection Error";

                // TODO: Add error log 
                // ErrorLog($"Connection failed: {IP} {ex.Message}")

                MessageBox.Show($"Connection failed: {IP}  {ex.Message}", null, button: MessageBoxButton.OK);
            }
        }
    }
}