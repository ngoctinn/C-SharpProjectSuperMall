using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace CSharpCourseFinalProject
{
    public interface IViewController
    {
        void AddNewItem<T>(T item);
        void UpdateItem<T>(T updatedItem);
    }

    public partial class HomeFrm : Form, IViewController
    {
        private List<Item> _items;
        private List<Discount> _discounts;
        private List<Customer> _customers;

        public HomeFrm()
        {
            InitializeComponent();
            CenterToScreen();
            _items = new List<Item>();
            _discounts = new List<Discount>();
            _customers = new List<Customer>();
            // do other thing....
        }

        public void AddNewItem<T>(T item)
        {
            if(typeof(T) == typeof(Item))
            {
                var newItem = item as Item;
                tblItem.Rows.Add(new object[]
                {
                    newItem.ItemId, newItem.ItemName, newItem.ItemType, newItem.Quantity,
                    newItem.Brand, newItem.ReleaseDate.ToString("dd/MM/yyyy"), $"{newItem.Price:N0}", 
                    newItem.Discount == null ? "-" : newItem.Discount.Name
                });
            } else if(typeof(T) == typeof(Customer))
            {
                // hiển thị lên bảng customer
            }
        }

        public void UpdateItem<T>(T updatedItem)
        {
            throw new NotImplementedException();
        }

        private void BtnAddNewClick(object sender, EventArgs e)
        {
            if(sender.Equals(btnAddNewItem))
            {
                var childView = new AddEditItemFrm(this, _discounts);
                childView.Show();
            }
        }
    }
}
