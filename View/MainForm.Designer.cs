
namespace EnterTarget
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbpnMain = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvAllModel = new System.Windows.Forms.DataGridView();
            this.btEnter = new XanderUI.XUISuperButton();
            this.dtgvDailyTarget = new System.Windows.Forms.DataGridView();
            this.tbpnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDailyTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpnMain
            // 
            this.tbpnMain.ColumnCount = 3;
            this.tbpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tbpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tbpnMain.Controls.Add(this.dtgvAllModel, 0, 1);
            this.tbpnMain.Controls.Add(this.btEnter, 1, 1);
            this.tbpnMain.Controls.Add(this.dtgvDailyTarget, 2, 1);
            this.tbpnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpnMain.Location = new System.Drawing.Point(0, 0);
            this.tbpnMain.Name = "tbpnMain";
            this.tbpnMain.RowCount = 2;
            this.tbpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tbpnMain.Size = new System.Drawing.Size(884, 441);
            this.tbpnMain.TabIndex = 0;
            // 
            // dtgvAllModel
            // 
            this.dtgvAllModel.AllowUserToAddRows = false;
            this.dtgvAllModel.AllowUserToDeleteRows = false;
            this.dtgvAllModel.AllowUserToResizeColumns = false;
            this.dtgvAllModel.AllowUserToResizeRows = false;
            this.dtgvAllModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAllModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAllModel.BackgroundColor = System.Drawing.Color.White;
            this.dtgvAllModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAllModel.GridColor = System.Drawing.Color.Black;
            this.dtgvAllModel.Location = new System.Drawing.Point(1, 133);
            this.dtgvAllModel.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvAllModel.Name = "dtgvAllModel";
            this.dtgvAllModel.ReadOnly = true;
            this.dtgvAllModel.Size = new System.Drawing.Size(395, 307);
            this.dtgvAllModel.TabIndex = 1;
            // 
            // btEnter
            // 
            this.btEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btEnter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btEnter.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btEnter.ButtonImage")));
            this.btEnter.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btEnter.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btEnter.ButtonText = "Enter";
            this.btEnter.CornerRadius = 5;
            this.btEnter.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btEnter.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btEnter.HoverTextColor = System.Drawing.Color.White;
            this.btEnter.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btEnter.Location = new System.Drawing.Point(398, 266);
            this.btEnter.Margin = new System.Windows.Forms.Padding(1);
            this.btEnter.Name = "btEnter";
            this.btEnter.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btEnter.SelectedTextColor = System.Drawing.Color.White;
            this.btEnter.Size = new System.Drawing.Size(86, 40);
            this.btEnter.SuperSelected = false;
            this.btEnter.TabIndex = 2;
            this.btEnter.TextColor = System.Drawing.Color.White;
            this.btEnter.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // dtgvDailyTarget
            // 
            this.dtgvDailyTarget.AllowUserToAddRows = false;
            this.dtgvDailyTarget.AllowUserToDeleteRows = false;
            this.dtgvDailyTarget.AllowUserToResizeColumns = false;
            this.dtgvDailyTarget.AllowUserToResizeRows = false;
            this.dtgvDailyTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDailyTarget.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDailyTarget.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDailyTarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDailyTarget.GridColor = System.Drawing.Color.Black;
            this.dtgvDailyTarget.Location = new System.Drawing.Point(486, 133);
            this.dtgvDailyTarget.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvDailyTarget.Name = "dtgvDailyTarget";
            this.dtgvDailyTarget.ReadOnly = true;
            this.dtgvDailyTarget.Size = new System.Drawing.Size(397, 307);
            this.dtgvDailyTarget.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 441);
            this.Controls.Add(this.tbpnMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbpnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDailyTarget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbpnMain;
        private System.Windows.Forms.DataGridView dtgvAllModel;
        private XanderUI.XUISuperButton btEnter;
        private System.Windows.Forms.DataGridView dtgvDailyTarget;
    }
}