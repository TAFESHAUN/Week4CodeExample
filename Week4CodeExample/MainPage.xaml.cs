using Week4CodeExample.Libs;

namespace Week4CodeExample
{
    public partial class MainPage : ContentPage
    {
        //MainpageViewmodel
        public MainPage()
        {
            InitializeComponent();

            var products = ImportCSV.ReadProductsFromCsv("products.csv");

            //Set the data binding context of products to our list view and cell template
            productListView.ItemsSource = products;
            //productListView2.ItemsSource = products;
        }

    }

}
