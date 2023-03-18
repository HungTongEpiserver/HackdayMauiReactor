using hackday_maui_reactor.Models;
using MauiReactor;
using MauiReactor.Compatibility;
using MauiReactor.Shapes;
using System.Collections.ObjectModel;

namespace hackday_maui_reactor.Pages.Components
{
    internal class BrandComponent : Component
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
                        .Margin(0, 12)
                        .TextColor(Colors.Black)
                        .HStart()
                        .HorizontalTextAlignment(TextAlignment.Start)
                        .VerticalOptions(Microsoft.Maui.Controls.LayoutOptions.Center),
                },
                new CollectionView()
                    .ItemsSource(this.Products, RenderItem)
                    .Margin(new Thickness(0, 10))
                    .ItemsLayout(new HorizontalGridItemsLayout().HorizontalItemSpacing(12).Span(1))
                    .HorizontalOptions(Microsoft.Maui.Controls.LayoutOptions.FillAndExpand)
            }.Margin(12).HorizontalOptions(Microsoft.Maui.Controls.LayoutOptions.CenterAndExpand);
        }

        private VisualNode RenderItem(ProductListModel item) => new VStack { new Border
                {
                    new HStack
                    {
                        new Border
                        {
                            new Image(item.ImageUrl)
                                .HeightRequest(240)
                                .WidthRequest(165)
                                .Aspect(Aspect.AspectFit)
                                .HorizontalOptions(
                                    Microsoft.Maui.Controls.LayoutOptions.CenterAndExpand
                                )
                                .VerticalOptions(
                                    Microsoft.Maui.Controls.LayoutOptions.CenterAndExpand
                                ),
                        }
                            .Padding(0)
                            .StrokeShape(new RoundRectangle().CornerRadius(20))
                            .Opacity(10)
                            .WidthRequest(40)
                            .HeightRequest(40),
                        new VStack
                        {
                            new Label(item.BrandName)
                                .FontSize(16)
                                .TextColor(Colors.Black)
                                .LineBreakMode(LineBreakMode.WordWrap)
                                .HCenter()
                                .MaxLines(2)
                                .HorizontalTextAlignment(TextAlignment.Center)
                                .VerticalOptions(Microsoft.Maui.Controls.LayoutOptions.Start),
                            new Label(item.Details)
                                .FontSize(12)
                                .TextColor(Color.FromHex("#929292"))
                                .HCenter()
                                .HorizontalTextAlignment(TextAlignment.Center)
                                .VerticalOptions(Microsoft.Maui.Controls.LayoutOptions.Start),
                        }.Margin(0, 8),
                    }
                }.WidthRequest(220).Margin(new Thickness(0)).Padding(new Thickness(16, 8)).StrokeShape(new RoundRectangle().CornerRadius(6)).StrokeThickness(1).HorizontalOptions(Microsoft.Maui.Controls.LayoutOptions.CenterAndExpand), }.HStart().Margin(new Thickness(6));
    }
}
