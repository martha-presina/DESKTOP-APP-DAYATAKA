using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  //Namespace untuk penggunaan DataSet

namespace AppAsrama.Controller
{
    class InventoryController
    {
        //1. declare object dari view dan model
        private Model.InventoryModel modelInventory;
        private View.InventoryPage viewInventory;

        //2. instansiasi (Contructor)
        public InventoryController(View.InventoryPage viewInventory)
        {
            this.viewInventory = viewInventory;
            modelInventory = new Model.InventoryModel();
        }

        //fungsi untuk menampilkan data
        public void SelectInventory()
        {
            DataSet data = modelInventory.SelectInventory();
            viewInventory.dgInven.ItemsSource = data.Tables[0].DefaultView;
        }

        //fungsi untuk menambahkan data
        public bool InsertInventory()
        {
            modelInventory.SetKd_Inven(viewInventory.txtItem.Text);
            modelInventory.SetNama_Barang(viewInventory.txtName.Text);
            modelInventory.SetStock(viewInventory.txtStock.Text);

            bool hasil = modelInventory.InsertInventory();
            return hasil;
        }

        //fungsi untuk menghapus data
        public bool DeleteInventory()
        {
            modelInventory.SetKd_Inven(viewInventory.txtItem.Text);

            bool hasil = modelInventory.DeleteInventory();
            return hasil;
        }

        //fungsi untuk memperbaharui data
        public bool UpdateInventory()
        {
            modelInventory.SetKd_Inven(viewInventory.txtItem.Text);
            modelInventory.SetNama_Barang(viewInventory.txtName.Text);
            modelInventory.SetStock(viewInventory.txtStock.Text);

            bool hasil = modelInventory.UpdateInventory();
            return hasil;
        }

    }
}
