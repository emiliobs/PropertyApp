using PropertyXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PropertyXamarinApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<PropertyType> propertyTypesList => GetPropertyType();
        public List<Property> PropertyList => GetProperties();      

        private List<PropertyType> GetPropertyType()
        {
            throw new NotImplementedException();
        }

        private List<Property> GetProperties()
        {
            throw new NotImplementedException();
        }
    }
}
