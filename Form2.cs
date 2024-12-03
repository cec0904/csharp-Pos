using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Form2 : Form
    {
        private DataTable ingDataTable;
        private Dictionary<string, int> tableOrderSummary = new Dictionary<string, int>();
        public Form2(DataTable ingDataTable)
        {
            InitializeComponent();
            this.ingDataTable = ingDataTable;
        }

        

        private void btnTable1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(ingDataTable, tableOrderSummary);
            form3.FormClosed += Form3_FormClosed; // Form3이 닫힐 때 이벤트 등록
            form3.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is Form3 form3)
            {
                tableOrderSummary = new Dictionary<string, int>(form3.OrderList);
                UpdateTableOrderSummary();
            }
        }

        private void UpdateTableOrderSummary()
        {
            table1ListBox.Items.Clear();
            foreach (var order in tableOrderSummary)
            {
                table1ListBox.Items.Add($"{order.Key} x {order.Value}");
            }
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {

        }

        private void btnTable3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void table1ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
