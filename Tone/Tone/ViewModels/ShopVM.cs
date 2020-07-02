using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Tone.Models;
using Tone.Views;
using Xamarin.Forms;

namespace Tone.ViewModels
{
    public class ShopVM
    {
        public ObservableCollection<ProductModel> ProductsList { get; set; }
        public ShopVM()
        {
            ProductsList = new ObservableCollection<ProductModel>();
            ProductsList.Add(new ProductModel()
            {
                ID = 1,
                Name = "Cras",
                Price = "15,00",
                Image = "https://ft.agency/tone/wp-content/uploads/2020/05/DSC_0847-scaled.jpg" 
            });
            ProductsList.Add(new ProductModel()
            {
                ID = 2,
                Name = "Cras mauris",
                Price = "15,00",
                Image = "https://ft.agency/tone/wp-content/uploads/2013/06/DSC_0815-copy-scaled.jpg"
            });
            ProductsList.Add(new ProductModel()
            {
                ID = 3,
                Name = "Mauris",
                Price = "15,00",
                Image ="https://ft.agency/tone/wp-content/uploads/2020/05/dfh-scaled.jpg" 
            });
        }
    }
}
