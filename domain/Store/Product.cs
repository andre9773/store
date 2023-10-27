namespace Store;

public class Product
{   
    public Guid Id { get; set; }

    public string Title { get;} = string.Empty;

    public string DunnceStoreLink { get; } = string.Empty;

    public string AldiStoreLink { get; } = string.Empty;

    public string LidlStoreLink { get; } = string.Empty;

    public double DunnceStorePrice { get; }

    public double AldiStorePrice { get; }

    public double LidlStorePrice { get; }

    public string Description { get; } = string.Empty;


    public Product(Guid id, string title, string dunnceStoreLink, string aldiStoreLink, string lidlStoreLink, double dunnceStorePrice, double aldiStorePrice, double lidlStorePrice, string description)
    {
        Id = id;
        Title = title;
        DunnceStoreLink = dunnceStoreLink;
        AldiStoreLink = aldiStoreLink;
        LidlStoreLink = lidlStoreLink;
        DunnceStorePrice = dunnceStorePrice;
        AldiStorePrice = aldiStorePrice;
        LidlStorePrice = lidlStorePrice;
        Description = description;
    }
}
