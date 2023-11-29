using Laba11.Models;
namespace Laba11.ViewModels.HomeViewModels
{
    public enum ShowStyles
    {
        List,
        Table,
        Row
    }
    public record class ShowOrdersViewModel(IEnumerable<Order> Orders, ShowStyles ShowStyle);
}

