using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterTarget
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateDateTiemPicker();
            updateDtgv();
        }
        private void updateDateTiemPicker()
        {
            dtpDate.Value = DateTime.Today;
            dtpDate.CustomFormat = "dd-MM-yyyy";
            dtpDate.Format = DateTimePickerFormat.Custom;
            SaveData.Date = DateTime.Today.ToString("yyyy-MM-dd");
            dtpDate.ValueChanged += new EventHandler(dtpDate_ValueChanged);
        }
        private void updateDtgv()
        {
            dtgvAllModel.DataSource = GetSOFTdata.getAllModel();
            dtgvAllModel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDesign();
        }
        private void dtgvDesign()
        {
            dtgvAllModel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAllModel.Columns["MODEL"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvAllModel.Columns["MODEL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvAllModel.Columns["OUTPUT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvAllModel.Columns["OUTPUT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvAllModel.Columns["SCRAP"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvAllModel.Columns["SCRAP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvAllModel.Columns["MODEL"].FillWeight = 3;
            dtgvAllModel.Columns["OUTPUT"].FillWeight = 1;
            dtgvAllModel.Columns["SCRAP"].FillWeight = 1;
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgvAllModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                SaveData.Date = dtpDate.Value.ToString("yyyy-MM-dd");
                SaveData.AllModel = dtgvAllModel.Rows[e.RowIndex].Cells[0].Value.ToString();
                SaveData.op = double.Parse(dtgvAllModel.Rows[e.RowIndex].Cells[1].Value.ToString());
                SaveData.scrap = double.Parse(dtgvAllModel.Rows[e.RowIndex].Cells[2].Value.ToString());
                lbAllModel.Text = SaveData.AllModel;
                txtOutput.Text = SaveData.op.ToString();
                txtScrap.Text = SaveData.scrap.ToString();
            }
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == null || txtFind.Text == string.Empty || txtFind.Text == "")
            {
                dtgvAllModel.DataSource = GetSOFTdata.getAllModel();
            }
            else
            {
                DataRow[] results = GetSOFTdata.getAllModel().Select("MODEL like '%" + txtFind.Text.Trim() + "%'");
                if (results.Length > 0)
                {
                    DataTable searchResultTable = results.CopyToDataTable();
                    dtgvAllModel.DataSource = null;
                    dtgvAllModel.DataSource = searchResultTable;
                    dtgvDesign();
                }
                else
                {
                    MessageBox.Show("No result!");
                }
            }
        }
    }
}
