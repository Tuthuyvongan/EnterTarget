
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtgvAllModel = new System.Windows.Forms.DataGridView();
            this.btEnter = new XanderUI.XUISuperButton();
            this.dtgvDailyTarget = new System.Windows.Forms.DataGridView();
            this.tbRight = new System.Windows.Forms.TableLayoutPanel();
            this.tbRightButton = new System.Windows.Forms.TableLayoutPanel();
            this.btDelete = new XanderUI.XUIButton();
            this.btFix = new XanderUI.XUIButton();
            this.tbpnInfoRight = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTargetOP = new System.Windows.Forms.TextBox();
            this.txtTargetScrap = new System.Windows.Forms.TextBox();
            this.lbModel = new System.Windows.Forms.Label();
            this.tbpnInfoLeft = new System.Windows.Forms.TableLayoutPanel();
            this.txtScrap = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lbAllModel = new System.Windows.Forms.Label();
            this.tbpnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDailyTarget)).BeginInit();
            this.tbRight.SuspendLayout();
            this.tbRightButton.SuspendLayout();
            this.tbpnInfoRight.SuspendLayout();
            this.tbpnInfoLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpnMain
            // 
            this.tbpnMain.ColumnCount = 3;
            this.tbpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tbpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tbpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tbpnMain.Controls.Add(this.dtpDate, 1, 0);
            this.tbpnMain.Controls.Add(this.dtgvAllModel, 0, 1);
            this.tbpnMain.Controls.Add(this.btEnter, 1, 1);
            this.tbpnMain.Controls.Add(this.dtgvDailyTarget, 2, 1);
            this.tbpnMain.Controls.Add(this.tbRight, 2, 0);
            this.tbpnMain.Controls.Add(this.tbpnInfoLeft, 0, 0);
            this.tbpnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpnMain.Location = new System.Drawing.Point(0, 0);
            this.tbpnMain.Name = "tbpnMain";
            this.tbpnMain.RowCount = 2;
            this.tbpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tbpnMain.Size = new System.Drawing.Size(884, 441);
            this.tbpnMain.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(386, 2);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(15, 2, 15, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(111, 23);
            this.dtpDate.TabIndex = 0;
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
            this.dtgvAllModel.RowHeadersWidth = 51;
            this.dtgvAllModel.Size = new System.Drawing.Size(369, 307);
            this.dtgvAllModel.TabIndex = 1;
            this.dtgvAllModel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAllModel_CellClick);
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
            this.btEnter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnter.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btEnter.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btEnter.HoverTextColor = System.Drawing.Color.White;
            this.btEnter.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btEnter.Location = new System.Drawing.Point(382, 259);
            this.btEnter.Margin = new System.Windows.Forms.Padding(11, 1, 11, 1);
            this.btEnter.Name = "btEnter";
            this.btEnter.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btEnter.SelectedTextColor = System.Drawing.Color.White;
            this.btEnter.Size = new System.Drawing.Size(119, 54);
            this.btEnter.SuperSelected = false;
            this.btEnter.TabIndex = 2;
            this.btEnter.TextColor = System.Drawing.Color.White;
            this.btEnter.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
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
            this.dtgvDailyTarget.Location = new System.Drawing.Point(513, 133);
            this.dtgvDailyTarget.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvDailyTarget.Name = "dtgvDailyTarget";
            this.dtgvDailyTarget.ReadOnly = true;
            this.dtgvDailyTarget.RowHeadersWidth = 51;
            this.dtgvDailyTarget.Size = new System.Drawing.Size(370, 307);
            this.dtgvDailyTarget.TabIndex = 3;
            this.dtgvDailyTarget.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDailyTarget_CellClick);
            // 
            // tbRight
            // 
            this.tbRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRight.ColumnCount = 1;
            this.tbRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbRight.Controls.Add(this.tbRightButton, 0, 1);
            this.tbRight.Controls.Add(this.tbpnInfoRight, 0, 0);
            this.tbRight.Location = new System.Drawing.Point(512, 0);
            this.tbRight.Margin = new System.Windows.Forms.Padding(0);
            this.tbRight.Name = "tbRight";
            this.tbRight.RowCount = 2;
            this.tbRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tbRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tbRight.Size = new System.Drawing.Size(372, 132);
            this.tbRight.TabIndex = 5;
            // 
            // tbRightButton
            // 
            this.tbRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRightButton.ColumnCount = 2;
            this.tbRightButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbRightButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbRightButton.Controls.Add(this.btDelete, 1, 0);
            this.tbRightButton.Controls.Add(this.btFix, 0, 0);
            this.tbRightButton.Location = new System.Drawing.Point(0, 92);
            this.tbRightButton.Margin = new System.Windows.Forms.Padding(0);
            this.tbRightButton.Name = "tbRightButton";
            this.tbRightButton.RowCount = 1;
            this.tbRightButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbRightButton.Size = new System.Drawing.Size(372, 40);
            this.tbRightButton.TabIndex = 0;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.BackgroundColor = System.Drawing.Color.White;
            this.btDelete.ButtonImage = global::EnterTarget.Properties.Resources.remove;
            this.btDelete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btDelete.ButtonText = "Delete";
            this.btDelete.ClickBackColor = System.Drawing.Color.Black;
            this.btDelete.ClickTextColor = System.Drawing.Color.White;
            this.btDelete.CornerRadius = 5;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btDelete.HoverBackgroundColor = System.Drawing.Color.OrangeRed;
            this.btDelete.HoverTextColor = System.Drawing.Color.Black;
            this.btDelete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btDelete.Location = new System.Drawing.Point(231, 3);
            this.btDelete.Margin = new System.Windows.Forms.Padding(45, 3, 45, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 34);
            this.btDelete.TabIndex = 1;
            this.btDelete.TextColor = System.Drawing.Color.Black;
            this.btDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btFix
            // 
            this.btFix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFix.BackgroundColor = System.Drawing.Color.White;
            this.btFix.ButtonImage = global::EnterTarget.Properties.Resources.service;
            this.btFix.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btFix.ButtonText = "Fix";
            this.btFix.ClickBackColor = System.Drawing.Color.Coral;
            this.btFix.ClickTextColor = System.Drawing.Color.White;
            this.btFix.CornerRadius = 5;
            this.btFix.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFix.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btFix.HoverBackgroundColor = System.Drawing.Color.LightSalmon;
            this.btFix.HoverTextColor = System.Drawing.Color.Black;
            this.btFix.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btFix.Location = new System.Drawing.Point(45, 3);
            this.btFix.Margin = new System.Windows.Forms.Padding(45, 3, 45, 3);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(96, 34);
            this.btFix.TabIndex = 2;
            this.btFix.TextColor = System.Drawing.Color.Black;
            this.btFix.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // tbpnInfoRight
            // 
            this.tbpnInfoRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbpnInfoRight.ColumnCount = 2;
            this.tbpnInfoRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbpnInfoRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbpnInfoRight.Controls.Add(this.label6, 0, 2);
            this.tbpnInfoRight.Controls.Add(this.label4, 0, 0);
            this.tbpnInfoRight.Controls.Add(this.label5, 0, 1);
            this.tbpnInfoRight.Controls.Add(this.txtTargetOP, 1, 1);
            this.tbpnInfoRight.Controls.Add(this.txtTargetScrap, 1, 2);
            this.tbpnInfoRight.Controls.Add(this.lbModel, 1, 0);
            this.tbpnInfoRight.Location = new System.Drawing.Point(0, 0);
            this.tbpnInfoRight.Margin = new System.Windows.Forms.Padding(0);
            this.tbpnInfoRight.Name = "tbpnInfoRight";
            this.tbpnInfoRight.RowCount = 3;
            this.tbpnInfoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpnInfoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpnInfoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpnInfoRight.Size = new System.Drawing.Size(372, 92);
            this.tbpnInfoRight.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Scrap";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Model";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Output";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTargetOP
            // 
            this.txtTargetOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetOP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetOP.Location = new System.Drawing.Point(76, 33);
            this.txtTargetOP.Margin = new System.Windows.Forms.Padding(2, 2, 200, 2);
            this.txtTargetOP.Name = "txtTargetOP";
            this.txtTargetOP.Size = new System.Drawing.Size(96, 24);
            this.txtTargetOP.TabIndex = 5;
            this.txtTargetOP.TextChanged += new System.EventHandler(this.txtTargetOP_TextChanged);
            // 
            // txtTargetScrap
            // 
            this.txtTargetScrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetScrap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetScrap.Location = new System.Drawing.Point(76, 64);
            this.txtTargetScrap.Margin = new System.Windows.Forms.Padding(2, 2, 200, 2);
            this.txtTargetScrap.Name = "txtTargetScrap";
            this.txtTargetScrap.Size = new System.Drawing.Size(96, 24);
            this.txtTargetScrap.TabIndex = 6;
            this.txtTargetScrap.TextChanged += new System.EventHandler(this.txtTargetScrap_TextChanged);
            // 
            // lbModel
            // 
            this.lbModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.lbModel.Location = new System.Drawing.Point(76, 6);
            this.lbModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(20, 17);
            this.lbModel.TabIndex = 7;
            this.lbModel.Text = "...";
            this.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbpnInfoLeft
            // 
            this.tbpnInfoLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbpnInfoLeft.ColumnCount = 2;
            this.tbpnInfoLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbpnInfoLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tbpnInfoLeft.Controls.Add(this.label7, 0, 3);
            this.tbpnInfoLeft.Controls.Add(this.txtScrap, 1, 2);
            this.tbpnInfoLeft.Controls.Add(this.txtOutput, 1, 1);
            this.tbpnInfoLeft.Controls.Add(this.label2, 0, 1);
            this.tbpnInfoLeft.Controls.Add(this.label1, 0, 0);
            this.tbpnInfoLeft.Controls.Add(this.label3, 0, 2);
            this.tbpnInfoLeft.Controls.Add(this.txtFind, 1, 3);
            this.tbpnInfoLeft.Controls.Add(this.lbAllModel, 1, 0);
            this.tbpnInfoLeft.Location = new System.Drawing.Point(0, 0);
            this.tbpnInfoLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tbpnInfoLeft.Name = "tbpnInfoLeft";
            this.tbpnInfoLeft.RowCount = 4;
            this.tbpnInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpnInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpnInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpnInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpnInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbpnInfoLeft.Size = new System.Drawing.Size(371, 132);
            this.tbpnInfoLeft.TabIndex = 6;
            // 
            // txtScrap
            // 
            this.txtScrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScrap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScrap.Location = new System.Drawing.Point(113, 70);
            this.txtScrap.Margin = new System.Windows.Forms.Padding(2, 2, 180, 2);
            this.txtScrap.Name = "txtScrap";
            this.txtScrap.Size = new System.Drawing.Size(78, 24);
            this.txtScrap.TabIndex = 5;
            this.txtScrap.TextChanged += new System.EventHandler(this.txtScrap_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(113, 37);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 180, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(78, 24);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Scrap";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Find Model";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(113, 103);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2, 2, 45, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(213, 24);
            this.txtFind.TabIndex = 7;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // lbAllModel
            // 
            this.lbAllModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAllModel.AutoSize = true;
            this.lbAllModel.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.lbAllModel.Location = new System.Drawing.Point(114, 8);
            this.lbAllModel.Name = "lbAllModel";
            this.lbAllModel.Size = new System.Drawing.Size(20, 17);
            this.lbAllModel.TabIndex = 8;
            this.lbAllModel.Text = "...";
            this.lbAllModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 441);
            this.Controls.Add(this.tbpnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbpnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDailyTarget)).EndInit();
            this.tbRight.ResumeLayout(false);
            this.tbRightButton.ResumeLayout(false);
            this.tbpnInfoRight.ResumeLayout(false);
            this.tbpnInfoRight.PerformLayout();
            this.tbpnInfoLeft.ResumeLayout(false);
            this.tbpnInfoLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbpnMain;
        private System.Windows.Forms.DataGridView dtgvAllModel;
        private XanderUI.XUISuperButton btEnter;
        private System.Windows.Forms.DataGridView dtgvDailyTarget;
        private XanderUI.XUIButton btFix;
        private XanderUI.XUIButton btDelete;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TableLayoutPanel tbRight;
        private System.Windows.Forms.TableLayoutPanel tbRightButton;
        private System.Windows.Forms.TableLayoutPanel tbpnInfoLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScrap;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tbpnInfoRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTargetOP;
        private System.Windows.Forms.TextBox txtTargetScrap;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lbAllModel;
    }
}