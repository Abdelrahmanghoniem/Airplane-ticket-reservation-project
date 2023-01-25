
namespace LastProjectAirline
{
    partial class Airline
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.airlinenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRLINE_TICKET_RESERVATIONDataSet = new LastProjectAirline.AIRLINE_TICKET_RESERVATIONDataSet();
            this.airlineTableAdapter = new LastProjectAirline.AIRLINE_TICKET_RESERVATIONDataSetTableAdapters.airlineTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRLINE_TICKET_RESERVATIONDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airlinenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.airlineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(291, 494);
            this.dataGridView1.TabIndex = 0;
            // 
            // airlinenameDataGridViewTextBoxColumn
            // 
            this.airlinenameDataGridViewTextBoxColumn.DataPropertyName = "airline_name";
            this.airlinenameDataGridViewTextBoxColumn.HeaderText = "airline_name";
            this.airlinenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.airlinenameDataGridViewTextBoxColumn.Name = "airlinenameDataGridViewTextBoxColumn";
            this.airlinenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // airlineBindingSource
            // 
            this.airlineBindingSource.DataMember = "airline";
            this.airlineBindingSource.DataSource = this.aIRLINE_TICKET_RESERVATIONDataSet;
            // 
            // aIRLINE_TICKET_RESERVATIONDataSet
            // 
            this.aIRLINE_TICKET_RESERVATIONDataSet.DataSetName = "AIRLINE_TICKET_RESERVATIONDataSet";
            this.aIRLINE_TICKET_RESERVATIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airlineTableAdapter
            // 
            this.airlineTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(102, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close Form";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(176, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Airline";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(30, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Airline";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Airline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 497);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Airline";
            this.Text = "Airline";
            this.Load += new System.EventHandler(this.Airline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRLINE_TICKET_RESERVATIONDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AIRLINE_TICKET_RESERVATIONDataSet aIRLINE_TICKET_RESERVATIONDataSet;
        private System.Windows.Forms.BindingSource airlineBindingSource;
        private AIRLINE_TICKET_RESERVATIONDataSetTableAdapters.airlineTableAdapter airlineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlinenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}