using Crm.BL.Model;
using Crm.UI.Enums;
using System.Windows.Forms;

namespace Crm.UI.Factories
{
    public class FormFactory
    {
        public Form CreateForm(FormTypes type)
        {
            Form form = null;

            switch (type)
            {
                case FormTypes.Customer:
                    form = new CustomerForm();
                    break;
                case FormTypes.Seller:
                    form = new CustomerForm();
                    break;
                case FormTypes.Product:
                    form = new ProductForm();
                    break;
            }

            return form;
        }

        public Form CreateForm(FormTypes type, object entity)
        {
            Form form = null;

            switch (type)
            {
                case FormTypes.Customer:
                    if (entity is Customer customer)
                    {
                        form = new CustomerForm(customer);
                    }
                    break;
                case FormTypes.Seller:
                    if (entity is Seller seller)
                    {
                        form = new SellerForm(seller);
                    }
                    break;
                case FormTypes.Product:
                    if (entity is Product product)
                    {
                        form = new ProductForm(product);
                    }
                    break;
            }

            return form;
        }
    }
}
