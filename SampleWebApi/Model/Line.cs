public class Line
{
    public string PartNumber { get; set; }
    public string LineWarehouse { get; set; }
    public double Quantity { get; set; }
    public string UOM { get; set; }
    public double UnitPrice { get; set; }
    public double DiscountPercent { get; set; }
    public double DiscountAmount { get; set; }
    public DateTime RequestedShipDate { get; set; }
    public DateTime RequestedReceiptDate { get; set; }
    public string ConfigDim { get; set; }
    public string ConfigDimDescription { get; set; }
    public string SizeDim { get; set; }
    public string SizeDimDescription { get; set; }
    public string ColorDim { get; set; }
    public string ColorDimDescription { get; set; }
    public string StyleDim { get; set; }
    public string StyleDimDescription { get; set; }
    public string VariantDescription { get; set; }
    public bool Configurable { get; set; }
    public string LineId { get; set; }
    public double LineNumber { get; set; }
    public ConfigurationSetting ConfigurationSetting { get; set; }
    public List<object> Attachments { get; set; }
    public List<object> Charges { get; set; }
    public bool Complete { get; set; }
}