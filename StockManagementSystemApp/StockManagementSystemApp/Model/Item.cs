﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApp.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public int ItemReorderLevel { get; set; }
        public int ItemQuantity { get; set; }
        public int UserId { get; set; }



        public int updatedAvailableQuantity;

        public int outQuantity;


        //public List<Sales> SalesList { get; set; }

        //public Item() 
        //{
        //    SalesList = new List<Sales>();
        //}




        //public int GetAvailableQuantity(int updatedAvailablequantity, int outquantity)                  // do it for stock out
        //{
        //        outQuantity = outquantity;
        //        updatedAvailableQuantity = updatedAvailablequantity;

        //        int availableQuantityForStockOut = updatedAvailablequantity - outquantity;

        //        return availableQuantityForStockOut;
        //}

        //public int GetQuantityAfterEdit(int previousQuantity, int availablequantity, int newQuantity)     // update the quantity after edit
        //{
        //    ItemQuantity = availablequantity + previousQuantity - newQuantity;
        //    return ItemQuantity;
        //}




    }
}
