using ShopInterface1.Models;


namespace ShopInterface1.Services;

public class CartService
{
    public List<CartItem> Items { get; } = new();

    public event Action? OnChange;

    public void AddToCart(Product product)
    {
        var item = Items.FirstOrDefault(
            x => x.Product.Id == product.Id
        );

        if (item == null)
        {
            Items.Add(new CartItem
            {
                Product = product,
                Quantity = 1
            });
        }
        else
        {
            item.Quantity++;
        }

        NotifyStateChanged();
    }

    public void IncreaseQuantity(CartItem item)
    {
        item.Quantity++;

        NotifyStateChanged();
    }

    public void DecreaseQuantity(CartItem item)
    {
        item.Quantity--;

        if (item.Quantity <= 0)
        {
            Items.Remove(item);
        }

        NotifyStateChanged();
    }

    public void RemoveItem(CartItem item)
    {
        Items.Remove(item);

        NotifyStateChanged();
    }

    public int GetTotalQuantity()
    {
        return Items.Sum(x => x.Quantity);
    }

    public decimal GetTotalPrice()
    {
        return Items.Sum(
            x => x.Product.Price * x.Quantity
        );
    }

    private void NotifyStateChanged()
    {
        OnChange?.Invoke();
    }
}