using App4.Assets;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<employee> employees = new ObservableCollection<employee>();
        public MainPage()
        {
            this.employees.Add(new employee() { FirstName = "FirstName" });
            this.employees.Add(new employee() { LastName = "LastName" });
            this.employees.Add(new employee() { PhoneNumber = "Phone" });
            this.employees.Add(new employee() { Email = "Email" });
            this.InitializeComponent();

        }

        internal ObservableCollection<employee> Employees { get => employees; set => employees = value; }
    }
}
