using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;
using StockManagementSystemApp.Model.View_Model;

namespace StockManagementSystemApp.Manager
{
    class ItemManager
    {
        ItemGateway aItemGateway = new ItemGateway();
        public bool checkItemNameExist;
        public int ItemQuantity;

        public string SaveItemManager(Item aItem)
        {
            checkItemNameExist = aItemGateway.IsExistItemName(aItem);
            if (checkItemNameExist == true)
            {
                return ("Item Name Already Exists");
            }


            int rowAffect = aItemGateway.SaveItem(aItem);

            if (rowAffect > 0)
            {
                return ("Successfully Inserted");
            }
            return ("Failed To Save");
        }

        public List<ItemViewModel> GetAllItemManager()
        {
            return aItemGateway.GetAllItems();
        }

        public List<Item> GetItemForComapnyManager(Item companyId)
        {
            return aItemGateway.GetItemForComapny(companyId);
        }

        public List<Item> GetItemForReorderQuantityManager(Item item)
        {
            return aItemGateway.GetItemForReorderQuantity(item);
        }

        public List<ItemViewModel> SearchBothItemManager(ItemViewModel item)
        {
            return aItemGateway.SearchBothItem(item);
        }

        public List<ItemViewModel> SearchItemManager(ItemViewModel item)
        {
            return aItemGateway.SearchItem(item);
        }

        public string UpdateItemManager(Item aItem)
        {
            checkItemNameExist = aItemGateway.IsExistItemName(aItem);
            if (checkItemNameExist == true)
            {
                return ("Item Name Already Exists");
            }

            int rowAffect = aItemGateway.UpdateItem(aItem);
            if (rowAffect > 0)
            {
                return ("Updated Sucessfully");
            }
            return ("Update Failed");
        }

        public string UpdateItemQuantityManager(Item quantity)
        {

            int rowAffect = aItemGateway.UpdateItemQuantity(quantity);
            if (rowAffect > 0)
            {
                return ("Updated Quantity Sucessfully");
            }
            return ("Failed To Save");
        }

        public string QtyAfterSaleManager(Item aItem)
        {

            int rowAffect = aItemGateway.QtyAfterSale(aItem);
            if (rowAffect > 0)
            {
                return ("Updated Quantity Sucessfully");
            }
            return ("Failed To Save");
        }
        public string UpdateItemQuantityFromDeleteManager(Item quantity)
        {

            int rowAffect = aItemGateway.UpdateItemQuantity(quantity);
            if (rowAffect > 0)
            {
                return ("Deleted sucessfully");
            }
            return ("save failed");
        }


        public String DeleteItemManager(int id)
        {
            int rowAffect = aItemGateway.DeleteItem(id);
            if (rowAffect > 0)
            {
                return ("Deleted successfully");
            }
            return ("Delete Failed");
        }
        public int GetQuantityUpdate(int availableQuantity, int quantity)       // do it for stock in
        {
            ItemQuantity = availableQuantity + quantity;
            return ItemQuantity;
        }

    }
}
