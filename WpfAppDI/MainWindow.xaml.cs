using System.Windows;
using TestLibrary;
using WpfAppDI.StartupHelpers;

namespace WpfAppDI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IDataAcess dataAcess;
    private readonly IAbstractFactory<ChildForm> factory;

    public MainWindow(IDataAcess dataAcess, IAbstractFactory<ChildForm> factory)
    {
        InitializeComponent();
        this.dataAcess = dataAcess;
        this.factory = factory;
    }

    private void getData_Click(object sender, RoutedEventArgs e)
    {
        Data.Text = dataAcess.GetData();
    }

    private void getChildForm_Click(object sender, RoutedEventArgs e)
    {
        factory.Create().Show();
    }

    // https://www.youtube.com/watch?v=dLR_D2IJE1M 24:39
}
