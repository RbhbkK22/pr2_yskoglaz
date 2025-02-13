using System.Drawing;
using System.Windows.Forms;

namespace ReadingXML1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReadXmlButton = new System.Windows.Forms.Button();
            this.ShowSchemaButton = new System.Windows.Forms.Button();
            this.AuthorsDataSet = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 242);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(538, 292);
            this.textBox1.TabIndex = 1;
            // 
            // ReadXmlButton
            // 
            this.ReadXmlButton.Location = new System.Drawing.Point(556, 242);
            this.ReadXmlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadXmlButton.Name = "ReadXmlButton";
            this.ReadXmlButton.Size = new System.Drawing.Size(315, 292);
            this.ReadXmlButton.TabIndex = 2;
            this.ReadXmlButton.Text = "Прочитать XML";
            this.ReadXmlButton.UseVisualStyleBackColor = true;
            this.ReadXmlButton.Click += new System.EventHandler(this.ReadXmlButton_Click);
            // 
            // ShowSchemaButton
            // 
            this.ShowSchemaButton.Location = new System.Drawing.Point(877, 242);
            this.ShowSchemaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowSchemaButton.Name = "ShowSchemaButton";
            this.ShowSchemaButton.Size = new System.Drawing.Size(300, 292);
            this.ShowSchemaButton.TabIndex = 3;
            this.ShowSchemaButton.Text = "Показать схему";
            this.ShowSchemaButton.UseVisualStyleBackColor = true;
            this.ShowSchemaButton.Click += new System.EventHandler(this.ShowSchemaButton_Click);
            // 
            // AuthorsDataSet
            // 
            this.AuthorsDataSet.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 545);
            this.Controls.Add(this.ShowSchemaButton);
            this.Controls.Add(this.ReadXmlButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button ReadXmlButton;
        private Button ShowSchemaButton;
        private System.Data.DataSet AuthorsDataSet;
    }
}

