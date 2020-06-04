using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navigationapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navigations : TabbedPage
    {
        public Navigations()
        {
            InitializeComponent();
        }
        
    }
}