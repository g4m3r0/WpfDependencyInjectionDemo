using System.Windows;
using TestLibrary;

namespace WpfAppDI;

/// <summary>
/// Interaction logic for ChildForm.xaml
/// </summary>
public partial class ChildForm : Window
{
    private readonly IDataAcess dataAcess;

    public ChildForm(IDataAcess dataAcess)
    {
        InitializeComponent();
        this.dataAcess = dataAcess;
        dataAccessInfo.Text = dataAcess.GetData();
    }
}
