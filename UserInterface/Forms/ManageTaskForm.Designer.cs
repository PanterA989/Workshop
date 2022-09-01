
namespace Workshop.UserInterface.Forms
{
    partial class ManageTaskForm
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
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpStatus = new System.Windows.Forms.TableLayoutPanel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.bsStatus = new System.Windows.Forms.BindingSource(this.components);
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.tlpKlient = new System.Windows.Forms.TableLayoutPanel();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.gbBike = new System.Windows.Forms.GroupBox();
            this.tlpBike = new System.Windows.Forms.TableLayoutPanel();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.labelFrameNo = new System.Windows.Forms.Label();
            this.tbFrameNo = new System.Windows.Forms.TextBox();
            this.labelAdditionalInfo = new System.Windows.Forms.Label();
            this.tbAdditionalInfo = new System.Windows.Forms.TextBox();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.tlpTask = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTaskUpper = new System.Windows.Forms.TableLayoutPanel();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbStartDateEditable = new System.Windows.Forms.CheckBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelCost = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tlpTaskLower = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.epPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.epManufacturer = new System.Windows.Forms.ErrorProvider(this.components);
            this.epModel = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.epStartDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFrameNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAddidtionalInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEndDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCost = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpForm.SuspendLayout();
            this.tlpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            this.tlpLeft.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.tlpKlient.SuspendLayout();
            this.gbBike.SuspendLayout();
            this.tlpBike.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.gbTask.SuspendLayout();
            this.tlpTask.SuspendLayout();
            this.tlpTaskUpper.SuspendLayout();
            this.tlpTaskLower.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFrameNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddidtionalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCost)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpForm
            // 
            this.tlpForm.ColumnCount = 2;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpForm.Controls.Add(this.tlpStatus, 0, 1);
            this.tlpForm.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpForm.Controls.Add(this.tlpRight, 1, 0);
            this.tlpForm.Controls.Add(this.tlpButtons, 1, 1);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 2;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpForm.Size = new System.Drawing.Size(800, 450);
            this.tlpForm.TabIndex = 0;
            // 
            // tlpStatus
            // 
            this.tlpStatus.ColumnCount = 2;
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatus.Controls.Add(this.labelStatus, 0, 0);
            this.tlpStatus.Controls.Add(this.cbStatus, 1, 0);
            this.tlpStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStatus.Location = new System.Drawing.Point(9, 408);
            this.tlpStatus.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.tlpStatus.Name = "tlpStatus";
            this.tlpStatus.RowCount = 1;
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatus.Size = new System.Drawing.Size(382, 39);
            this.tlpStatus.TabIndex = 5;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(57, 13);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.DataSource = this.bsStatus;
            this.cbStatus.DisplayMember = "Value";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(103, 9);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(276, 21);
            this.cbStatus.TabIndex = 1;
            this.cbStatus.ValueMember = "Id";
            // 
            // bsStatus
            // 
            this.bsStatus.DataSource = typeof(Workshop.DataAccessLayer.Models.Dictionaries.WorkshopTaskStatus);
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.gbClient, 0, 0);
            this.tlpLeft.Controls.Add(this.gbBike, 0, 1);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeft.Size = new System.Drawing.Size(394, 399);
            this.tlpLeft.TabIndex = 0;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.tlpKlient);
            this.gbClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbClient.Location = new System.Drawing.Point(3, 3);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(388, 157);
            this.gbClient.TabIndex = 0;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Klient";
            // 
            // tlpKlient
            // 
            this.tlpKlient.ColumnCount = 2;
            this.tlpKlient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpKlient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKlient.Controls.Add(this.labelFirstName, 0, 0);
            this.tlpKlient.Controls.Add(this.tbFirstName, 1, 0);
            this.tlpKlient.Controls.Add(this.labelLastName, 0, 1);
            this.tlpKlient.Controls.Add(this.tbLastName, 1, 1);
            this.tlpKlient.Controls.Add(this.labelPhone, 0, 2);
            this.tlpKlient.Controls.Add(this.tbPhone, 1, 2);
            this.tlpKlient.Controls.Add(this.labelEmail, 0, 3);
            this.tlpKlient.Controls.Add(this.tbEmail, 1, 3);
            this.tlpKlient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKlient.Location = new System.Drawing.Point(3, 16);
            this.tlpKlient.Name = "tlpKlient";
            this.tlpKlient.RowCount = 4;
            this.tlpKlient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpKlient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpKlient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpKlient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpKlient.Size = new System.Drawing.Size(382, 138);
            this.tlpKlient.TabIndex = 0;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(68, 11);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Imię:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(103, 7);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(276, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(41, 46);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Nazwisko:";
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(103, 42);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(276, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPhone.Location = new System.Drawing.Point(23, 81);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(74, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Nr telefonu:";
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhone.Location = new System.Drawing.Point(103, 77);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(276, 20);
            this.tbPhone.TabIndex = 3;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            this.tbPhone.Validated += new System.EventHandler(this.tbPhone_Validated);
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(60, 116);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(37, 13);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "e-mail:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(103, 112);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(276, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // gbBike
            // 
            this.gbBike.Controls.Add(this.tlpBike);
            this.gbBike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBike.Location = new System.Drawing.Point(3, 166);
            this.gbBike.Name = "gbBike";
            this.gbBike.Size = new System.Drawing.Size(388, 232);
            this.gbBike.TabIndex = 1;
            this.gbBike.TabStop = false;
            this.gbBike.Text = "Rower";
            // 
            // tlpBike
            // 
            this.tlpBike.ColumnCount = 2;
            this.tlpBike.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpBike.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBike.Controls.Add(this.labelManufacturer, 0, 0);
            this.tlpBike.Controls.Add(this.tbManufacturer, 1, 0);
            this.tlpBike.Controls.Add(this.labelModel, 0, 1);
            this.tlpBike.Controls.Add(this.tbModel, 1, 1);
            this.tlpBike.Controls.Add(this.labelFrameNo, 0, 2);
            this.tlpBike.Controls.Add(this.tbFrameNo, 1, 2);
            this.tlpBike.Controls.Add(this.labelAdditionalInfo, 0, 3);
            this.tlpBike.Controls.Add(this.tbAdditionalInfo, 1, 3);
            this.tlpBike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBike.Location = new System.Drawing.Point(3, 16);
            this.tlpBike.Name = "tlpBike";
            this.tlpBike.RowCount = 4;
            this.tlpBike.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBike.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBike.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBike.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBike.Size = new System.Drawing.Size(382, 213);
            this.tlpBike.TabIndex = 2;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelManufacturer.Location = new System.Drawing.Point(28, 11);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(69, 13);
            this.labelManufacturer.TabIndex = 0;
            this.labelManufacturer.Text = "Producent:";
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbManufacturer.Location = new System.Drawing.Point(103, 7);
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.Size = new System.Drawing.Size(276, 20);
            this.tbManufacturer.TabIndex = 5;
            this.tbManufacturer.TextChanged += new System.EventHandler(this.tbManufacturer_TextChanged);
            this.tbManufacturer.Validated += new System.EventHandler(this.tbManufacturer_Validated);
            // 
            // labelModel
            // 
            this.labelModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModel.Location = new System.Drawing.Point(52, 46);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(45, 13);
            this.labelModel.TabIndex = 1;
            this.labelModel.Text = "Model:";
            // 
            // tbModel
            // 
            this.tbModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModel.Location = new System.Drawing.Point(103, 42);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(276, 20);
            this.tbModel.TabIndex = 6;
            this.tbModel.TextChanged += new System.EventHandler(this.tbModel_TextChanged);
            this.tbModel.Validated += new System.EventHandler(this.tbModel_Validated);
            // 
            // labelFrameNo
            // 
            this.labelFrameNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFrameNo.AutoSize = true;
            this.labelFrameNo.Location = new System.Drawing.Point(51, 81);
            this.labelFrameNo.Name = "labelFrameNo";
            this.labelFrameNo.Size = new System.Drawing.Size(46, 13);
            this.labelFrameNo.TabIndex = 2;
            this.labelFrameNo.Text = "Nr ramy:";
            // 
            // tbFrameNo
            // 
            this.tbFrameNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFrameNo.Location = new System.Drawing.Point(103, 77);
            this.tbFrameNo.Name = "tbFrameNo";
            this.tbFrameNo.Size = new System.Drawing.Size(276, 20);
            this.tbFrameNo.TabIndex = 7;
            // 
            // labelAdditionalInfo
            // 
            this.labelAdditionalInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAdditionalInfo.AutoSize = true;
            this.labelAdditionalInfo.Location = new System.Drawing.Point(32, 146);
            this.labelAdditionalInfo.Name = "labelAdditionalInfo";
            this.labelAdditionalInfo.Size = new System.Drawing.Size(65, 26);
            this.labelAdditionalInfo.TabIndex = 3;
            this.labelAdditionalInfo.Text = "Dodatkowe informacje:";
            // 
            // tbAdditionalInfo
            // 
            this.tbAdditionalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdditionalInfo.Location = new System.Drawing.Point(103, 108);
            this.tbAdditionalInfo.Multiline = true;
            this.tbAdditionalInfo.Name = "tbAdditionalInfo";
            this.tbAdditionalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAdditionalInfo.Size = new System.Drawing.Size(276, 102);
            this.tbAdditionalInfo.TabIndex = 8;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRight.Controls.Add(this.gbTask, 0, 0);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(403, 3);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 1;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.tlpRight.Size = new System.Drawing.Size(394, 399);
            this.tlpRight.TabIndex = 2;
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.tlpTask);
            this.gbTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTask.Location = new System.Drawing.Point(3, 3);
            this.gbTask.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(388, 396);
            this.gbTask.TabIndex = 1;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Zlecenie";
            // 
            // tlpTask
            // 
            this.tlpTask.ColumnCount = 1;
            this.tlpTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTask.Controls.Add(this.tlpTaskUpper, 0, 0);
            this.tlpTask.Controls.Add(this.tlpTaskLower, 0, 1);
            this.tlpTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTask.Location = new System.Drawing.Point(3, 16);
            this.tlpTask.Name = "tlpTask";
            this.tlpTask.RowCount = 2;
            this.tlpTask.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTask.Size = new System.Drawing.Size(382, 377);
            this.tlpTask.TabIndex = 0;
            // 
            // tlpTaskUpper
            // 
            this.tlpTaskUpper.ColumnCount = 2;
            this.tlpTaskUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTaskUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTaskUpper.Controls.Add(this.labelStartDate, 0, 0);
            this.tlpTaskUpper.Controls.Add(this.dtpStartDate, 1, 0);
            this.tlpTaskUpper.Controls.Add(this.cbStartDateEditable, 0, 1);
            this.tlpTaskUpper.Controls.Add(this.labelEndDate, 0, 2);
            this.tlpTaskUpper.Controls.Add(this.dtpEndDate, 1, 2);
            this.tlpTaskUpper.Controls.Add(this.labelCost, 0, 3);
            this.tlpTaskUpper.Controls.Add(this.tbCost, 1, 3);
            this.tlpTaskUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTaskUpper.Location = new System.Drawing.Point(3, 3);
            this.tlpTaskUpper.Name = "tlpTaskUpper";
            this.tlpTaskUpper.RowCount = 4;
            this.tlpTaskUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpTaskUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpTaskUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpTaskUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpTaskUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTaskUpper.Size = new System.Drawing.Size(376, 138);
            this.tlpTaskUpper.TabIndex = 2;
            // 
            // labelStartDate
            // 
            this.labelStartDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStartDate.Location = new System.Drawing.Point(5, 11);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(92, 13);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "Data przyjęcia:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Location = new System.Drawing.Point(103, 7);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(270, 20);
            this.dtpStartDate.TabIndex = 10;
            // 
            // cbStartDateEditable
            // 
            this.cbStartDateEditable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStartDateEditable.AutoSize = true;
            this.cbStartDateEditable.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbStartDateEditable.Location = new System.Drawing.Point(14, 35);
            this.cbStartDateEditable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.cbStartDateEditable.Name = "cbStartDateEditable";
            this.cbStartDateEditable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbStartDateEditable.Size = new System.Drawing.Size(83, 16);
            this.cbStartDateEditable.TabIndex = 9;
            this.cbStartDateEditable.Text = "inna niż dzisiaj";
            this.cbStartDateEditable.UseVisualStyleBackColor = true;
            this.cbStartDateEditable.CheckedChanged += new System.EventHandler(this.IsStartDateNotToday_CheckedChanged);
            // 
            // labelEndDate
            // 
            this.labelEndDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(19, 74);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(78, 26);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "Przewidywana data realizacji:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Checked = false;
            this.dtpEndDate.CustomFormat = " ";
            this.dtpEndDate.Location = new System.Drawing.Point(103, 77);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowCheckBox = true;
            this.dtpEndDate.Size = new System.Drawing.Size(270, 20);
            this.dtpEndDate.TabIndex = 11;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // labelCost
            // 
            this.labelCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(62, 116);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(35, 13);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Cena:";
            // 
            // tbCost
            // 
            this.tbCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCost.Location = new System.Drawing.Point(103, 112);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(270, 20);
            this.tbCost.TabIndex = 12;
            // 
            // tlpTaskLower
            // 
            this.tlpTaskLower.ColumnCount = 1;
            this.tlpTaskLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTaskLower.Controls.Add(this.labelDescription, 0, 0);
            this.tlpTaskLower.Controls.Add(this.tbDescription, 0, 1);
            this.tlpTaskLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTaskLower.Location = new System.Drawing.Point(3, 147);
            this.tlpTaskLower.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tlpTaskLower.Name = "tlpTaskLower";
            this.tlpTaskLower.RowCount = 2;
            this.tlpTaskLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpTaskLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTaskLower.Size = new System.Drawing.Size(376, 230);
            this.tlpTaskLower.TabIndex = 3;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(3, 11);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(87, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Opis zlecenia:";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(3, 38);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(370, 189);
            this.tbDescription.TabIndex = 13;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 3;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpButtons.Controls.Add(this.buttonConfirm, 1, 0);
            this.tlpButtons.Controls.Add(this.buttonCancel, 2, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(403, 408);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(394, 39);
            this.tlpButtons.TabIndex = 3;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Image = global::Workshop.UserInterface.Properties.Resources.add_24;
            this.buttonConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirm.Location = new System.Drawing.Point(197, 3);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.buttonConfirm.Size = new System.Drawing.Size(94, 33);
            this.buttonConfirm.TabIndex = 14;
            this.buttonConfirm.Text = "Dodaj";
            this.buttonConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Image = global::Workshop.UserInterface.Properties.Resources.delete_24;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(297, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.buttonCancel.Size = new System.Drawing.Size(94, 33);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // epPhone
            // 
            this.epPhone.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPhone.ContainerControl = this;
            // 
            // epManufacturer
            // 
            this.epManufacturer.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epManufacturer.ContainerControl = this;
            // 
            // epModel
            // 
            this.epModel.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epModel.ContainerControl = this;
            // 
            // epDescription
            // 
            this.epDescription.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epDescription.ContainerControl = this;
            // 
            // epStartDate
            // 
            this.epStartDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epStartDate.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFirstName.ContainerControl = this;
            // 
            // epLastName
            // 
            this.epLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLastName.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epEmail.ContainerControl = this;
            // 
            // epFrameNo
            // 
            this.epFrameNo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFrameNo.ContainerControl = this;
            // 
            // epAddidtionalInfo
            // 
            this.epAddidtionalInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epAddidtionalInfo.ContainerControl = this;
            // 
            // epEndDate
            // 
            this.epEndDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epEndDate.ContainerControl = this;
            // 
            // epCost
            // 
            this.epCost.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epCost.ContainerControl = this;
            // 
            // ManageTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpForm);
            this.Name = "ManageTaskForm";
            this.ShowIcon = false;
            this.Text = "Dodawanie nowego zlecenia";
            this.tlpForm.ResumeLayout(false);
            this.tlpStatus.ResumeLayout(false);
            this.tlpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            this.tlpLeft.ResumeLayout(false);
            this.gbClient.ResumeLayout(false);
            this.tlpKlient.ResumeLayout(false);
            this.tlpKlient.PerformLayout();
            this.gbBike.ResumeLayout(false);
            this.tlpBike.ResumeLayout(false);
            this.tlpBike.PerformLayout();
            this.tlpRight.ResumeLayout(false);
            this.gbTask.ResumeLayout(false);
            this.tlpTask.ResumeLayout(false);
            this.tlpTaskUpper.ResumeLayout(false);
            this.tlpTaskUpper.PerformLayout();
            this.tlpTaskLower.ResumeLayout(false);
            this.tlpTaskLower.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFrameNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddidtionalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.TableLayoutPanel tlpKlient;
        private System.Windows.Forms.GroupBox gbBike;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tlpBike;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelFrameNo;
        private System.Windows.Forms.Label labelAdditionalInfo;
        private System.Windows.Forms.TextBox tbFrameNo;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.TextBox tbAdditionalInfo;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.TableLayoutPanel tlpTask;
        private System.Windows.Forms.TableLayoutPanel tlpTaskUpper;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.CheckBox cbStartDateEditable;
        private System.Windows.Forms.TableLayoutPanel tlpTaskLower;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ErrorProvider epPhone;
        private System.Windows.Forms.ErrorProvider epManufacturer;
        private System.Windows.Forms.ErrorProvider epModel;
        private System.Windows.Forms.ErrorProvider epDescription;
        private System.Windows.Forms.ErrorProvider epStartDate;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epFrameNo;
        private System.Windows.Forms.ErrorProvider epAddidtionalInfo;
        private System.Windows.Forms.ErrorProvider epEndDate;
        private System.Windows.Forms.ErrorProvider epCost;
        private System.Windows.Forms.TableLayoutPanel tlpStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.BindingSource bsStatus;
    }
}