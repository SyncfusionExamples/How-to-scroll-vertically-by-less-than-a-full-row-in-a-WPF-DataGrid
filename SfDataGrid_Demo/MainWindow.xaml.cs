using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.ScrollAxis;
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
using  Syncfusion.UI.Xaml.ScrollAxis;
using ScrollChangedEventArgs = System.Windows.Controls.ScrollChangedEventArgs;

namespace SfDataGrid_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {      
        
        public MainWindow()
        {
            InitializeComponent();
            sfDataGrid.Loaded += OnLoaded;            
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            this.sfDataGrid.GetVisualContainer().ScrollOwner.ScrollChanged += OnScrollChanged;          
        }
      
        private void OnScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (e.VerticalChange == 24)
            {
                if (e.VerticalChange > 0)
                {                    
                    // Here customize based on your scenario
                    double newOffset = e.VerticalOffset - 12;
                    this.sfDataGrid.GetVisualContainer().SetVerticalOffset(newOffset);
                }
            }
            if (e.VerticalChange == -24)
            {
                if (e.VerticalChange < 0)
                {
                    // // Here customize based on your scenario
                    double newOffset = e.VerticalOffset + 12;
                    this.sfDataGrid.GetVisualContainer().SetVerticalOffset(newOffset);
                }
            }
        }
    }
}
