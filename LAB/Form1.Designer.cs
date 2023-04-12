namespace LAB
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
            this.stdIdLabel = new System.Windows.Forms.Label();
            this.stdIdTextBox = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.showAverage = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stdIdLabel
            // 
            this.stdIdLabel.AutoSize = true;
            this.stdIdLabel.Location = new System.Drawing.Point(48, 54);
            this.stdIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stdIdLabel.Name = "stdIdLabel";
            this.stdIdLabel.Size = new System.Drawing.Size(49, 18);
            this.stdIdLabel.TabIndex = 0;
            this.stdIdLabel.Text = "學號:";
            // 
            // stdIdTextBox
            // 
            this.stdIdTextBox.Location = new System.Drawing.Point(106, 50);
            this.stdIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stdIdTextBox.Name = "stdIdTextBox";
            this.stdIdTextBox.Size = new System.Drawing.Size(148, 29);
            this.stdIdTextBox.TabIndex = 1;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(288, 57);
            this.gradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(49, 18);
            this.gradeLabel.TabIndex = 0;
            this.gradeLabel.Text = "成績:";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(346, 50);
            this.gradeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(148, 29);
            this.gradeTextBox.TabIndex = 1;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(525, 50);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(112, 34);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "新增紀錄";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.searchBar);
            this.groupBox1.Controls.Add(this.showAverage);
            this.groupBox1.Controls.Add(this.averageLabel);
            this.groupBox1.Controls.Add(this.searchLabel);
            this.groupBox1.Location = new System.Drawing.Point(57, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(626, 414);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "學生成績";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 242);
            this.dataGridView1.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(272, 30);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(112, 34);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "查詢";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(94, 33);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(148, 29);
            this.searchBar.TabIndex = 1;
            // 
            // showAverage
            // 
            this.showAverage.AutoSize = true;
            this.showAverage.Location = new System.Drawing.Point(108, 360);
            this.showAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showAverage.Name = "showAverage";
            this.showAverage.Size = new System.Drawing.Size(101, 18);
            this.showAverage.TabIndex = 0;
            this.showAverage.Text = "showAverage";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(34, 360);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(67, 18);
            this.averageLabel.TabIndex = 0;
            this.averageLabel.Text = "總平均:";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(34, 33);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(49, 18);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "學號:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.stdIdTextBox);
            this.Controls.Add(this.stdIdLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label stdIdLabel;
		private System.Windows.Forms.TextBox stdIdTextBox;
		private System.Windows.Forms.Label gradeLabel;
		private System.Windows.Forms.TextBox gradeTextBox;
		private System.Windows.Forms.Button submitBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.TextBox searchBar;
		private System.Windows.Forms.Label searchLabel;
		private System.Windows.Forms.Label showAverage;
		private System.Windows.Forms.Label averageLabel;
	}
}

