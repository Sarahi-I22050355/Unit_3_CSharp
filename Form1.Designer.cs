namespace Unit_3_CSharp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTableCSV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteCSV = new System.Windows.Forms.Button();
            this.btnSearchCSV = new System.Windows.Forms.Button();
            this.txtSearchCSV = new System.Windows.Forms.TextBox();
            this.btnSaveCSV = new System.Windows.Forms.Button();
            this.btnOpenCSV = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tvJSON = new System.Windows.Forms.TreeView();
            this.btnOpenJSON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tvXML = new System.Windows.Forms.TreeView();
            this.btnOpenXML = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lstDocumentTXT = new System.Windows.Forms.ListBox();
            this.btnOpenTXT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchTXT = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableCSV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvTableCSV);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnDeleteCSV);
            this.tabPage1.Controls.Add(this.btnSearchCSV);
            this.tabPage1.Controls.Add(this.txtSearchCSV);
            this.tabPage1.Controls.Add(this.btnSaveCSV);
            this.tabPage1.Controls.Add(this.btnOpenCSV);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1002, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CSV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "CSV Manager";
            // 
            // dgvTableCSV
            // 
            this.dgvTableCSV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTableCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableCSV.Location = new System.Drawing.Point(107, 106);
            this.dgvTableCSV.Name = "dgvTableCSV";
            this.dgvTableCSV.RowHeadersVisible = false;
            this.dgvTableCSV.RowHeadersWidth = 51;
            this.dgvTableCSV.Size = new System.Drawing.Size(531, 228);
            this.dgvTableCSV.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(680, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Text to search";
            // 
            // btnDeleteCSV
            // 
            this.btnDeleteCSV.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCSV.Location = new System.Drawing.Point(680, 273);
            this.btnDeleteCSV.Name = "btnDeleteCSV";
            this.btnDeleteCSV.Size = new System.Drawing.Size(160, 46);
            this.btnDeleteCSV.TabIndex = 28;
            this.btnDeleteCSV.Text = "Delete";
            this.btnDeleteCSV.UseVisualStyleBackColor = true;
            // 
            // btnSearchCSV
            // 
            this.btnSearchCSV.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCSV.Location = new System.Drawing.Point(680, 221);
            this.btnSearchCSV.Name = "btnSearchCSV";
            this.btnSearchCSV.Size = new System.Drawing.Size(160, 46);
            this.btnSearchCSV.TabIndex = 23;
            this.btnSearchCSV.Text = "Search";
            this.btnSearchCSV.UseVisualStyleBackColor = true;
            // 
            // txtSearchCSV
            // 
            this.txtSearchCSV.Location = new System.Drawing.Point(680, 169);
            this.txtSearchCSV.Name = "txtSearchCSV";
            this.txtSearchCSV.Size = new System.Drawing.Size(205, 27);
            this.txtSearchCSV.TabIndex = 20;
            // 
            // btnSaveCSV
            // 
            this.btnSaveCSV.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCSV.Location = new System.Drawing.Point(273, 352);
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.Size = new System.Drawing.Size(160, 46);
            this.btnSaveCSV.TabIndex = 19;
            this.btnSaveCSV.Text = "Save";
            this.btnSaveCSV.UseVisualStyleBackColor = true;
            // 
            // btnOpenCSV
            // 
            this.btnOpenCSV.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenCSV.Location = new System.Drawing.Point(107, 352);
            this.btnOpenCSV.Name = "btnOpenCSV";
            this.btnOpenCSV.Size = new System.Drawing.Size(160, 45);
            this.btnOpenCSV.TabIndex = 18;
            this.btnOpenCSV.Text = "Open";
            this.btnOpenCSV.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.tvJSON);
            this.tabPage2.Controls.Add(this.btnOpenJSON);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1002, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "JSON";
            // 
            // tvJSON
            // 
            this.tvJSON.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tvJSON.Location = new System.Drawing.Point(22, 97);
            this.tvJSON.Name = "tvJSON";
            this.tvJSON.Size = new System.Drawing.Size(756, 290);
            this.tvJSON.TabIndex = 36;
            // 
            // btnOpenJSON
            // 
            this.btnOpenJSON.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenJSON.Location = new System.Drawing.Point(21, 393);
            this.btnOpenJSON.Name = "btnOpenJSON";
            this.btnOpenJSON.Size = new System.Drawing.Size(160, 45);
            this.btnOpenJSON.TabIndex = 35;
            this.btnOpenJSON.Text = "Open";
            this.btnOpenJSON.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 37);
            this.label2.TabIndex = 33;
            this.label2.Text = "JSON Viewer";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.tvXML);
            this.tabPage3.Controls.Add(this.btnOpenXML);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1002, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "XML";
            // 
            // tvXML
            // 
            this.tvXML.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tvXML.Location = new System.Drawing.Point(124, 98);
            this.tvXML.Name = "tvXML";
            this.tvXML.Size = new System.Drawing.Size(756, 290);
            this.tvXML.TabIndex = 39;
            // 
            // btnOpenXML
            // 
            this.btnOpenXML.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenXML.Location = new System.Drawing.Point(123, 394);
            this.btnOpenXML.Name = "btnOpenXML";
            this.btnOpenXML.Size = new System.Drawing.Size(160, 45);
            this.btnOpenXML.TabIndex = 38;
            this.btnOpenXML.Text = "Open";
            this.btnOpenXML.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(123, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 37);
            this.label3.TabIndex = 37;
            this.label3.Text = "XML Viewer";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.lstDocumentTXT);
            this.tabPage4.Controls.Add(this.btnOpenTXT);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txtSearchTXT);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.btnSearchTXT);
            this.tabPage4.Controls.Add(this.lstResultados);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1002, 479);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "TXT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(714, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 37);
            this.label6.TabIndex = 45;
            this.label6.Text = "Results";
            // 
            // lstDocumentTXT
            // 
            this.lstDocumentTXT.FormattingEnabled = true;
            this.lstDocumentTXT.ItemHeight = 20;
            this.lstDocumentTXT.Location = new System.Drawing.Point(38, 109);
            this.lstDocumentTXT.Name = "lstDocumentTXT";
            this.lstDocumentTXT.Size = new System.Drawing.Size(405, 284);
            this.lstDocumentTXT.TabIndex = 44;
            // 
            // btnOpenTXT
            // 
            this.btnOpenTXT.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenTXT.Location = new System.Drawing.Point(38, 398);
            this.btnOpenTXT.Name = "btnOpenTXT";
            this.btnOpenTXT.Size = new System.Drawing.Size(160, 45);
            this.btnOpenTXT.TabIndex = 43;
            this.btnOpenTXT.Text = "Open";
            this.btnOpenTXT.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 37);
            this.label5.TabIndex = 42;
            this.label5.Text = "TEXT Document ";
            // 
            // txtSearchTXT
            // 
            this.txtSearchTXT.Location = new System.Drawing.Point(449, 136);
            this.txtSearchTXT.Name = "txtSearchTXT";
            this.txtSearchTXT.Size = new System.Drawing.Size(205, 27);
            this.txtSearchTXT.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(449, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Text to search";
            // 
            // btnSearchTXT
            // 
            this.btnSearchTXT.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchTXT.Location = new System.Drawing.Point(449, 169);
            this.btnSearchTXT.Name = "btnSearchTXT";
            this.btnSearchTXT.Size = new System.Drawing.Size(160, 45);
            this.btnSearchTXT.TabIndex = 39;
            this.btnSearchTXT.Text = "Search";
            this.btnSearchTXT.UseVisualStyleBackColor = true;
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 20;
            this.lstResultados.Location = new System.Drawing.Point(714, 109);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(244, 284);
            this.lstResultados.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableCSV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label9;
        private Button btnDeleteCSV;
        private Button btnSearchCSV;
        private TextBox txtSearchCSV;
        private Button btnSaveCSV;
        private Button btnOpenCSV;
        private DataGridView dgvTableCSV;
        private Button btnOpenJSON;
        private Label label2;
        private TreeView tvJSON;
        private Label label1;
        private TabPage tabPage3;
        private TreeView tvXML;
        private Button btnOpenXML;
        private Label label3;
        private TabPage tabPage4;
        private Button btnSearchTXT;
        private TextBox txtSearchTXT;
        private Label label4;
        private Label label5;
        private Button btnOpenTXT;
        private Label label6;
        private ListBox lstDocumentTXT;
        private ListBox lstResultados;
    }

}