namespace ThosCafeMenu.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public int CATEGORYID { get; set; }  
        public string PRODUCTNAME { get; set; } = String.Empty;
        public string IMAGEPATH { get; set; } = String.Empty;
        public decimal PRICE { get; set; }
        public bool ISDELETED { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string CREATEUSERID { get; set; } = String.Empty;
    }
}