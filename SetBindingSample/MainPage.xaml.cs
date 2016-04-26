using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SetBindingSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void myBtn_Click(object sender, RoutedEventArgs e)
        {
            var binding = new Binding();
            bool ischecked = true;
            binding.Path = new PropertyPath("IsChecked");
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding.Mode = BindingMode.TwoWay;
            BindingSource source = new BindingSource
            {
                 IsChecked=true,
                 Name="Test Binding Source"
            };
            binding.Source = source;
            myCB.SetBinding(CheckBox.IsCheckedProperty, binding);
        }
    }

    class BindingSource
    {
        public bool IsChecked { get; set; }
        public String Name { get; set; }
    }
}
