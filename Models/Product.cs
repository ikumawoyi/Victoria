using System.ComponentModel.DataAnnotations;

namespace VictorianPlumbing.Models
{
    public class Root
    {
        public List<Product> products { get; set; }
    }
    public class Product
    {
        public string id { get; set; }
        public string legacyId { get; set; }
        public string legacyVariantId { get; set; }
        public string cultureCode { get; set; }
        public bool isDefaultVariant { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public string slug { get; set; }
        public double? averageRating { get; set; }
        public int reviewsCount { get; set; }
        public int questionsCount { get; set; }
        public Image image { get; set; }
        public StockStatus stockStatus { get; set; }
        public Price price { get; set; }
        public Attributes attributes { get; set; }
        public DefaultCategory defaultCategory { get; set; }
        public Brand brand { get; set; }
        public double? tradePrices { get; set; }
        public double? variants { get; set; }
        public double score { get; set; }
    }
    public class Ancestor
    {
		[Key]
		public int Id { get; set; }
		public string slug { get; set; }
        public string externalId { get; set; }
        public string name { get; set; }
        public int depth { get; set; }
    }

    public class Attributes
    {
        [Key]
        public int Id { get; set; }
        public string? imageAltText { get; set; }
        public bool isApproved { get; set; }
        public bool isShownOnTv { get; set; }
        public bool isBestSeller { get; set; }
        public bool isFreeWaste { get; set; }
        public bool isPremium { get; set; }
        public bool isRecommended { get; set; }
        public bool isTrayIncluded { get; set; }
        public bool isBluetoothIncluded { get; set; }
        public bool isBatteryIncluded { get; set; }
        public bool isAntiSlipIncluded { get; set; }
        public bool isShortProjection { get; set; }
        public bool hasOneOutlet { get; set; }
        public bool hasTwoOutlets { get; set; }
        public bool hasThreeOutlets { get; set; }
        public bool isNew { get; set; }
        public bool hasMoreOptions { get; set; }
        public string? variationListingLabel { get; set; }
    }

    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string externalId { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public BrandImage brandImage { get; set; }
        public int level { get; set; }
    }

    public class BrandImage
    {
        [Key]
        public int Id { get; set; }
        public string externalId { get; set; }
        public string url { get; set; }
        public int priority { get; set; }
        public bool isDefault { get; set; }
        public Attributes attributes { get; set; }
    }

    public class DefaultCategory
    {
        [Key]
        public int Id { get; set; }
        public string externalId { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public bool isDefault { get; set; }
        public List<Ancestor> ancestors { get; set; }
        public int level { get; set; }
    }

    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string externalId { get; set; }
        public string url { get; set; }
        public int priority { get; set; }
        public bool isDefault { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Price
    {
        [Key]
        public int Id { get; set; }
        public string currencyCode { get; set; }
        public double? wasPriceIncTax { get; set; }
        public double? wasPriceExcTax { get; set; }
        public double? priceIncTax { get; set; }
        public double? priceExcTax { get; set; }
        public bool isOnPromotion { get; set; }
        public double? discountPercentage { get; set; }
        public double? monthlyFinanceEstimate { get; set; }
    }

    public class StockStatus
    {
        [Key]
        public int Id { get; set; }
        public string status { get; set; }
        public DateTime? eta { get; set; }
        public double? stockLevel { get; set; }
    }


}
