using hackday_maui_reactor.Models;
using MauiReactor;
using MauiReactor.Shapes;
using System.Collections.ObjectModel;

namespace hackday_maui_reactor.Pages.Components
{
    internal class CategoryComponents : Component
    {
        public ObservableCollection<CategoryModel> Categories;

        public override VisualNode Render()
        {
            return new VStack
            {
                new CollectionView()
                    .ItemsSource(this.Categories, RenderItem)
                    .Margin(new Thickness(10, 16))
                    .ItemsLayout(
                        new HorizontalGridItemsLayout()
                            .Span(1)
                            .HorizontalItemSpacing(12)
                            .VerticalItemSpacing(0)
                    )
                    .SelectionMode(Microsoft.Maui.Controls.SelectionMode.Single)
                    .HorizontalScrollBarVisibility(ScrollBarVisibility.Always)
                    .HorizontalOptions(Microsoft.Maui.Controls.LayoutOptions.FillAndExpand)
            }
                .Margin(0, 12)
                .HorizontalOptions(Microsoft.Maui.Controls.LayoutOptions.CenterAndExpand);
        }

        private VisualNode RenderItem(CategoryModel item) =>
            new VStack
            {
                new Border
                {
                    new Image(item.Icon).Aspect(Aspect.AspectFit).HeightRequest(45).WidthRequest(45)
                }
                    .Margin(new Thickness(0, 4))
                    .Padding(new Thickness(12))
                    .Background(Colors.White)
                    .HeightRequest(60)
                    .WidthRequest(60)
                    .Stroke(Colors.Gray)
                    .StrokeShape(new RoundRectangle().CornerRadius(30))
                    .HCenter()
                    .VCenter(),
                new Label(item.CategoryName)
                    .FontSize(14)
                    .TextColor(Colors.Black)
                    .LineBreakMode(LineBreakMode.WordWrap)
                    .HCenter()
                    .HorizontalTextAlignment(TextAlignment.Center)
                    .VerticalOptions(Microsoft.Maui.Controls.LayoutOptions.EndAndExpand)
            };
    }
}
