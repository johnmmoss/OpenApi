// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class ExternalOrder
{
    public string AXCompanyId { get; set; }
    public int OrderType { get; set; }
    public string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public string Warehouse { get; set; }
    public string LocaleId { get; set; }
    public string ErpId { get; set; }
    public string CustomerPO { get; set; }
    public string SalesRepName { get; set; }
    public string FromCurrencyId { get; set; }
    public string ToCurrencyId { get; set; }
    public double FixedExchangeRate { get; set; }
    public int AddressType { get; set; }
    public string AddressName { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressLine3 { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Zip { get; set; }
    public string County { get; set; }
    public string Country { get; set; }
    public bool Complete { get; set; }
    public string DeliveryTerms { get; set; }
    public string ModeOfDelivery { get; set; }
    public string PaymentMethodId { get; set; }
    public string PaymentTermsId { get; set; }
    public string Contact { get; set; }
    public string ContactEmail { get; set; }
    public DateTime RequestedShipDate { get; set; }
    public DateTime RequestedDeliveryDate { get; set; }
    public DateTime RequestedReceiptDate { get; set; }
    public List<object> Attachments { get; set; }
    public List<object> Charges { get; set; }
    public List<Line> Lines { get; set; }
}