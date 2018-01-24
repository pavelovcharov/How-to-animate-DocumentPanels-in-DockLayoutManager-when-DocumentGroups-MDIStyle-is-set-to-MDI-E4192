// Developer Express Code Central Example:
// How to enable MDI mode for a DocumentGroup
// 
// In this example, MDI mode is enabled for a DocumentGroup via the MDIStyle
// property. In this mode, the DocumentGroup's panels are represented as floating
// windows.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2190

using System;
using System.Collections.Generic;
using System.Linq;
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
using DevExpress.Xpf.Docking.VisualElements;
using DevExpress.Xpf.Docking;

namespace DocumentGroup_MDI_Ex {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            MDIDocument d = new MDIDocument();
            DocumentPanel dp = new DocumentPanel();
            LayoutPanel lp = new LayoutPanel();
        }

        private void PART_CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void PART_Button_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
