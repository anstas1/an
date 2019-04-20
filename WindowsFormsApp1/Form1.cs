using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void knigiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.knigiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.database1DataSet1.zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.pocupatel". При необходимости она может быть перемещена или удалена.
            this.pocupatelTableAdapter.Fill(this.database1DataSet1.pocupatel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.knigi". При необходимости она может быть перемещена или удалена.
            this.knigiTableAdapter.Fill(this.database1DataSet1.knigi);

        }

        private void knigiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
