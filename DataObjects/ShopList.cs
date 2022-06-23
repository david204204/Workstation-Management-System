using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm.DataObjects
{
    public class ShopList
    {
        public ShopList()
        {

        }

        public ShopList(int quantityAvail, string snNum, int usedQuantity, string description, int order, string clasOfWork)
        {
            product_sn = snNum;
            quantityAvailable = quantityAvail;
            quantityused = usedQuantity;
            product_desc = description;
            quantityForOrder = order;
            classWork = clasOfWork;

        }

        private int quantityForOrder;

        public int QuantityForOrder
        {
            get { return quantityForOrder; }
            set { quantityForOrder = value; }
        }

        private string classWork;

        public string ClassWork
        {
            get { return classWork; }
            set { classWork = value; }
        }

        private string product_sn;

        public string Product_sn
        {
            get { return product_sn; }
            set { product_sn = value; }
        }

        private int quantityAvailable;

        public int QuantityAvailable
        {
            get { return quantityAvailable; }
            set { quantityAvailable = value; }
        }

        private int quantityused;

        public int Quantityused
        {
            get { return quantityused; }
            set { quantityused = value; }
        }

        private string product_desc;

        public string Product_desc
        {
            get { return product_desc; }
            set { product_desc = value; }
        }

    }



}
