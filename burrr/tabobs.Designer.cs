
namespace burrr
{
    partial class tabobs
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
            this.обслуживаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.burrrDataSet5 = new burrr.burrrDataSet5();
            this.обслуживаниеTableAdapter = new burrr.burrrDataSet5TableAdapters.ОбслуживаниеTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.обслуживаниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burrrDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // обслуживаниеBindingSource
            // 
            this.обслуживаниеBindingSource.DataMember = "Обслуживание";
            this.обслуживаниеBindingSource.DataSource = this.burrrDataSet5;
            // 
            // burrrDataSet5
            // 
            this.burrrDataSet5.DataSetName = "burrrDataSet5";
            this.burrrDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // обслуживаниеTableAdapter
            // 
            this.обслуживаниеTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tabobs";
            this.Text = "tabobs";
            this.Load += new System.EventHandler(this.tabobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.обслуживаниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burrrDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private burrrDataSet5 burrrDataSet5;
        private System.Windows.Forms.BindingSource обслуживаниеBindingSource;
        private burrrDataSet5TableAdapters.ОбслуживаниеTableAdapter обслуживаниеTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}