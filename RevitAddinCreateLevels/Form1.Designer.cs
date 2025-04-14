namespace RevitAddinCreateLevels
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.levelNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelHeightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelHeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "※セルをダブルクリックすると入力・編集が可能";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "既に存在するレベル";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "新規作成するレベル";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(453, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(593, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.levelNameDataGridViewTextBoxColumn,
            this.levelHeightDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.levelClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(304, 287);
            this.dataGridView1.TabIndex = 29;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.levelNameDataGridViewTextBoxColumn1,
            this.levelHeightDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.levelClassBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(415, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(303, 287);
            this.dataGridView2.TabIndex = 30;
            // 
            // levelNameDataGridViewTextBoxColumn1
            // 
            this.levelNameDataGridViewTextBoxColumn1.DataPropertyName = "LevelName";
            this.levelNameDataGridViewTextBoxColumn1.HeaderText = "レベル名";
            this.levelNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.levelNameDataGridViewTextBoxColumn1.Name = "levelNameDataGridViewTextBoxColumn1";
            this.levelNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // levelHeightDataGridViewTextBoxColumn1
            // 
            this.levelHeightDataGridViewTextBoxColumn1.DataPropertyName = "LevelHeight";
            this.levelHeightDataGridViewTextBoxColumn1.HeaderText = "レベルの高さ";
            this.levelHeightDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.levelHeightDataGridViewTextBoxColumn1.Name = "levelHeightDataGridViewTextBoxColumn1";
            this.levelHeightDataGridViewTextBoxColumn1.Width = 125;
            // 
            // levelClassBindingSource
            // 
            this.levelClassBindingSource.DataSource = typeof(RevitAddinCreateLevels.LevelClass);
            // 
            // levelNameDataGridViewTextBoxColumn
            // 
            this.levelNameDataGridViewTextBoxColumn.DataPropertyName = "LevelName";
            this.levelNameDataGridViewTextBoxColumn.HeaderText = "レベル名";
            this.levelNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.levelNameDataGridViewTextBoxColumn.Name = "levelNameDataGridViewTextBoxColumn";
            this.levelNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // levelHeightDataGridViewTextBoxColumn
            // 
            this.levelHeightDataGridViewTextBoxColumn.DataPropertyName = "LevelHeight";
            this.levelHeightDataGridViewTextBoxColumn.HeaderText = "レベルの高さ";
            this.levelHeightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.levelHeightDataGridViewTextBoxColumn.Name = "levelHeightDataGridViewTextBoxColumn";
            this.levelHeightDataGridViewTextBoxColumn.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "※既存レベルは編集できません（今のところ）";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "レベルの作成";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource levelClassBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelHeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelHeightDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label4;
    }
}