namespace WebApplication1.Model
{
    public class OrderModel
    {
        //"externalOrder": {
        //"AXCompanyId": "UK20",
        //"OrderType": 1,
        //"OrderNumber": "JOHNTEST-001",
        //"OrderDate": "2022-06-28T21:47:25",
        //"Warehouse": "BA-Cons",
        //"LocaleId": "en-us",

        public int Id { get; set; }

        public string CompanyId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Warehouse { get; set; }
        public string CustomerName { get; set; }
    }
}
