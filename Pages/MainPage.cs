using hackday_maui_reactor.Pages.Components;
using hackday_maui_reactor.Services;
using MauiReactor;

namespace hackday_maui_reactor.Pages
{
    internal class MainPage : Component
    {
        public override VisualNode Render() =>
            new ContentPage
            {
                new ScrollView
                {
                    new VStack
                    {
                        new CategoryComponents { Categories = DataService.Instance.Categories },
                        new BestSellingComponent
                        {
                            Products = DataService.Instance.BestSelling,
                            Title = "Best Selling"
                        },
                        new BrandComponent
                        {
                            Products = DataService.Instance.Brands,
                            Title = "Brands"
                        },
                    }.HorizontalOptions(Microsoft.Maui.Controls.LayoutOptions.FillAndExpand)
                }
            };
    }
}
