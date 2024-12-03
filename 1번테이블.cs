using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Form3 : Form
    {
        private DataTable ingDataTable;
        private Dictionary<string, int> orderList;
        private string selectedItem = null;

        public Dictionary<string, int> OrderList { get { return orderList; } }

        public Form3(DataTable ingDataTable, Dictionary<string, int> existingOrderList)
        {
            InitializeComponent();
            this.ingDataTable = ingDataTable;
            this.orderList = new Dictionary<string, int>(existingOrderList);
            UpdateOrderList();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Form3가 로드될 때 필요한 초기 설정 (필요 시 추가 가능)
        }

        private void btnPajeon_Click(object sender, EventArgs e)
        {
            AddOrUpdateOrder("파전");
            selectedItem = "파전";
        }

        private void btnKimchijeon_Click(object sender, EventArgs e)
        {
            AddOrUpdateOrder("김치전");
            selectedItem = "김치전";
        }

        private void AddOrUpdateOrder(string item)
        {
            if (orderList.ContainsKey(item))
            {
                orderList[item]++;
            }
            else
            {
                orderList[item] = 1;
            }

            UpdateOrderList();
        }

        // 수량 증가 버튼 클릭 이벤트
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedItem) && orderList.ContainsKey(selectedItem))
            {
                orderList[selectedItem]++;
                UpdateOrderList();
            }
        }

        // 수량 감소 버튼 클릭 이벤트
        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedItem) && orderList.ContainsKey(selectedItem))
            {
                if (orderList[selectedItem] > 1)
                {
                    orderList[selectedItem]--;
                }
                else
                {
                    orderList.Remove(selectedItem);
                    selectedItem = null;
                }
                UpdateOrderList();
            }
        }

        // 주문 내역 업데이트
        private void UpdateOrderList()
        {
            listBoxOrders.Items.Clear();
            foreach (var item in orderList)
            {
                listBoxOrders.Items.Add($"{item.Key} x {item.Value}");
            }

            if (!string.IsNullOrEmpty(selectedItem))
            {
                int index = listBoxOrders.Items.IndexOf($"{selectedItem} x {orderList[selectedItem]}");
                if (index != -1)
                {
                    listBoxOrders.SelectedIndex = index;
                }
            }
        }
        // ListBox 항목 클릭 시 선택된 항목 업데이트
        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedItem != null)
            {
                selectedItem = listBoxOrders.SelectedItem.ToString().Split(' ')[0];
            }
        }

        // 주문하기 버튼 클릭 이벤트
        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Close(); // 주문 후 Form3 닫기
        }

        // 결제 버튼 클릭 이벤트 - 재고 차감
        private void btnPay_Click(object sender, EventArgs e)
        {
            foreach (var order in orderList.ToList())
            {
                if (order.Key == "김치전")
                {
                    UpdateInventory("김치", -100 * order.Value);
                    UpdateInventory("파", -100 * order.Value);
                    UpdateInventory("밀가루", -100 * order.Value);
                }
                else if (order.Key == "파전")
                {
                    UpdateInventory("파", -200 * order.Value);
                    UpdateInventory("밀가루", -100 * order.Value);
                }
            }

            // 주문 초기화
            orderList.Clear();
            UpdateOrderList();

            this.Close();
        }

        // 재고 업데이트 메서드
        private void UpdateInventory(string ingredientName, int change)
        {
            foreach (DataRow row in ingDataTable.Rows)
            {
                if (row["재료이름"].ToString() == ingredientName)
                {
                    row["재고량(g)"] = Math.Max((int)row["재고량(g)"] + change, 0);
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


