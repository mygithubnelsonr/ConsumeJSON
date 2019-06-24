namespace ConsumeJSON
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonReadPlants = new System.Windows.Forms.Button();
            this.buttonFillList = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReadMovies = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ColumnWidth = 5;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 251);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonReadPlants
            // 
            this.buttonReadPlants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReadPlants.Location = new System.Drawing.Point(44, 3);
            this.buttonReadPlants.Name = "buttonReadPlants";
            this.buttonReadPlants.Size = new System.Drawing.Size(143, 34);
            this.buttonReadPlants.TabIndex = 1;
            this.buttonReadPlants.Text = "Read plants";
            this.buttonReadPlants.UseVisualStyleBackColor = true;
            this.buttonReadPlants.Click += new System.EventHandler(this.buttonReadPlants_Click);
            // 
            // buttonFillList
            // 
            this.buttonFillList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFillList.Location = new System.Drawing.Point(342, 32);
            this.buttonFillList.Name = "buttonFillList";
            this.buttonFillList.Size = new System.Drawing.Size(69, 30);
            this.buttonFillList.TabIndex = 2;
            this.buttonFillList.Text = "Fill List";
            this.buttonFillList.UseVisualStyleBackColor = true;
            this.buttonFillList.Click += new System.EventHandler(this.buttonFillList_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.734512F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.39823F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.734512F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.39823F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.734512F));
            this.tableLayoutPanel1.Controls.Add(this.buttonReadPlants, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonReadMovies, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 302);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 54);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonReadMovies
            // 
            this.buttonReadMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReadMovies.Location = new System.Drawing.Point(234, 3);
            this.buttonReadMovies.Name = "buttonReadMovies";
            this.buttonReadMovies.Size = new System.Drawing.Size(143, 34);
            this.buttonReadMovies.TabIndex = 4;
            this.buttonReadMovies.Text = "Read movies";
            this.buttonReadMovies.UseVisualStyleBackColor = true;
            this.buttonReadMovies.Click += new System.EventHandler(this.buttonReadMovies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonFillList);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonReadPlants;
        private System.Windows.Forms.Button buttonFillList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonReadMovies;
    }
}

