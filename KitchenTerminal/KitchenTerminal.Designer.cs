namespace KitchenTerminal
{
    partial class KitchenTerminal
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInPreparation = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnPicked = new System.Windows.Forms.Button();
            this.gvDishCollection = new System.Windows.Forms.DataGridView();
            this.colDishId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDishType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDishStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDishCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gvDishCollection, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnInPreparation);
            this.flowLayoutPanel1.Controls.Add(this.btnReady);
            this.flowLayoutPanel1.Controls.Add(this.btnPicked);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 363);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 84);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnInPreparation
            // 
            this.btnInPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInPreparation.Location = new System.Drawing.Point(3, 3);
            this.btnInPreparation.Name = "btnInPreparation";
            this.btnInPreparation.Size = new System.Drawing.Size(254, 81);
            this.btnInPreparation.TabIndex = 0;
            this.btnInPreparation.Text = "In preparation";
            this.btnInPreparation.UseVisualStyleBackColor = true;
            this.btnInPreparation.Click += new System.EventHandler(this.btnInPreparation_Click);
            // 
            // btnReady
            // 
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReady.Location = new System.Drawing.Point(263, 3);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(272, 81);
            this.btnReady.TabIndex = 1;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnPicked
            // 
            this.btnPicked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPicked.Location = new System.Drawing.Point(541, 3);
            this.btnPicked.Name = "btnPicked";
            this.btnPicked.Size = new System.Drawing.Size(244, 81);
            this.btnPicked.TabIndex = 2;
            this.btnPicked.Text = "Picked up";
            this.btnPicked.UseVisualStyleBackColor = true;
            this.btnPicked.Click += new System.EventHandler(this.btnPicked_Click);
            // 
            // gvDishCollection
            // 
            this.gvDishCollection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDishCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDishCollection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDishId,
            this.colDishName,
            this.colDishType,
            this.colDishStatus});
            this.gvDishCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDishCollection.Location = new System.Drawing.Point(3, 3);
            this.gvDishCollection.Name = "gvDishCollection";
            this.gvDishCollection.RowTemplate.Height = 24;
            this.gvDishCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDishCollection.Size = new System.Drawing.Size(794, 354);
            this.gvDishCollection.TabIndex = 1;
            this.gvDishCollection.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvDishCollection_CellFormatting);
            // 
            // colDishId
            // 
            this.colDishId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDishId.DataPropertyName = "Id";
            this.colDishId.HeaderText = "Id";
            this.colDishId.Name = "colDishId";
            // 
            // colDishName
            // 
            this.colDishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDishName.DataPropertyName = "TableNumber";
            this.colDishName.HeaderText = "TableNumber";
            this.colDishName.Name = "colDishName";
            // 
            // colDishType
            // 
            this.colDishType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDishType.DataPropertyName = "Status";
            this.colDishType.HeaderText = "Status";
            this.colDishType.Name = "colDishType";
            // 
            // colDishStatus
            // 
            this.colDishStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDishStatus.DataPropertyName = "Destination";
            this.colDishStatus.HeaderText = "Destination";
            this.colDishStatus.Name = "colDishStatus";
            // 
            // KitchenTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KitchenTerminal";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDishCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnInPreparation;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnPicked;
        private System.Windows.Forms.DataGridView gvDishCollection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDishId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDishType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDishStatus;
    }
}

