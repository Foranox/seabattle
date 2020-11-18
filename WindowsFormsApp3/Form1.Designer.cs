namespace SeaBattle
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.A2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipIsHorisontal = new System.Windows.Forms.RadioButton();
            this.ShipIsVertical = new System.Windows.Forms.RadioButton();
            this.Btn1cells = new System.Windows.Forms.RadioButton();
            this.Btn2cells = new System.Windows.Forms.RadioButton();
            this.Btn3cells = new System.Windows.Forms.RadioButton();
            this.Btn4cells = new System.Windows.Forms.RadioButton();
            this.ships1 = new System.Windows.Forms.Label();
            this.ships2 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.ships4 = new System.Windows.Forms.Label();
            this.ships3 = new System.Windows.Forms.Label();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.EndText = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E,
            this.F,
            this.G,
            this.H,
            this.I,
            this.J});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(150, 87);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(269, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // A
            // 
            this.A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.A.FillWeight = 25F;
            this.A.Frozen = true;
            this.A.HeaderText = "A";
            this.A.MinimumWidth = 25;
            this.A.Name = "A";
            this.A.ReadOnly = true;
            this.A.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.A.Width = 25;
            // 
            // B
            // 
            this.B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.B.FillWeight = 25F;
            this.B.Frozen = true;
            this.B.HeaderText = "B";
            this.B.MinimumWidth = 25;
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B.Width = 25;
            // 
            // C
            // 
            this.C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.C.FillWeight = 25F;
            this.C.Frozen = true;
            this.C.HeaderText = "C";
            this.C.MinimumWidth = 25;
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.C.Width = 25;
            // 
            // D
            // 
            this.D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.D.FillWeight = 25F;
            this.D.Frozen = true;
            this.D.HeaderText = "D";
            this.D.MinimumWidth = 25;
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.D.Width = 25;
            // 
            // E
            // 
            this.E.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.E.FillWeight = 25F;
            this.E.Frozen = true;
            this.E.HeaderText = "E";
            this.E.MinimumWidth = 25;
            this.E.Name = "E";
            this.E.ReadOnly = true;
            this.E.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.E.Width = 25;
            // 
            // F
            // 
            this.F.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.F.FillWeight = 25F;
            this.F.Frozen = true;
            this.F.HeaderText = "F";
            this.F.MinimumWidth = 25;
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.F.Width = 25;
            // 
            // G
            // 
            this.G.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.G.FillWeight = 25F;
            this.G.Frozen = true;
            this.G.HeaderText = "G";
            this.G.MinimumWidth = 25;
            this.G.Name = "G";
            this.G.ReadOnly = true;
            this.G.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.G.Width = 25;
            // 
            // H
            // 
            this.H.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.H.FillWeight = 25F;
            this.H.Frozen = true;
            this.H.HeaderText = "H";
            this.H.MinimumWidth = 25;
            this.H.Name = "H";
            this.H.ReadOnly = true;
            this.H.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.H.Width = 25;
            // 
            // I
            // 
            this.I.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.I.FillWeight = 25F;
            this.I.Frozen = true;
            this.I.HeaderText = "I";
            this.I.MinimumWidth = 25;
            this.I.Name = "I";
            this.I.ReadOnly = true;
            this.I.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.I.Width = 25;
            // 
            // J
            // 
            this.J.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.J.FillWeight = 25F;
            this.J.Frozen = true;
            this.J.HeaderText = "J";
            this.J.MinimumWidth = 25;
            this.J.Name = "J";
            this.J.ReadOnly = true;
            this.J.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.J.Width = 25;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A2,
            this.B2,
            this.C2,
            this.D2,
            this.E2,
            this.F2,
            this.G2,
            this.H2,
            this.I2,
            this.J2});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView2.Location = new System.Drawing.Point(657, 87);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.Size = new System.Drawing.Size(272, 261);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // A2
            // 
            this.A2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.A2.FillWeight = 25F;
            this.A2.Frozen = true;
            this.A2.HeaderText = "A";
            this.A2.MinimumWidth = 25;
            this.A2.Name = "A2";
            this.A2.ReadOnly = true;
            this.A2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.A2.Width = 25;
            // 
            // B2
            // 
            this.B2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.B2.FillWeight = 25F;
            this.B2.Frozen = true;
            this.B2.HeaderText = "B";
            this.B2.MinimumWidth = 25;
            this.B2.Name = "B2";
            this.B2.ReadOnly = true;
            this.B2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B2.Width = 25;
            // 
            // C2
            // 
            this.C2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.C2.FillWeight = 25F;
            this.C2.Frozen = true;
            this.C2.HeaderText = "C";
            this.C2.MinimumWidth = 25;
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.C2.Width = 25;
            // 
            // D2
            // 
            this.D2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.D2.FillWeight = 25F;
            this.D2.Frozen = true;
            this.D2.HeaderText = "D";
            this.D2.MinimumWidth = 25;
            this.D2.Name = "D2";
            this.D2.ReadOnly = true;
            this.D2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.D2.Width = 25;
            // 
            // E2
            // 
            this.E2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.E2.FillWeight = 25F;
            this.E2.Frozen = true;
            this.E2.HeaderText = "E";
            this.E2.MinimumWidth = 25;
            this.E2.Name = "E2";
            this.E2.ReadOnly = true;
            this.E2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.E2.Width = 25;
            // 
            // F2
            // 
            this.F2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.F2.FillWeight = 25F;
            this.F2.Frozen = true;
            this.F2.HeaderText = "F";
            this.F2.MinimumWidth = 25;
            this.F2.Name = "F2";
            this.F2.ReadOnly = true;
            this.F2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.F2.Width = 25;
            // 
            // G2
            // 
            this.G2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.G2.FillWeight = 25F;
            this.G2.Frozen = true;
            this.G2.HeaderText = "G";
            this.G2.MinimumWidth = 25;
            this.G2.Name = "G2";
            this.G2.ReadOnly = true;
            this.G2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.G2.Width = 25;
            // 
            // H2
            // 
            this.H2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.H2.FillWeight = 25F;
            this.H2.Frozen = true;
            this.H2.HeaderText = "H";
            this.H2.MinimumWidth = 25;
            this.H2.Name = "H2";
            this.H2.ReadOnly = true;
            this.H2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.H2.Width = 25;
            // 
            // I2
            // 
            this.I2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.I2.FillWeight = 25F;
            this.I2.Frozen = true;
            this.I2.HeaderText = "I";
            this.I2.MinimumWidth = 25;
            this.I2.Name = "I2";
            this.I2.ReadOnly = true;
            this.I2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.I2.Width = 25;
            // 
            // J2
            // 
            this.J2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.J2.FillWeight = 25F;
            this.J2.Frozen = true;
            this.J2.HeaderText = "J";
            this.J2.MinimumWidth = 25;
            this.J2.Name = "J2";
            this.J2.ReadOnly = true;
            this.J2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.J2.Width = 25;
            // 
            // ShipIsHorisontal
            // 
            this.ShipIsHorisontal.AutoSize = true;
            this.ShipIsHorisontal.Location = new System.Drawing.Point(450, 238);
            this.ShipIsHorisontal.Name = "ShipIsHorisontal";
            this.ShipIsHorisontal.Size = new System.Drawing.Size(102, 17);
            this.ShipIsHorisontal.TabIndex = 3;
            this.ShipIsHorisontal.TabStop = true;
            this.ShipIsHorisontal.Text = "Горизонтально";
            this.ShipIsHorisontal.UseVisualStyleBackColor = true;
            this.ShipIsHorisontal.CheckedChanged += new System.EventHandler(this.ShipIsHorisontal_CheckedChanged);
            // 
            // ShipIsVertical
            // 
            this.ShipIsVertical.AutoSize = true;
            this.ShipIsVertical.Location = new System.Drawing.Point(450, 261);
            this.ShipIsVertical.Name = "ShipIsVertical";
            this.ShipIsVertical.Size = new System.Drawing.Size(91, 17);
            this.ShipIsVertical.TabIndex = 4;
            this.ShipIsVertical.TabStop = true;
            this.ShipIsVertical.Text = "Вертикально";
            this.ShipIsVertical.UseVisualStyleBackColor = true;
            this.ShipIsVertical.CheckedChanged += new System.EventHandler(this.ShipIsVertical_CheckedChanged);
            // 
            // Btn1cells
            // 
            this.Btn1cells.AutoSize = true;
            this.Btn1cells.Location = new System.Drawing.Point(17, 19);
            this.Btn1cells.Name = "Btn1cells";
            this.Btn1cells.Size = new System.Drawing.Size(126, 17);
            this.Btn1cells.TabIndex = 6;
            this.Btn1cells.TabStop = true;
            this.Btn1cells.Text = "Палуб: 1. Осталось:";
            this.Btn1cells.UseVisualStyleBackColor = true;
            this.Btn1cells.CheckedChanged += new System.EventHandler(this.Btn1cells_CheckedChanged);
            // 
            // Btn2cells
            // 
            this.Btn2cells.AutoSize = true;
            this.Btn2cells.Location = new System.Drawing.Point(17, 42);
            this.Btn2cells.Name = "Btn2cells";
            this.Btn2cells.Size = new System.Drawing.Size(126, 17);
            this.Btn2cells.TabIndex = 7;
            this.Btn2cells.TabStop = true;
            this.Btn2cells.Text = "Палуб: 2. Осталось:";
            this.Btn2cells.UseVisualStyleBackColor = true;
            this.Btn2cells.CheckedChanged += new System.EventHandler(this.Btn2cells_CheckedChanged);
            // 
            // Btn3cells
            // 
            this.Btn3cells.AutoSize = true;
            this.Btn3cells.Location = new System.Drawing.Point(17, 65);
            this.Btn3cells.Name = "Btn3cells";
            this.Btn3cells.Size = new System.Drawing.Size(126, 17);
            this.Btn3cells.TabIndex = 8;
            this.Btn3cells.TabStop = true;
            this.Btn3cells.Text = "Палуб: 3. Осталось:";
            this.Btn3cells.UseVisualStyleBackColor = true;
            this.Btn3cells.CheckedChanged += new System.EventHandler(this.Btn3cells_CheckedChanged);
            // 
            // Btn4cells
            // 
            this.Btn4cells.AutoSize = true;
            this.Btn4cells.Location = new System.Drawing.Point(17, 88);
            this.Btn4cells.Name = "Btn4cells";
            this.Btn4cells.Size = new System.Drawing.Size(126, 17);
            this.Btn4cells.TabIndex = 9;
            this.Btn4cells.TabStop = true;
            this.Btn4cells.Text = "Палуб: 4. Осталось:";
            this.Btn4cells.UseVisualStyleBackColor = true;
            this.Btn4cells.CheckedChanged += new System.EventHandler(this.Btn4cells_CheckedChanged);
            // 
            // ships1
            // 
            this.ships1.AutoSize = true;
            this.ships1.Location = new System.Drawing.Point(140, 21);
            this.ships1.Name = "ships1";
            this.ships1.Size = new System.Drawing.Size(13, 13);
            this.ships1.TabIndex = 6;
            this.ships1.Text = "4";
            // 
            // ships2
            // 
            this.ships2.AutoSize = true;
            this.ships2.Location = new System.Drawing.Point(140, 44);
            this.ships2.Name = "ships2";
            this.ships2.Size = new System.Drawing.Size(13, 13);
            this.ships2.TabIndex = 10;
            this.ships2.Text = "3";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.ships4);
            this.GroupBox.Controls.Add(this.ships3);
            this.GroupBox.Controls.Add(this.ships2);
            this.GroupBox.Controls.Add(this.ships1);
            this.GroupBox.Controls.Add(this.Btn4cells);
            this.GroupBox.Controls.Add(this.Btn3cells);
            this.GroupBox.Controls.Add(this.Btn2cells);
            this.GroupBox.Controls.Add(this.Btn1cells);
            this.GroupBox.Location = new System.Drawing.Point(450, 109);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(237, 114);
            this.GroupBox.TabIndex = 5;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Выберите количество палуб";
            // 
            // ships4
            // 
            this.ships4.AutoSize = true;
            this.ships4.Location = new System.Drawing.Point(140, 90);
            this.ships4.Name = "ships4";
            this.ships4.Size = new System.Drawing.Size(13, 13);
            this.ships4.TabIndex = 12;
            this.ships4.Text = "1";
            // 
            // ships3
            // 
            this.ships3.AutoSize = true;
            this.ships3.Location = new System.Drawing.Point(140, 67);
            this.ships3.Name = "ships3";
            this.ships3.Size = new System.Drawing.Size(13, 13);
            this.ships3.TabIndex = 11;
            this.ships3.Text = "2";
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Location = new System.Drawing.Point(467, 248);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(126, 41);
            this.BtnNewGame.TabIndex = 6;
            this.BtnNewGame.Text = "Новая Игра";
            this.BtnNewGame.UseVisualStyleBackColor = true;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // EndText
            // 
            this.EndText.AutoSize = true;
            this.EndText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndText.Location = new System.Drawing.Point(416, 201);
            this.EndText.Name = "EndText";
            this.EndText.Size = new System.Drawing.Size(235, 24);
            this.EndText.TabIndex = 7;
            this.EndText.Text = "Поздравляем с победой!";
            this.EndText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(450, 295);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(114, 23);
            this.BtnClean.TabIndex = 8;
            this.BtnClean.Text = "Очистить всё";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 506);
            this.Controls.Add(this.EndText);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.ShipIsVertical);
            this.Controls.Add(this.ShipIsHorisontal);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Морской бой";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn I;
        private System.Windows.Forms.DataGridViewTextBoxColumn J;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn A2;
        private System.Windows.Forms.DataGridViewTextBoxColumn B2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D2;
        private System.Windows.Forms.DataGridViewTextBoxColumn E2;
        private System.Windows.Forms.DataGridViewTextBoxColumn F2;
        private System.Windows.Forms.DataGridViewTextBoxColumn G2;
        private System.Windows.Forms.DataGridViewTextBoxColumn H2;
        private System.Windows.Forms.DataGridViewTextBoxColumn I2;
        private System.Windows.Forms.DataGridViewTextBoxColumn J2;
        private System.Windows.Forms.RadioButton ShipIsHorisontal;
        private System.Windows.Forms.RadioButton ShipIsVertical;
        private System.Windows.Forms.RadioButton Btn1cells;
        private System.Windows.Forms.RadioButton Btn2cells;
        private System.Windows.Forms.RadioButton Btn3cells;
        private System.Windows.Forms.RadioButton Btn4cells;
        private System.Windows.Forms.Label ships1;
        private System.Windows.Forms.Label ships2;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label ships4;
        private System.Windows.Forms.Label ships3;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Label EndText;
        private System.Windows.Forms.Button BtnClean;
    }
}

