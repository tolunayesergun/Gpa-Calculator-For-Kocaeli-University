
namespace GpaCalculator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LessonBox = new System.Windows.Forms.RichTextBox();
            this.totalScore = new System.Windows.Forms.Label();
            this.totalCredit = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.btnLessenList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LessonTable = new System.Windows.Forms.DataGridView();
            this.dtLessonCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtLessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAkts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDtCalc = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LessonTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LessonBox
            // 
            this.LessonBox.Location = new System.Drawing.Point(16, 16);
            this.LessonBox.Name = "LessonBox";
            this.LessonBox.Size = new System.Drawing.Size(374, 249);
            this.LessonBox.TabIndex = 0;
            this.LessonBox.Text = "";
            // 
            // totalScore
            // 
            this.totalScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalScore.Location = new System.Drawing.Point(13, 375);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(374, 34);
            this.totalScore.TabIndex = 2;
            this.totalScore.Text = "Toplam Puan : ";
            this.totalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCredit
            // 
            this.totalCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalCredit.Location = new System.Drawing.Point(13, 411);
            this.totalCredit.Name = "totalCredit";
            this.totalCredit.Size = new System.Drawing.Size(374, 34);
            this.totalCredit.TabIndex = 3;
            this.totalCredit.Text = "Toplam Kredi :";
            this.totalCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvg
            // 
            this.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAvg.Location = new System.Drawing.Point(13, 447);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(374, 34);
            this.lblAvg.TabIndex = 4;
            this.lblAvg.Text = "Ortalama :";
            this.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLessenList
            // 
            this.btnLessenList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLessenList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLessenList.Location = new System.Drawing.Point(13, 276);
            this.btnLessenList.Name = "btnLessenList";
            this.btnLessenList.Size = new System.Drawing.Size(183, 90);
            this.btnLessenList.TabIndex = 5;
            this.btnLessenList.Text = "Ders Listesini Tabloya Aktar";
            this.btnLessenList.UseVisualStyleBackColor = true;
            this.btnLessenList.Click += new System.EventHandler(this.btnLessenList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1443, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LessonTable
            // 
            this.LessonTable.AllowUserToResizeRows = false;
            this.LessonTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LessonTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LessonTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LessonTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LessonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LessonTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtLessonCode,
            this.dtLessonName,
            this.dtType,
            this.dtAkts,
            this.dtScore,
            this.dtStatus});
            this.LessonTable.Location = new System.Drawing.Point(402, 12);
            this.LessonTable.MultiSelect = false;
            this.LessonTable.Name = "LessonTable";
            this.LessonTable.RowHeadersVisible = false;
            this.LessonTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.LessonTable.Size = new System.Drawing.Size(1054, 471);
            this.LessonTable.TabIndex = 7;
            this.LessonTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.LessonTable_CellEnter);
            // 
            // dtLessonCode
            // 
            this.dtLessonCode.HeaderText = "Ders Kodu";
            this.dtLessonCode.Name = "dtLessonCode";
            // 
            // dtLessonName
            // 
            this.dtLessonName.HeaderText = "Ders Adı";
            this.dtLessonName.Name = "dtLessonName";
            // 
            // dtType
            // 
            this.dtType.HeaderText = "Türü";
            this.dtType.Name = "dtType";
            // 
            // dtAkts
            // 
            this.dtAkts.HeaderText = "AKTS";
            this.dtAkts.Name = "dtAkts";
            // 
            // dtScore
            // 
            this.dtScore.HeaderText = "Başarı Notu";
            this.dtScore.Name = "dtScore";
            // 
            // dtStatus
            // 
            this.dtStatus.HeaderText = "Durum";
            this.dtStatus.Name = "dtStatus";
            // 
            // btnDtCalc
            // 
            this.btnDtCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDtCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDtCalc.Location = new System.Drawing.Point(204, 276);
            this.btnDtCalc.Name = "btnDtCalc";
            this.btnDtCalc.Size = new System.Drawing.Size(183, 90);
            this.btnDtCalc.TabIndex = 8;
            this.btnDtCalc.Text = "Yapılan Değişikliklere Göre Tekrardan Hesapla";
            this.btnDtCalc.UseVisualStyleBackColor = true;
            this.btnDtCalc.Click += new System.EventHandler(this.btnDtCalc_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(263, 246);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Tüm Dersleri Getir     ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(383, 471);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 653);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnDtCalc);
            this.Controls.Add(this.LessonTable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLessenList);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.totalCredit);
            this.Controls.Add(this.totalScore);
            this.Controls.Add(this.LessonBox);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genel Not Ortalaması Hesapla";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LessonTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LessonBox;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Label totalCredit;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Button btnLessenList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView LessonTable;
        private System.Windows.Forms.Button btnDtCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtLessonCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtLessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAkts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtStatus;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

