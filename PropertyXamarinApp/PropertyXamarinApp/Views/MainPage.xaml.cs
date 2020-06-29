using PropertyXamarinApp.Models;
using PropertyXamarinApp.Views;
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
            return new List<PropertyType> 
            {
               new PropertyType{TypeName = "All" },
               new PropertyType{TypeName = "Studio" },
               new PropertyType{TypeName = "4 Bed" },
               new PropertyType{TypeName = "3 Bed" },
               new PropertyType{TypeName = "Office" },
            };
        }

        private List<Property> GetProperties()
        {
            return new List<Property> 
            {
               new Property{ Image = "apt1.png", Address = "Flat 9 Treves House", Location = "London", Price = "1500/mo", 
                             Bed = "4 Bed", Bath = "3 Bath" , Space = "1600 Metros", Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
               new Property { Image = "apt2.png", Address = "2168 Cushions Dr, LA", Location = "Califonia", Price = "$1000/mo", 
                              Bed = "3 Bed", Bath = "1 Bath", Space = "1100 sqft", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
               new Property { Image = "apt3.png", Address = "2112 Anthony Way, LA", Location = "Califonia", Price = "$900/mo", 
                              Bed = "2 Bed", Bath = "2 Bath", Space = "1200 sqft", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
            };
        }

        private async void PropertySelected(object sender, EventArgs e)
        {
            var property = (sender as View).BindingContext as Property;
            await Navigation.PushAsync(new DetailsPage(property));
        }

        private void SelectStates(object sender, EventArgs e)
        {
            var view = sender as View;
            var parent = view.Parent as StackLayout;

            foreach (var child in parent.Children)
            {
                VisualStateManager.GoToState(child, "Normal");
                ChangeTextColor(child, "#707070");
            }

            VisualStateManager.GoToState(view, "Selected");
            ChangeTextColor(view, "#fe93c5");

        }

        private void ChangeTextColor(View child, string hexColor)
        {
            var txtControl = child.FindByName<Label>("PropertyTypeName");
            if (txtControl != null)
            {
                txtControl.TextColor = Color.FromHex(hexColor);
            }
        }
    }
}
