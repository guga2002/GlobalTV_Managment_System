namespace GlobalTV
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
            System.Windows.Forms.Label workLabel;
            System.Windows.Forms.Label channelLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label startLabel;
            System.Windows.Forms.Label endLabel;
            System.Windows.Forms.Label workerLabel;
            System.Windows.Forms.Label comments_P_S_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            this.globalTVBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.globalTVBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.globalTVDataGridView = new System.Windows.Forms.DataGridView();
            this.workTextBox = new System.Windows.Forms.TextBox();
            this.channelComboBox = new System.Windows.Forms.ComboBox();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.comments_P_S_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.globalTVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbMarjDataSet = new GlobalTV.DbMarjDataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.globalTVTableAdapter = new GlobalTV.DbMarjDataSetTableAdapters.GlobalTVTableAdapter();
            this.tableAdapterManager = new GlobalTV.DbMarjDataSetTableAdapters.TableAdapterManager();
            workLabel = new System.Windows.Forms.Label();
            channelLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            startLabel = new System.Windows.Forms.Label();
            endLabel = new System.Windows.Forms.Label();
            workerLabel = new System.Windows.Forms.Label();
            comments_P_S_Label = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.globalTVBindingNavigator)).BeginInit();
            this.globalTVBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalTVDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalTVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMarjDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // workLabel
            // 
            workLabel.AutoSize = true;
            workLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            workLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            workLabel.Location = new System.Drawing.Point(152, 77);
            workLabel.Name = "workLabel";
            workLabel.Size = new System.Drawing.Size(62, 16);
            workLabel.TabIndex = 2;
            workLabel.Text = "სამუშაო";
            workLabel.Click += new System.EventHandler(this.workLabel_Click);
            // 
            // channelLabel
            // 
            channelLabel.AutoSize = true;
            channelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            channelLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            channelLabel.Location = new System.Drawing.Point(152, 109);
            channelLabel.Name = "channelLabel";
            channelLabel.Size = new System.Drawing.Size(38, 16);
            channelLabel.TabIndex = 4;
            channelLabel.Text = "არხი";
            channelLabel.Click += new System.EventHandler(this.channelLabel_Click);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dateLabel.Location = new System.Drawing.Point(154, 135);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(146, 16);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "თარიღი (რიცხვი-თვე)";
            dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            startLabel.Location = new System.Drawing.Point(152, 164);
            startLabel.Name = "startLabel";
            startLabel.Size = new System.Drawing.Size(110, 16);
            startLabel.TabIndex = 8;
            startLabel.Text = "დაწყება(სთ:წთ)";
            startLabel.Click += new System.EventHandler(this.startLabel_Click);
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            endLabel.Location = new System.Drawing.Point(152, 194);
            endLabel.Name = "endLabel";
            endLabel.Size = new System.Drawing.Size(136, 16);
            endLabel.TabIndex = 10;
            endLabel.Text = "დასრულება(სთ:წთ)";
            endLabel.Click += new System.EventHandler(this.endLabel_Click);
            // 
            // workerLabel
            // 
            workerLabel.AutoSize = true;
            workerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            workerLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            workerLabel.Location = new System.Drawing.Point(156, 221);
            workerLabel.Name = "workerLabel";
            workerLabel.Size = new System.Drawing.Size(56, 16);
            workerLabel.TabIndex = 12;
            workerLabel.Text = "მორიგე";
            workerLabel.Click += new System.EventHandler(this.workerLabel_Click);
            // 
            // comments_P_S_Label
            // 
            comments_P_S_Label.AutoSize = true;
            comments_P_S_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            comments_P_S_Label.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            comments_P_S_Label.Location = new System.Drawing.Point(149, 248);
            comments_P_S_Label.Name = "comments_P_S_Label";
            comments_P_S_Label.Size = new System.Drawing.Size(65, 16);
            comments_P_S_Label.TabIndex = 14;
            comments_P_S_Label.Text = "შენიშვნა";
            comments_P_S_Label.Click += new System.EventHandler(this.comments_P_S_Label_Click);
            // 
            // globalTVBindingNavigator
            // 
            this.globalTVBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.globalTVBindingNavigator.BindingSource = this.globalTVBindingSource;
            this.globalTVBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.globalTVBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.globalTVBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.globalTVBindingNavigatorSaveItem});
            this.globalTVBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.globalTVBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.globalTVBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.globalTVBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.globalTVBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.globalTVBindingNavigator.Name = "globalTVBindingNavigator";
            this.globalTVBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.globalTVBindingNavigator.Size = new System.Drawing.Size(1004, 25);
            this.globalTVBindingNavigator.TabIndex = 0;
            this.globalTVBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Checked = true;
            this.bindingNavigatorAddNewItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // globalTVBindingNavigatorSaveItem
            // 
            this.globalTVBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.globalTVBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("globalTVBindingNavigatorSaveItem.Image")));
            this.globalTVBindingNavigatorSaveItem.Name = "globalTVBindingNavigatorSaveItem";
            this.globalTVBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.globalTVBindingNavigatorSaveItem.Text = "Save Data";
            this.globalTVBindingNavigatorSaveItem.Click += new System.EventHandler(this.globalTVBindingNavigatorSaveItem_Click);
            // 
            // globalTVDataGridView
            // 
            this.globalTVDataGridView.AutoGenerateColumns = false;
            this.globalTVDataGridView.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.globalTVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.globalTVDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.workDataGridViewTextBoxColumn,
            this.channelDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.workerDataGridViewTextBoxColumn,
            this.commentsPSDataGridViewTextBoxColumn});
            this.globalTVDataGridView.DataSource = this.globalTVBindingSource;
            this.globalTVDataGridView.Location = new System.Drawing.Point(12, 283);
            this.globalTVDataGridView.Name = "globalTVDataGridView";
            this.globalTVDataGridView.ReadOnly = true;
            this.globalTVDataGridView.Size = new System.Drawing.Size(972, 220);
            this.globalTVDataGridView.TabIndex = 1;
            this.globalTVDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.globalTVDataGridView_CellContentClick);
            // 
            // workTextBox
            // 
            this.workTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.workTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalTVBindingSource, "Work", true));
            this.workTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workTextBox.ForeColor = System.Drawing.Color.Black;
            this.workTextBox.Location = new System.Drawing.Point(304, 72);
            this.workTextBox.Name = "workTextBox";
            this.workTextBox.Size = new System.Drawing.Size(484, 24);
            this.workTextBox.TabIndex = 3;
            this.workTextBox.TextChanged += new System.EventHandler(this.workTextBox_TextChanged);
            // 
            // channelComboBox
            // 
            this.channelComboBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.channelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalTVBindingSource, "Channel", true));
            this.channelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.channelComboBox.ForeColor = System.Drawing.Color.Black;
            this.channelComboBox.FormattingEnabled = true;
            this.channelComboBox.Items.AddRange(new object[] {
            "Comedy Arxi",
            "Starvizia",
            "Doctor",
            "Silk Kids",
            "Silk Koleqcia",
            "Kinomix",
            "Drive",
            "Mtavari Arkhi",
            "Silk Hollywood",
            "Silk Sport 2",
            "Silk Sport 3",
            "Silk Sport 1",
            "Silk Universal",
            "KHL",
            "Detski",
            "Nickelodeon",
            "Mult",
            "Music Box",
            "Silk Documentary",
            "Mujskoe Kino",
            "Marao",
            "Jivaya Planeta",
            "Rustavi 2",
            "Viasat Nature",
            "Amedia 1",
            "Amedia Hit",
            "BBC World",
            "Domashnie Jivotnie",
            "Cinema",
            "Amedia Premium",
            "RTR Planeta",
            "Eurokino",
            "Dozhd",
            "Oxota i Ribalka",
            "GDS",
            "English Club",
            "illuzion +",
            "RTVi",
            "fenix + kino",
            "24 Techno",
            "Kinosvidania",
            "kinoHit",
            "Nashe Novoe kino",
            "kino Premiera",
            "Rossya Kultura",
            "Orujie",
            "CNBC",
            "Moya Planeta",
            "Nauka",
            "Viasat Explorer",
            "1 TV Georgia",
            "Dom Kino",
            "DTX",
            "DW",
            "Viasat Sport",
            "ORT",
            "TV 1000",
            "TV 1000 Action",
            "Setanta Georgia",
            "Setanta Sport +",
            "Imedi",
            "Discovery Science",
            "Dia TV",
            "Silk Sport 1",
            "Pulsi TV",
            "Palitra News",
            "Enki-Benki",
            "TNT Comedy",
            "TV 1000 RuKino",
            "Viasat History",
            "Da Vinchi",
            "Silk Sport 2",
            "Artarea",
            "Quality Channel",
            "Qartuli Arxi",
            "Mega TV",
            "Trialeti",
            "POS TV",
            "CNBC",
            "Nickelodeon",
            "Karusel",
            "Adjara Sport 1",
            "Adjara Sport 2",
            "TNT Comedy",
            "Mezzo",
            "Maestro",
            "TV Pirveli",
            "KinoSeria",
            "Indiskoe Kino",
            "KinoKomedia",
            "Kavkasia",
            "1 TV/ganatleba",
            "Formula",
            "Auto +",
            "Travel+ Advanture",
            "Obieqtivi",
            "TV 4 (Qvemo Kartvli)",
            "Rioni",
            "Ertsulovneba ",
            "Dia TV",
            "Afxazetis Xma ",
            "Agro TV",
            "Ragbi TV",
            "Enki-Benki",
            "Qartuli Arxi",
            "Euronews Geo",
            "Girchi TV"});
            this.channelComboBox.Location = new System.Drawing.Point(304, 104);
            this.channelComboBox.Name = "channelComboBox";
            this.channelComboBox.Size = new System.Drawing.Size(484, 26);
            this.channelComboBox.TabIndex = 5;
            this.channelComboBox.SelectedIndexChanged += new System.EventHandler(this.channelComboBox_SelectedIndexChanged);
            // 
            // startTextBox
            // 
            this.startTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.startTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalTVBindingSource, "Start", true));
            this.startTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTextBox.ForeColor = System.Drawing.Color.Black;
            this.startTextBox.Location = new System.Drawing.Point(304, 159);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(484, 24);
            this.startTextBox.TabIndex = 9;
            this.startTextBox.TextChanged += new System.EventHandler(this.startTextBox_TextChanged);
            // 
            // endTextBox
            // 
            this.endTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.endTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalTVBindingSource, "End", true));
            this.endTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTextBox.ForeColor = System.Drawing.Color.Black;
            this.endTextBox.Location = new System.Drawing.Point(304, 189);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(484, 24);
            this.endTextBox.TabIndex = 11;
            this.endTextBox.TextChanged += new System.EventHandler(this.endTextBox_TextChanged);
            // 
            // workerComboBox
            // 
            this.workerComboBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.workerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalTVBindingSource, "Worker", true));
            this.workerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workerComboBox.ForeColor = System.Drawing.Color.Black;
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Items.AddRange(new object[] {
            "გუგა",
            "ვაგო",
            "გიორგი",
            "გიო ",
            "სხვა"});
            this.workerComboBox.Location = new System.Drawing.Point(304, 221);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(484, 26);
            this.workerComboBox.TabIndex = 13;
            this.workerComboBox.SelectedIndexChanged += new System.EventHandler(this.workerComboBox_SelectedIndexChanged);
            // 
            // comments_P_S_TextBox
            // 
            this.comments_P_S_TextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.comments_P_S_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalTVBindingSource, "Comments(P_S)", true));
            this.comments_P_S_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comments_P_S_TextBox.ForeColor = System.Drawing.Color.Black;
            this.comments_P_S_TextBox.Location = new System.Drawing.Point(304, 253);
            this.comments_P_S_TextBox.Name = "comments_P_S_TextBox";
            this.comments_P_S_TextBox.Size = new System.Drawing.Size(484, 24);
            this.comments_P_S_TextBox.TabIndex = 15;
            this.comments_P_S_TextBox.TextChanged += new System.EventHandler(this.comments_P_S_TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(457, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Global TV\'S ჩანაწერები";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalTVBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(304, 135);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(484, 20);
            this.dateTextBox.TabIndex = 17;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(154, 47);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(28, 13);
            idLabel.TabIndex = 17;
            idLabel.Text = "N(#)";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.globalTVBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(304, 39);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(147, 20);
            this.idTextBox.TabIndex = 18;
            // 
            // globalTVBindingSource
            // 
            this.globalTVBindingSource.DataMember = "GlobalTV";
            this.globalTVBindingSource.DataSource = this.dbMarjDataSet;
            // 
            // dbMarjDataSet
            // 
            this.dbMarjDataSet.DataSetName = "DbMarjDataSet";
            this.dbMarjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workDataGridViewTextBoxColumn
            // 
            this.workDataGridViewTextBoxColumn.DataPropertyName = "Work";
            this.workDataGridViewTextBoxColumn.HeaderText = "Work";
            this.workDataGridViewTextBoxColumn.Name = "workDataGridViewTextBoxColumn";
            this.workDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // channelDataGridViewTextBoxColumn
            // 
            this.channelDataGridViewTextBoxColumn.DataPropertyName = "Channel";
            this.channelDataGridViewTextBoxColumn.HeaderText = "Channel";
            this.channelDataGridViewTextBoxColumn.Name = "channelDataGridViewTextBoxColumn";
            this.channelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "End";
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workerDataGridViewTextBoxColumn
            // 
            this.workerDataGridViewTextBoxColumn.DataPropertyName = "Worker";
            this.workerDataGridViewTextBoxColumn.HeaderText = "Worker";
            this.workerDataGridViewTextBoxColumn.Name = "workerDataGridViewTextBoxColumn";
            this.workerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsPSDataGridViewTextBoxColumn
            // 
            this.commentsPSDataGridViewTextBoxColumn.DataPropertyName = "Comments(P_S)";
            this.commentsPSDataGridViewTextBoxColumn.HeaderText = "Comments(P_S)";
            this.commentsPSDataGridViewTextBoxColumn.Name = "commentsPSDataGridViewTextBoxColumn";
            this.commentsPSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // globalTVTableAdapter
            // 
            this.globalTVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GlobalTVTableAdapter = this.globalTVTableAdapter;
            this.tableAdapterManager.UpdateOrder = GlobalTV.DbMarjDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1004, 506);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(comments_P_S_Label);
            this.Controls.Add(this.comments_P_S_TextBox);
            this.Controls.Add(workerLabel);
            this.Controls.Add(this.workerComboBox);
            this.Controls.Add(endLabel);
            this.Controls.Add(this.endTextBox);
            this.Controls.Add(startLabel);
            this.Controls.Add(this.startTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(channelLabel);
            this.Controls.Add(this.channelComboBox);
            this.Controls.Add(workLabel);
            this.Controls.Add(this.workTextBox);
            this.Controls.Add(this.globalTVDataGridView);
            this.Controls.Add(this.globalTVBindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1020, 545);
            this.MinimumSize = new System.Drawing.Size(821, 486);
            this.Name = "Form1";
            this.Text = "Global Tv მორიგის ჩანაწერები";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.globalTVBindingNavigator)).EndInit();
            this.globalTVBindingNavigator.ResumeLayout(false);
            this.globalTVBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalTVDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalTVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMarjDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbMarjDataSet dbMarjDataSet;
        private System.Windows.Forms.BindingSource globalTVBindingSource;
        private DbMarjDataSetTableAdapters.GlobalTVTableAdapter globalTVTableAdapter;
        private DbMarjDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator globalTVBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton globalTVBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView globalTVDataGridView;
        private System.Windows.Forms.TextBox workTextBox;
        private System.Windows.Forms.ComboBox channelComboBox;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.ComboBox workerComboBox;
        private System.Windows.Forms.TextBox comments_P_S_TextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn channelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}

