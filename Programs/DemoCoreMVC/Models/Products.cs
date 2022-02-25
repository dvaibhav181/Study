public class Products
{
    public int _productId {get; set;}
    public string _name {get; set;}

    public Products(int Id, string Name)
    {
        this._productId = Id;
        this._name = Name;
    }
}