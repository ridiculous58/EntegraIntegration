using System;
using System.Collections.Generic;
using System.Text;

namespace EntegraIntegration.ConsoleApp.Integrations.Models.Response
{
    public class EntegraProductResponse
    {
        public IList<Porductlist> porductList { get; set; }
    }

    public class Porductlist
    {
        public string id { get; set; }
        public string productCode { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public string product_type { get; set; }
        public string barcode { get; set; }
        public string send_api { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public string group { get; set; }
        public string quantity { get; set; }
        public string currencyType { get; set; }
        public string kdv_id { get; set; }
        public string price1WithVAT { get; set; }
        public string price2WithVAT { get; set; }
        public string price3WithVAT { get; set; }
        public string price4WithVAT { get; set; }
        public string price5WithVAT { get; set; }
        public string price6WithVAT { get; set; }
        public string price7WithVAT { get; set; }
        public string price8WithVAT { get; set; }
        public string n11_priceWithVAT { get; set; }
        public string hb_priceWithVAT { get; set; }
        public string gg_buyNowPriceWithVAT { get; set; }
        public string n11_price { get; set; }
        public string gg_buyNowPrice { get; set; }
        public string hb_price { get; set; }
        public string lamoda_price { get; set; }
        public string lamoda_price2 { get; set; }
        public string sp_price { get; set; }
        public string bamilo_price { get; set; }
        public string bamilo_price2 { get; set; }
        public string eptt_price { get; set; }
        public string ozon_price { get; set; }
        public string mizu_price1 { get; set; }
        public string trendyol_listPrice { get; set; }
        public string birvbiry_price1 { get; set; }
        public string n11pro_price { get; set; }
        public string zebramo_listPrice { get; set; }
        public string zebramo_salePrice { get; set; }
        public string evideapazaryeri_list_price { get; set; }
        public string farmazon_price { get; set; }
        public string morhipo_listPrice { get; set; }
        public string morhipo_salePrice { get; set; }
        public string aliexpress_price { get; set; }
        public string aliexpress_salePrice { get; set; }
        public string lidyana_listPrice { get; set; }
        public string lidyana_salePrice { get; set; }
        public string modanisa_listPrice { get; set; }
        public string modanisa_salePrice { get; set; }
        public string joom_price { get; set; }
        public string amazon_price { get; set; }
        public string amazon_salePrice { get; set; }
        public string supplier { get; set; }
        public string date_change { get; set; }
        public string date_add { get; set; }
        public string hb_sku { get; set; }
        public string mpn { get; set; }
        public string alan1 { get; set; }
        public string alan2 { get; set; }
        public string alan3 { get; set; }
        public string alan4 { get; set; }
        public string alan5 { get; set; }
        public Variatio[] variatios { get; set; }
        public Picture[] pictures { get; set; }
    }

    public class Variatio
    {
        public string id { get; set; }
        public string productCode { get; set; }
        public string barcode { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        public string n11_price { get; set; }
        public string hb_st_sku { get; set; }
        public string gg_price { get; set; }
        public string hb_price { get; set; }
        public string trendy_price { get; set; }
        public string modanisa_price { get; set; }
        public string eticaret_price { get; set; }
        public string n11pro_price { get; set; }
        public string sp_price { get; set; }
        public string eptt_price { get; set; }
        public string amazon_price { get; set; }
        public string hb_sku { get; set; }
        public string morhipo_price { get; set; }
        public string itemdim1code { get; set; }
        public string itemdim2code { get; set; }
        public Variationspec[] variationSpec { get; set; }
        public Variation_Pictures[] variation_pictures { get; set; }
    }

    public class Variationspec
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Variation_Pictures
    {
        public string url { get; set; }
    }

    public class Picture
    {
        public string picture { get; set; }
    }

}
