
namespace LastProjectAirline
{
    partial class Tickets
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
            this.flightnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceofticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabintypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRLINE_TICKET_RESERVATIONDataSet = new LastProjectAirline.AIRLINE_TICKET_RESERVATIONDataSet();
            this.ticketTableAdapter = new LastProjectAirline.AIRLINE_TICKET_RESERVATIONDataSetTableAdapters.ticketTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRLINE_TICKET_RESERVATIONDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightnoDataGridViewTextBoxColumn,
            this.ticketnoDataGridViewTextBoxColumn,
            this.priceofticketDataGridViewTextBoxColumn,
            this.airportnameDataGridViewTextBoxColumn,
            this.passportidDataGridViewTextBoxColumn,
            this.cabintypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(798, 549);
            this.dataGridView1.TabIndex = 0;
            // 
            // flightnoDataGridViewTextBoxColumn
            // 
            this.flightnoDataGridViewTextBoxColumn.DataPropertyName = "flight_no";
            this.flightnoDataGridViewTextBoxColumn.HeaderText = "flight_no";
            this.flightnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flightnoDataGridViewTextBoxColumn.Name = "flightnoDataGridViewTextBoxColumn";
            this.flightnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketnoDataGridViewTextBoxColumn
            // 
            this.ticketnoDataGridViewTextBoxColumn.DataPropertyName = "ticket_no";
            this.ticketnoDataGridViewTextBoxColumn.HeaderText = "ticket_no";
            this.ticketnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketnoDataGridViewTextBoxColumn.Name = "ticketnoDataGridViewTextBoxColumn";
            this.ticketnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceofticketDataGridViewTextBoxColumn
            // 
            this.priceofticketDataGridViewTextBoxColumn.DataPropertyName = "price_of_ticket";
            this.priceofticketDataGridViewTextBoxColumn.HeaderText = "price_of_ticket";
            this.priceofticketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceofticketDataGridViewTextBoxColumn.Name = "priceofticketDataGridViewTextBoxColumn";
            this.priceofticketDataGridViewTextBoxColumn.Width = 125;
            // 
            // airportnameDataGridViewTextBoxColumn
            // 
            this.airportnameDataGridViewTextBoxColumn.DataPropertyName = "airport_name";
            this.airportnameDataGridViewTextBoxColumn.HeaderText = "airport_name";
            this.airportnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.airportnameDataGridViewTextBoxColumn.Name = "airportnameDataGridViewTextBoxColumn";
            this.airportnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportidDataGridViewTextBoxColumn
            // 
            this.passportidDataGridViewTextBoxColumn.DataPropertyName = "passport_id";
            this.passportidDataGridViewTextBoxColumn.HeaderText = "passport_id";
            this.passportidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportidDataGridViewTextBoxColumn.Name = "passportidDataGridViewTextBoxColumn";
            this.passportidDataGridViewTextBoxColumn.Width = 125;
            // 
            // cabintypeDataGridViewTextBoxColumn
            // 
            this.cabintypeDataGridViewTextBoxColumn.DataPropertyName = "cabin_type";
            this.cabintypeDataGridViewTextBoxColumn.HeaderText = "cabin_type";
            this.cabintypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cabintypeDataGridViewTextBoxColumn.Name = "cabintypeDataGridViewTextBoxColumn";
            this.cabintypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "ticket";
            this.ticketBindingSource.DataSource = this.aIRLINE_TICKET_RESERVATIONDataSet;
            // 
            // aIRLINE_TICKET_RESERVATIONDataSet
            // 
            this.aIRLINE_TICKET_RESERVATIONDataSet.DataSetName = "AIRLINE_TICKET_RESERVATIONDataSet";
            this.aIRLINE_TICKET_RESERVATIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(601, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close Form";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(23, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Ticket";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(23, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Ticket";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRLINE_TICKET_RESERVATIONDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AIRLINE_TICKET_RESERVATIONDataSet aIRLINE_TICKET_RESERVATIONDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private AIRLINE_TICKET_RESERVATIONDataSetTableAdapters.ticketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceofticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabintypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}