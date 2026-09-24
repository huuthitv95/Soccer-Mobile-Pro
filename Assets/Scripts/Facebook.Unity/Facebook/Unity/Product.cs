namespace Facebook.Unity
{
	public class Product
	{
		public string Title { get; private set; }

		public string ProductID { get; private set; }

		public string Description { get; private set; }

		public string ImageURI { get; private set; }

		public string Price { get; private set; }

		public string PriceCurrencyCode { get; private set; }

		internal Product(string title, string productID, string description, string imageURI, string price, string priceCurrencyCode)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
