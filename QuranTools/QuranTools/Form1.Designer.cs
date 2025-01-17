namespace QuranTools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mp = new AxWMPLib.AxWindowsMediaPlayer();
            AddBTN = new System.Windows.Forms.Button();
            TimeDG = new System.Windows.Forms.DataGridView();
            aye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            milisecound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ExpBTN = new System.Windows.Forms.Button();
            ImpBTN = new System.Windows.Forms.Button();
            SpeedUpBTN = new System.Windows.Forms.Button();
            SpeedDownBTN = new System.Windows.Forms.Button();
            SpeedLB = new System.Windows.Forms.Label();
            OFD = new System.Windows.Forms.OpenFileDialog();
            fontDialog1 = new System.Windows.Forms.FontDialog();
            OpenMP3BTN = new System.Windows.Forms.Button();
            ClearListBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)mp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TimeDG).BeginInit();
            this.SuspendLayout();
            // 
            // mp
            // 
            mp.Enabled = true;
            mp.Location = new System.Drawing.Point(27, 62);
            mp.Name = "mp";
            //mp.OcxState = (System.Windows.Forms.AxHost)resources.GetObject("mp.OcxState");
            mp.Size = new System.Drawing.Size(540, 103);
            mp.TabIndex = 0;
            // 
            // AddBTN
            // 
            AddBTN.Location = new System.Drawing.Point(188, 216);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new System.Drawing.Size(234, 29);
            AddBTN.TabIndex = 1;
            AddBTN.Text = "Add Now Ayeh (x key)";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += this.button1_Click;
            // 
            // TimeDG
            // 
            TimeDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TimeDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { aye, milisecound, time });
            TimeDG.Location = new System.Drawing.Point(582, 62);
            TimeDG.Name = "TimeDG";
            TimeDG.RowHeadersWidth = 51;
            TimeDG.Size = new System.Drawing.Size(300, 409);
            TimeDG.TabIndex = 4;
            TimeDG.CellDoubleClick += this.dataGridView1_CellDoubleClick;
            TimeDG.RowsRemoved += this.dataGridView1_RowsRemoved;
            // 
            // aye
            // 
            aye.HeaderText = "ayeh";
            aye.MinimumWidth = 6;
            aye.Name = "aye";
            aye.ReadOnly = true;
            aye.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            aye.Width = 45;
            // 
            // milisecound
            // 
            milisecound.HeaderText = "milisecound";
            milisecound.MinimumWidth = 6;
            milisecound.Name = "milisecound";
            milisecound.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            milisecound.Width = 60;
            // 
            // time
            // 
            time.HeaderText = "time";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.ReadOnly = true;
            time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            time.Width = 60;
            // 
            // ExpBTN
            // 
            ExpBTN.Location = new System.Drawing.Point(582, 489);
            ExpBTN.Name = "ExpBTN";
            ExpBTN.Size = new System.Drawing.Size(94, 29);
            ExpBTN.TabIndex = 5;
            ExpBTN.Text = "Export";
            ExpBTN.UseVisualStyleBackColor = true;
            ExpBTN.Click += this.ExpBTN_Click;
            // 
            // ImpBTN
            // 
            ImpBTN.Location = new System.Drawing.Point(788, 489);
            ImpBTN.Name = "ImpBTN";
            ImpBTN.Size = new System.Drawing.Size(94, 29);
            ImpBTN.TabIndex = 5;
            ImpBTN.Text = "Import";
            ImpBTN.UseVisualStyleBackColor = true;
            ImpBTN.Click += this.ImpBTN_Click;
            // 
            // SpeedUpBTN
            // 
            SpeedUpBTN.Location = new System.Drawing.Point(473, 171);
            SpeedUpBTN.Name = "SpeedUpBTN";
            SpeedUpBTN.Size = new System.Drawing.Size(94, 29);
            SpeedUpBTN.TabIndex = 6;
            SpeedUpBTN.Text = "Speed UP";
            SpeedUpBTN.UseVisualStyleBackColor = true;
            SpeedUpBTN.Visible = false;
            SpeedUpBTN.Click += this.SpeedUpBTN_Click;
            // 
            // SpeedDownBTN
            // 
            SpeedDownBTN.Location = new System.Drawing.Point(27, 171);
            SpeedDownBTN.Name = "SpeedDownBTN";
            SpeedDownBTN.Size = new System.Drawing.Size(115, 29);
            SpeedDownBTN.TabIndex = 6;
            SpeedDownBTN.Text = "Speed Down";
            SpeedDownBTN.UseVisualStyleBackColor = true;
            SpeedDownBTN.Visible = false;
            SpeedDownBTN.Click += this.SpeedDownBTN_Click;
            // 
            // SpeedLB
            // 
            SpeedLB.AutoSize = true;
            SpeedLB.Location = new System.Drawing.Point(262, 180);
            SpeedLB.Name = "SpeedLB";
            SpeedLB.Size = new System.Drawing.Size(0, 20);
            SpeedLB.TabIndex = 7;
            // 
            // OFD
            // 
            OFD.DefaultExt = "*.txt";
            OFD.FileName = "openFileDialog1";
            OFD.Title = "Add Text File";
            // 
            // OpenMP3BTN
            // 
            OpenMP3BTN.Location = new System.Drawing.Point(178, 18);
            OpenMP3BTN.Name = "OpenMP3BTN";
            OpenMP3BTN.Size = new System.Drawing.Size(226, 29);
            OpenMP3BTN.TabIndex = 8;
            OpenMP3BTN.Text = "Open Audio File";
            OpenMP3BTN.UseVisualStyleBackColor = true;
            OpenMP3BTN.Click += this.OpenMP3BTN_Click;
            // 
            // ClearListBTN
            // 
            ClearListBTN.Location = new System.Drawing.Point(673, 18);
            ClearListBTN.Name = "ClearListBTN";
            ClearListBTN.Size = new System.Drawing.Size(94, 29);
            ClearListBTN.TabIndex = 9;
            ClearListBTN.Text = "Clear List";
            ClearListBTN.UseVisualStyleBackColor = true;
            ClearListBTN.Click += this.ClearListBTN_Click;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 593);
            this.Controls.Add(ClearListBTN);
            this.Controls.Add(OpenMP3BTN);
            this.Controls.Add(SpeedLB);
            this.Controls.Add(SpeedDownBTN);
            this.Controls.Add(SpeedUpBTN);
            this.Controls.Add(ImpBTN);
            this.Controls.Add(ExpBTN);
            this.Controls.Add(TimeDG);
            this.Controls.Add(AddBTN);
            this.Controls.Add(mp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quran Audio Splitter";
            this.Load += this.Form1_Load;
            this.KeyDown += this.Form1_KeyDown;
            this.KeyPress += this.Form1_KeyPress;
            this.KeyUp += this.Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)mp).EndInit();
            ((System.ComponentModel.ISupportInitialize)TimeDG).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mp;
        private Button AddBTN;
        private DataGridView TimeDG;
        private Button ExpBTN;
        private Button ImpBTN;
        private Button SpeedUpBTN;
        private Button SpeedDownBTN;
        private Label SpeedLB;
        private OpenFileDialog OFD;
        private FontDialog fontDialog1;
        private Button OpenMP3BTN;
        private Button ClearListBTN;
        private DataGridViewTextBoxColumn aye;
        private DataGridViewTextBoxColumn milisecound;
        private DataGridViewTextBoxColumn time;
    }
}
