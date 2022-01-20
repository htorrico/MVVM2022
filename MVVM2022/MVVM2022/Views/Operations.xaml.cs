using MVVM2022.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM2022.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operations : ContentPage
    {
        public Operations()
        {
            InitializeComponent();
            this.BindingContext = new OperationsViewModel();
        }
    }
}