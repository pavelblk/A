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
using System.Xml;
using System.Xml.Linq;

namespace IKIW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            A();
            //InitializeComponent();




        }

        public void A()
        {

            var g = "";
            using (XmlReader reader = XmlReader.Create(@"D:\IKIW.xml"))
            {
                reader.MoveToContent();

                while (!reader.EOF)
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "page")
                    {
                        XElement el = XElement.ReadFrom(reader) as XElement;
                        if (el != null)
                        {

                        }
                        // yield return el;
                    }
                    else
                    {
                        reader.Read();
                    }
                }
            }
        }
    }
}
