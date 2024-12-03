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
    public partial class Form1 : Form
    {
        // 재료 및 재고 데이터를 위한 DataTable 생성
        private readonly DataTable IngDataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        // DataTable 컬럼 초기화
        private void InitializeDataTable()
        {
            IngDataTable.Columns.Add("재료이름", typeof(string)); // 재료 이름
            IngDataTable.Columns.Add("재고량(g)", typeof(int));    // 그람 수
            dataGridView1.DataSource = IngDataTable;           // DataGridView에 데이터 소스 설정
        }

        // 재료 추가 버튼 클릭 이벤트
        private void btnIngAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && int.TryParse(intGram.Text, out int gram))
            {
                IngDataTable.Rows.Add(txtName.Text, gram);
                ClearInputFields(); // 입력 필드 초기화
            }
            else
            {
                MessageBox.Show("유효한 재료 이름과 그람 수를 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 재료 삭제 버튼 클릭 이벤트
        private void btnIngDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                if (cell.OwningRow != null && !cell.OwningRow.IsNewRow)
                {
                    dataGridView1.Rows.Remove(cell.OwningRow);
                }
            }
        }


        // 입력 필드 초기화
        private void ClearInputFields()
        {
            txtName.Clear();     // 이름 입력 필드 초기화
            intGram.Clear();     // 그람수 입력 필드 초기화
        }

        private void intGram_TextChanged(object sender, EventArgs e)
        {

        }

        // btnLaunch 클릭 이벤트 - Form2 열기 (DataTable 전달)
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(IngDataTable);
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
