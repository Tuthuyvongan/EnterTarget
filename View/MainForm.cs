using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            dataChange();
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
            dtgvAllModel.DataSource = GetSOFTdata.getAllModel(SaveData.Date);
            dtgvDailyTarget.DataSource = GetSOFTdata.getTarget(SaveData.Date);
            dtgvDesign();
            dataChange();
        }
        private void dtgvDesign()
        {
            //All Model
            if (GetSOFTdata.getAllModel(SaveData.Date) != null)
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
            //dailyTarget
            if (GetSOFTdata.getTarget(SaveData.Date) != null)
            {
                dtgvDailyTarget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvDailyTarget.Columns["MODEL"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvDailyTarget.Columns["MODEL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtgvDailyTarget.Columns["DATE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvDailyTarget.Columns["DATE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvDailyTarget.Columns["OUTPUT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvDailyTarget.Columns["OUTPUT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvDailyTarget.Columns["SCRAP"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvDailyTarget.Columns["SCRAP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvDailyTarget.Columns["MODEL"].FillWeight = 4;
                dtgvDailyTarget.Columns["DATE"].FillWeight = 3;
                dtgvDailyTarget.Columns["OUTPUT"].FillWeight = 2;
                dtgvDailyTarget.Columns["SCRAP"].FillWeight = 2;
            }
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            SaveData.Date = dtpDate.Value.ToString("yyyy-MM-dd");
            updateDtgv();
        }

        private void dataChange()
        {
            if (dtgvAllModel.Rows.Count > 0)
            {
                SaveData.AllModel = dtgvAllModel.Rows[0].Cells[0].Value.ToString();
                lbAllModel.Text = SaveData.AllModel;
                txtOutput.Text = dtgvAllModel.Rows[0].Cells[1].Value.ToString();
                txtScrap.Text = dtgvAllModel.Rows[0].Cells[2].Value.ToString();
            }
            else
            {
                SaveData.AllModel = "";
                lbAllModel.Text = "";
                txtOutput.Text = "";
                txtScrap.Text = "";
            }
            if (dtgvDailyTarget.Rows.Count > 0)
            {
                SaveData.Model = dtgvDailyTarget.Rows[0].Cells[0].Value.ToString();
                lbModel.Text = SaveData.Model;
                txtTargetOP.Text = dtgvDailyTarget.Rows[0].Cells[2].Value.ToString();
                txtTargetScrap.Text = dtgvDailyTarget.Rows[0].Cells[3].Value.ToString();
            }
            else
            {
                SaveData.Model = "";
                lbModel.Text = "";
                txtTargetOP.Text = "";
                txtTargetScrap.Text = "";
            }
        }

        private void dtgvAllModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                SaveData.AllModel = dtgvAllModel.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbAllModel.Text = SaveData.AllModel;
                txtOutput.Text = dtgvAllModel.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtScrap.Text = dtgvAllModel.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void dtgvDailyTarget_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                SaveData.Model = dtgvDailyTarget.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbModel.Text = SaveData.Model;
                txtTargetOP.Text = dtgvDailyTarget.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTargetScrap.Text = dtgvDailyTarget.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == null || txtFind.Text == string.Empty || txtFind.Text == "")
            {
                dtgvAllModel.DataSource = GetSOFTdata.getAllModel(SaveData.Date);
                dataChange();
            }
            else
            {
                DataRow[] results = GetSOFTdata.getAllModel(SaveData.Date).Select("MODEL like '%" + txtFind.Text.Trim() + "%'");
                if (results.Length > 0)
                {
                    DataTable searchResultTable = results.CopyToDataTable();
                    dtgvAllModel.DataSource = null;
                    dtgvAllModel.DataSource = searchResultTable;
                    dtgvDesign();
                    dataChange();
                }
                else
                {
                    MessageBox.Show("No result!");
                }
            }
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            if (SaveData.op > 0 && SaveData.scrap >= 0)
            {
                string cmd;
                cmd = UploadLogic.Insert(SaveData.Date, SaveData.AllModel, SaveData.op, SaveData.scrap);
                uploadWithTransactionSupport(cmd);
                updateDtgv();
                txtFind.Text = "";
            }
            else
                MessageBox.Show("Please enter output and scrap", "Error");
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            if (SaveData.Model != "")
            {
                string cmd;
                cmd = UploadLogic.Update(SaveData.Date, SaveData.Model, SaveData.opTarget, SaveData.scrapTarget);
                uploadWithTransactionSupport(cmd);
                updateDtgv();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (SaveData.Model != "")
            {
                string cmd;
                cmd = UploadLogic.Delete(SaveData.Date, SaveData.Model);
                uploadWithTransactionSupport(cmd);
                updateDtgv();
            }            
        }

        static void uploadWithTransactionSupport(string cmd)
        {

            SqlConnection conn = DatabaseUtils.GetSoftDBConnection();
            SqlTransaction trans = null;
            SqlCommand cmdMS = new SqlCommand();
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                cmdMS.Transaction = trans;
                cmdMS.Connection = conn;
                //Insert and update Mes_planning_excution commands execute
                cmdMS.CommandText = cmd;
                cmdMS.ExecuteNonQuery();
                trans.Commit();
                MessageBox.Show("Successfully Update to database!", "Complete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nFail to add and update data", "Error");
                trans.Rollback();
            }

        }
        public int number = 0;
        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtOutput.Text, out number) == false)
                SaveData.op = number;
            else
                SaveData.op = int.Parse(txtOutput.Text);
        }

        private void txtScrap_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtScrap.Text, out number) == false)
                SaveData.scrap = number;
            else
                SaveData.scrap = int.Parse(txtScrap.Text);
        }

        private void txtTargetOP_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtTargetOP.Text, out number) == false)
                SaveData.opTarget = number;
            else
                SaveData.opTarget = int.Parse(txtTargetOP.Text);
        }

        private void txtTargetScrap_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtTargetScrap.Text, out number) == false)
                SaveData.scrapTarget = number;
            else
                SaveData.scrapTarget = int.Parse(txtTargetScrap.Text);
        }
    }
}
