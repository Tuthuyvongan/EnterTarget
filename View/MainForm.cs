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
            updateDtgv();
        }
        private void updateDtgv()
        {
            dtgvAllModel.DataSource = GetSOFTdata.getAllModel();
            dtgvAllModel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAllModel.Columns["Model"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvAllModel.Columns["Model"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvAllModel.Columns["OUTPUT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvAllModel.Columns["OUTPUT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvAllModel.Columns["SCRAP"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvAllModel.Columns["SCRAP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvAllModel.Columns["Model"].FillWeight = 3;
            dtgvAllModel.Columns["OUTPUT"].FillWeight = 1;
            dtgvAllModel.Columns["SCRAP"].FillWeight = 1;
        }
    }
}
