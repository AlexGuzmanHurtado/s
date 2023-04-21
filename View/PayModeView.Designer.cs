namespace Supermarket_mvp.View
{
    partial class PayModeView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            tabControl2 = new TabControl();
            tabPagePayModeList = new TabPage();
            tabPagePayModeDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            TxtPayModeId = new TextBox();
            label4 = new Label();
            TxtPayModeName = new TextBox();
            label5 = new Label();
            TxtPayModeObservation = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            tabPagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 29);
            label1.TabIndex = 0;
            label1.Text = "PAY MODE";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Right;
            tabControl1.Location = new Point(792, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(8, 325);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(0, 292);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(0, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 325);
            panel2.TabIndex = 3;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPagePayModeList);
            tabControl2.Controls.Add(tabPagePayModeDetail);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(792, 325);
            tabControl2.TabIndex = 0;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(button4);
            tabPagePayModeList.Controls.Add(button3);
            tabPagePayModeList.Controls.Add(button2);
            tabPagePayModeList.Controls.Add(button1);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(784, 292);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            tabPagePayModeList.Click += tabPage3_Click_1;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(784, 292);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            tabPagePayModeDetail.Click += tabPagePayModeDetail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 14);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            label2.Click += label2_Click;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(22, 45);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(389, 27);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(432, 36);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(47, 45);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(22, 96);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.RowTemplate.Height = 29;
            DgPayMode.Size = new Size(527, 188);
            DgPayMode.TabIndex = 3;
            DgPayMode.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Image = Properties.Resources._new;
            button1.Location = new Point(591, 86);
            button1.Name = "button1";
            button1.Size = new Size(137, 45);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.edit;
            button2.Location = new Point(591, 137);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.delete;
            button3.Location = new Point(591, 188);
            button3.Name = "button3";
            button3.Size = new Size(137, 45);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.cerrar;
            button4.Location = new Point(591, 239);
            button4.Name = "button4";
            button4.Size = new Size(137, 45);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 13);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(17, 41);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(273, 27);
            TxtPayModeId.TabIndex = 1;
            TxtPayModeId.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 90);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            label4.Click += label4_Click;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(17, 118);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(328, 27);
            TxtPayModeName.TabIndex = 3;
            TxtPayModeName.Text = "Pay Mode Name";
            TxtPayModeName.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 162);
            label5.Name = "label5";
            label5.Size = new Size(207, 25);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            label5.Click += label5_Click;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(21, 203);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.Size = new Size(328, 52);
            TxtPayModeObservation.TabIndex = 5;
            TxtPayModeObservation.Text = "Pay Mode Observation";
            TxtPayModeObservation.TextChanged += textBox3_TextChanged;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(450, 27);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(83, 62);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += button5_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(563, 27);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 62);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            Load += PayModeView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private TabControl tabControl2;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Label label2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private DataGridView DgPayMode;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private TextBox TxtPayModeId;
        private Label label3;
        private Label label4;
        private TextBox TxtPayModeName;
        private Label label5;
        private TextBox TxtPayModeObservation;
        private Button BtnSave;
        private Button BtnCancel;
    }
}