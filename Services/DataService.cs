using hackday_maui_reactor.Models;
using System.Collections.ObjectModel;

namespace hackday_maui_reactor.Services
{
    internal class DataService
    {
        const string baseUrl = "https://mobilespire.commerce.insitesandbox.com/";
        static DataService _instance;

        public static DataService Instance => _instance ??= new DataService();
        public ObservableCollection<CategoryModel> Categories =>
            new()
            {
                new CategoryModel()
                {
                    CategoryID = 1,
                    CategoryName = "Quick Order",
                    Icon = "quickorder.png"
                },
                new CategoryModel()
                {
                    CategoryID = 2,
                    CategoryName = "Shop Brands",
                    Icon = "brands.png"
                },
                new CategoryModel()
                {
                    CategoryID = 4,
                    CategoryName = "Shop Categories",
                    Icon = "shopcategories.png"
                },
                new CategoryModel()
                {
                    CategoryID = 5,
                    CategoryName = "Settings",
                    Icon = "settings.png"
                },
                new CategoryModel()
                {
                    CategoryID = 1,
                    CategoryName = "Quick Order",
                    Icon = "quickorder.png"
                },
                new CategoryModel()
                {
                    CategoryID = 2,
                    CategoryName = "Shop Brands",
                    Icon = "brands.png"
                },
                new CategoryModel()
                {
                    CategoryID = 4,
                    CategoryName = "Shop Categories",
                    Icon = "shopcategories.png"
                },
                new CategoryModel()
                {
                    CategoryID = 5,
                    CategoryName = "Settings",
                    Icon = "settings.png"
                },
            };

        public ObservableCollection<ProductListModel> BestSelling =>
            new()
            {
                new ProductListModel()
                {
                    Name = "\"18V Cordless 2\\u0022 18 Gauge Brad Nailer",
                    BrandName = "Bang and Olufsen",
                    Price = "$755",
                    ImageUrl = $"{baseUrl}/UserFiles/images/PowerTools/HAM719-300x300.jpg"
                },
                new ProductListModel()
                {
                    Name = "20V Max* Dual Speed Framing Nailer - FIXED CONFIGURATION",
                    BrandName = "Tag Heuer",
                    Price = "$450",
                    ImageUrl = $"{baseUrl}/UserFiles/images/PowerTools/HWC9871-300x300.jpg"
                },
                new ProductListModel()
                {
                    Name = "12v Max - 20v Max Lithium Ion Battery Charger",
                    BrandName = "Google LLC",
                    Price = "$900",
                    ImageUrl =
                        $"{baseUrl}/userfiles/images/accessories/hbb744-300x300.jpg?width=250\u0026height=250"
                },
                new ProductListModel()
                {
                    Name = "20V Max* Brushless Impact Driver Kit",
                    BrandName = "Smart Inc",
                    Price = "$1200",
                    ImageUrl = $"{baseUrl}/UserFiles/images/PowerTools/HEG765C1-300x300.jpg"
                },
                new ProductListModel()
                {
                    Name = "\"18V Cordless 2\\u0022 18 Gauge Brad Nailer",
                    BrandName = "Bang and Olufsen",
                    Price = "$755",
                    ImageUrl = $"{baseUrl}/UserFiles/images/PowerTools/HAM719-300x300.jpg"
                },
                new ProductListModel()
                {
                    Name = "20V Max* Dual Speed Framing Nailer - FIXED CONFIGURATION",
                    BrandName = "Tag Heuer",
                    Price = "$450",
                    ImageUrl = $"{baseUrl}/UserFiles/images/PowerTools/HWC9871-300x300.jpg"
                },
                new ProductListModel()
                {
                    Name = "12v Max - 20v Max Lithium Ion Battery Charger",
                    BrandName = "Google LLC",
                    Price = "$900",
                    ImageUrl =
                        $"{baseUrl}/userfiles/images/accessories/hbb744-300x300.jpg?width=250\u0026height=250"
                },
                new ProductListModel()
                {
                    Name = "20V Max* Brushless Impact Driver Kit",
                    BrandName = "Smart Inc",
                    Price = "$1200",
                    ImageUrl = $"{baseUrl}/UserFiles/images/PowerTools/HEG765C1-300x300.jpg"
                }
            };

        public ObservableCollection<ProductListModel> Products =>
            new()
            {
                new ProductListModel()
                {
                    Name = "\"18V Cordless 2\\u0022 18 Gauge Brad Nailer",
                    BrandName = "Bang and Olufsen",
                    Price = "$755",
                    ImageUrl = $"{baseUrl}/UserFiles/images/PowerTools/HAM719-300x300.jpg"
                },
                new ProductListModel()
                {
                    Name = "20V Max* Dual Speed Framing Nailer - FIXED CONFIGURATION",
                    BrandName = "Tag Heuer",
                    Price = "$450",
                    ImageUrl = $"{baseUrl}/UserFiles/images/PowerTools/HWC9871-300x300.jpg"
                },
                new ProductListModel()
                {
                    Name = "12v Max - 20v Max Lithium Ion Battery Charger",
                    BrandName = "Google LLC",
                    Price = "$900",
                    ImageUrl =
                        $"{baseUrl}/userfiles/images/accessories/hbb744-300x300.jpg?width=250\u0026height=250"
                },
                new ProductListModel()
                {
                    Name = "20V Max* Brushless Impact Driver Kit",
                    BrandName = "Smart Inc",
                    Price = "$1200",
                    ImageUrl = $"{baseUrl}/UserFiles/images/PowerTools/HEG765C1-300x300.jpg"
                }
            };

        public ObservableCollection<ProductListModel> Brands =>
            new()
            {
                new ProductListModel()
                {
                    BrandName = "BBK Electronics",
                    Details = "5693 Products",
                    ImageUrl = $"{baseUrl}/Userfiles/images/brands/logo-bbk-150x150.png"
                },
                new ProductListModel()
                {
                    BrandName = "DN HVAC",
                    Details = "1124 Products",
                    ImageUrl = $"{baseUrl}/Userfiles/images/brands/logo-dnhvac-150x150.png"
                },
                new ProductListModel()
                {
                    BrandName = "Hero Manufacturing",
                    Details = "5693 Products",
                    ImageUrl = $"{baseUrl}/UserFiles/images/brands/logo-hero-150x150.png"
                }
            };
    }
}
