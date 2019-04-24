namespace WaitressTerminal
{
    partial class WaitressTerminalForm
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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.operationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.orderManagerLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.gvOrders = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.mainLayoutPanel.SuspendLayout();
            this.operationLayoutPanel.SuspendLayout();
            this.orderManagerLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.Controls.Add(this.operationLayoutPanel, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.gvOrders, 0, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(1186, 282);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // operationLayoutPanel
            // 
            this.operationLayoutPanel.ColumnCount = 1;
            this.operationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operationLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.operationLayoutPanel.Controls.Add(this.orderManagerLayoutPanel, 0, 1);
            this.operationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationLayoutPanel.Location = new System.Drawing.Point(596, 3);
            this.operationLayoutPanel.Name = "operationLayoutPanel";
            this.operationLayoutPanel.RowCount = 2;
            this.operationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.95911F));
            this.operationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.04089F));
            this.operationLayoutPanel.Size = new System.Drawing.Size(587, 276);
            this.operationLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order manager";
            // 
            // orderManagerLayoutPanel
            // 
            this.orderManagerLayoutPanel.Controls.Add(this.CreateOrderButton);
            this.orderManagerLayoutPanel.Controls.Add(this.EditOrderButton);
            this.orderManagerLayoutPanel.Controls.Add(this.DeleteOrderButton);
            this.orderManagerLayoutPanel.Controls.Add(this.btnSend);
            this.orderManagerLayoutPanel.Controls.Add(this.btnDeliver);
            this.orderManagerLayoutPanel.Controls.Add(this.btnSubmit);
            this.orderManagerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderManagerLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderManagerLayoutPanel.Location = new System.Drawing.Point(3, 55);
            this.orderManagerLayoutPanel.Name = "orderManagerLayoutPanel";
            this.orderManagerLayoutPanel.Size = new System.Drawing.Size(581, 218);
            this.orderManagerLayoutPanel.TabIndex = 1;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateOrderButton.Location = new System.Drawing.Point(3, 3);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(199, 55);
            this.CreateOrderButton.TabIndex = 0;
            this.CreateOrderButton.Text = "Create order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditOrderButton.Location = new System.Drawing.Point(208, 3);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(180, 55);
            this.EditOrderButton.TabIndex = 1;
            this.EditOrderButton.Text = "Edit order";
            this.EditOrderButton.UseVisualStyleBackColor = true;
            this.EditOrderButton.Click += new System.EventHandler(this.EditOrderButton_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSubmit.Location = new System.Drawing.Point(394, 64);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 55);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteOrderButton.Location = new System.Drawing.Point(394, 3);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(184, 55);
            this.DeleteOrderButton.TabIndex = 3;
            this.DeleteOrderButton.Text = "Delete order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // gvOrders
            // 
            this.gvOrders.AllowUserToAddRows = false;
            this.gvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.TableColumn,
            this.DestinationColumn,
            this.StatusColumn});
            this.gvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvOrders.Location = new System.Drawing.Point(3, 3);
            this.gvOrders.MultiSelect = false;
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.RowTemplate.Height = 24;
            this.gvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOrders.Size = new System.Drawing.Size(587, 276);
            this.gvOrders.TabIndex = 1;
            this.gvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrders_CellContentClick);
            this.gvOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvOrders_CellFormatting);
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Order Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // TableColumn
            // 
            this.TableColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TableColumn.DataPropertyName = "TableNumber";
            this.TableColumn.HeaderText = "Table number";
            this.TableColumn.Name = "TableColumn";
            // 
            // DestinationColumn
            // 
            this.DestinationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DestinationColumn.DataPropertyName = "Destination";
            this.DestinationColumn.HeaderText = "Destination";
            this.DestinationColumn.Name = "DestinationColumn";
            // 
            // StatusColumn
            // 
            this.StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusColumn.DataPropertyName = "Status";
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSend.Location = new System.Drawing.Point(3, 64);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(199, 55);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeliver.Location = new System.Drawing.Point(208, 64);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(180, 55);
            this.btnDeliver.TabIndex = 5;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // WaitressTerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 282);
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "WaitressTerminalForm";
            this.Text = "WaitressTerminalForm";
            this.Load += new System.EventHandler(this.WaitressTerminalForm_Load);
            this.mainLayoutPanel.ResumeLayout(false);
            this.operationLayoutPanel.ResumeLayout(false);
            this.operationLayoutPanel.PerformLayout();
            this.orderManagerLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel operationLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel orderManagerLayoutPanel;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView gvOrders;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDeliver;
    }
}