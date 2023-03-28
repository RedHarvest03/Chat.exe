using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace SimpleChat;

public partial class MainWindow : Window
{
    private List<string> messages = new List<string>();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnSend_Click(object sender, RoutedEventArgs e)
    {
        string message = txtMessage.Text;
        messages.Add(message);
        lstChat.Items.Add(message);
        txtMessage.Text = "";
    }
}

