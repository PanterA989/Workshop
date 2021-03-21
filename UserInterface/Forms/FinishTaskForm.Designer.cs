
namespace Workshop.UserInterface.Forms
{
    partial class FinishTaskForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTaskStatus = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTaskManufacturer = new System.Windows.Forms.Label();
            this.labelTaskModel = new System.Windows.Forms.Label();
            this.labelTaskPhone = new System.Windows.Forms.Label();
            this.bsStatus = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Location = new System.Drawing.Point(226, 163);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 33);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelTaskStatus, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelManufacturer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelModel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelPhone, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelStatus, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelTaskManufacturer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTaskModel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelTaskPhone, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(541, 151);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelTaskStatus
            // 
            this.labelTaskStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTaskStatus.AutoSize = true;
            this.labelTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTaskStatus.Location = new System.Drawing.Point(87, 124);
            this.labelTaskStatus.Name = "labelTaskStatus";
            this.labelTaskStatus.Size = new System.Drawing.Size(109, 13);
            this.labelTaskStatus.TabIndex = 7;
            this.labelTaskStatus.Text = "DUMMY_STATUS";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(20, 13);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(59, 13);
            this.labelManufacturer.TabIndex = 0;
            this.labelManufacturer.Text = "Producent:";
            // 
            // labelModel
            // 
            this.labelModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(40, 50);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(39, 13);
            this.labelModel.TabIndex = 1;
            this.labelModel.Text = "Model:";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(17, 87);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(62, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Nr telefonu:";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(11, 124);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(68, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Nowy status:";
            // 
            // labelTaskManufacturer
            // 
            this.labelTaskManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTaskManufacturer.AutoSize = true;
            this.labelTaskManufacturer.Location = new System.Drawing.Point(87, 13);
            this.labelTaskManufacturer.Name = "labelTaskManufacturer";
            this.labelTaskManufacturer.Size = new System.Drawing.Size(144, 13);
            this.labelTaskManufacturer.TabIndex = 4;
            this.labelTaskManufacturer.Text = "DUMMY_MANUFACTURER";
            // 
            // labelTaskModel
            // 
            this.labelTaskModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTaskModel.AutoSize = true;
            this.labelTaskModel.Location = new System.Drawing.Point(87, 50);
            this.labelTaskModel.Name = "labelTaskModel";
            this.labelTaskModel.Size = new System.Drawing.Size(92, 13);
            this.labelTaskModel.TabIndex = 5;
            this.labelTaskModel.Text = "DUMMY_MODEL";
            // 
            // labelTaskPhone
            // 
            this.labelTaskPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTaskPhone.AutoSize = true;
            this.labelTaskPhone.Location = new System.Drawing.Point(87, 87);
            this.labelTaskPhone.Name = "labelTaskPhone";
            this.labelTaskPhone.Size = new System.Drawing.Size(92, 13);
            this.labelTaskPhone.TabIndex = 6;
            this.labelTaskPhone.Text = "DUMMY_PHONE";
            // 
            // bsStatus
            // 
            this.bsStatus.DataSource = typeof(Workshop.DataAccessLayer.Models.Dictionaries.StatusModel);
            // 
            // FinishTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(547, 202);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FinishTaskForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zakończenie zlecenia";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelTaskManufacturer;
        private System.Windows.Forms.Label labelTaskModel;
        private System.Windows.Forms.Label labelTaskPhone;
        private System.Windows.Forms.BindingSource bsStatus;
        private System.Windows.Forms.Label labelTaskStatus;
    }
}