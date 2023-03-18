using hackday_maui_reactor.Models;
using MauiReactor;
using MauiReactor.Shapes;
using System.Collections.ObjectModel;

namespace hackday_maui_reactor.Pages.Components
{
    internal class BestSellingComponent : Component
    {
        public ObservableCollection<ProductListModel> Products;
        public string Title;

        public override VisualNode Render()
        {
            return new VStack
            {
                new HStack
                {
                    new Label(this.Title)
                        .FontAttributes(Microsoft.Maui.Controls.FontAttributes.Bold)
                        .FontSize(16)
                        .TextColor(Colors.Black)
                        .HStart()
                        .HorizontalTextAlignment(TextAlignment.Start)
                        .BackgroundColor(Colors.Transparent)
                        .VerticalOptions(Microsoft.Maui.Controls.LayoutOptions.Center),
                    new Button("View All")
                        .BackgroundColor(Colors.Transparent)
                        .FontSize(16)
                        .TextColor(Colors.Black)
                        .HEnd()
                        .VerticalOptions(Microsoft.Maui.Controls.LayoutOptions.End),
                },
                new CollectionView()
                    .ItemsSource(this.Products, RenderItem)
                    .Margin(new Thickness(0, 12))
                    .ItemsLayout(new HorizontalGridItemsLayout().HorizontalItemSpacing(12).Span(2))
                    .HorizontalOptions(Microsoft.Maui.Controls.LayoutOptions.FillAndExpand)
            }.Margin(12).HorizontalOptions(Microsoft.Maui.Controls.LayoutOptions.CenterAndExpand);
        }

        private VisualNode RenderItem(ProductListModel item) =>
            new VStack
            {
                new Border
                {
                    new Image(item.ImageUrl)
                        .HeightRequest(240)
                        .WidthRequest(165)
                        .Aspect(Aspect.AspectFit),
                }
                    .Margin(new Thickness(0))
                    .Padding(new Thickness(0))
                    .StrokeShape(new RoundRectangle().CornerRadius(6, 0, 0, 6))
                    .StrokeThickness(1),
                new VStack
                {
                    new Label(item.Name)
                        .FontSize(16)
                        .TextColor(Colors.Black)
                        .LineBreakMode(LineBreakMode.WordWrap)
                        .HCenter()
                        .MaxLines(3)
                        .HorizontalTextAlignment(TextAlignment.Center)
                        .VerticalOptions(Microsoft.Maui.Controls.LayoutOptions.Start),
                    new Label(item.BrandName)
                        .FontSize(12)
                        .TextColor(Color.FromHex("#929292"))
                        .HCenter()
                        .HorizontalTextAlignment(TextAlignment.Center)
                        .VerticalOptions(Microsoft.Maui.Controls.LayoutOptions.Start),
                    new Label(item.Price)
                        .FontSize(16)
                        .TextColor(Color.FromHex("#00C569"))
                        .HCenter()
                        .HorizontalTextAlignment(TextAlignment.Center)
                        .VerticalOptions(Microsoft.Maui.Controls.LayoutOptions.Start)
                }.Margin(new Thickness(0, 8, 0, 0))
            }
                .HStart()
                .WidthRequest(180)
                .Margin(new Thickness(6));
    }
}
