namespace Actividad04.NET
{
    partial class frmActividad04
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnAddUsser = new System.Windows.Forms.ToolStripButton();
            this.btnSearchUsser = new System.Windows.Forms.ToolStripButton();
            this.btnEditUsser = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteUsser = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.btnExitApp = new System.Windows.Forms.ToolStripButton();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpNotas = new System.Windows.Forms.GroupBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvTablaDtos = new System.Windows.Forms.DataGridView();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpNotas.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTablaDtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFile,
            this.btnAddUsser,
            this.btnSearchUsser,
            this.btnEditUsser,
            this.btnDeleteUsser,
            this.btnSaveFile,
            this.btnExitApp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(705, 96);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFile.Image = global::Actividad04.NET.Properties.Resources.openFile;
            this.btnOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Padding = new System.Windows.Forms.Padding(3);
            this.btnOpenFile.Size = new System.Drawing.Size(90, 90);
            this.btnOpenFile.Text = "toolStripButton1";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnAddUsser
            // 
            this.btnAddUsser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddUsser.Image = global::Actividad04.NET.Properties.Resources.addUser;
            this.btnAddUsser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddUsser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddUsser.Margin = new System.Windows.Forms.Padding(3);
            this.btnAddUsser.Name = "btnAddUsser";
            this.btnAddUsser.Padding = new System.Windows.Forms.Padding(3);
            this.btnAddUsser.Size = new System.Drawing.Size(90, 90);
            this.btnAddUsser.Text = "toolStripButton2";
            this.btnAddUsser.Click += new System.EventHandler(this.btnAddUsser_Click);
            // 
            // btnSearchUsser
            // 
            this.btnSearchUsser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearchUsser.Image = global::Actividad04.NET.Properties.Resources.SearchUser;
            this.btnSearchUsser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearchUsser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchUsser.Margin = new System.Windows.Forms.Padding(3);
            this.btnSearchUsser.Name = "btnSearchUsser";
            this.btnSearchUsser.Padding = new System.Windows.Forms.Padding(3);
            this.btnSearchUsser.Size = new System.Drawing.Size(90, 90);
            this.btnSearchUsser.Text = "toolStripButton3";
            this.btnSearchUsser.Click += new System.EventHandler(this.btnSearchUsser_Click);
            // 
            // btnEditUsser
            // 
            this.btnEditUsser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditUsser.Image = global::Actividad04.NET.Properties.Resources.edidUser;
            this.btnEditUsser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditUsser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditUsser.Margin = new System.Windows.Forms.Padding(3);
            this.btnEditUsser.Name = "btnEditUsser";
            this.btnEditUsser.Padding = new System.Windows.Forms.Padding(3);
            this.btnEditUsser.Size = new System.Drawing.Size(90, 90);
            this.btnEditUsser.Text = "toolStripButton4";
            this.btnEditUsser.Click += new System.EventHandler(this.btnEditUsser_Click);
            // 
            // btnDeleteUsser
            // 
            this.btnDeleteUsser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteUsser.Image = global::Actividad04.NET.Properties.Resources.deleteUser;
            this.btnDeleteUsser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteUsser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteUsser.Margin = new System.Windows.Forms.Padding(3);
            this.btnDeleteUsser.Name = "btnDeleteUsser";
            this.btnDeleteUsser.Padding = new System.Windows.Forms.Padding(3);
            this.btnDeleteUsser.Size = new System.Drawing.Size(90, 90);
            this.btnDeleteUsser.Text = "toolStripButton5";
            this.btnDeleteUsser.Click += new System.EventHandler(this.btnDeleteUsser_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveFile.Image = global::Actividad04.NET.Properties.Resources.saveFile;
            this.btnSaveFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(3);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Padding = new System.Windows.Forms.Padding(3);
            this.btnSaveFile.Size = new System.Drawing.Size(90, 90);
            this.btnSaveFile.Text = "toolStripButton6";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExitApp.Image = global::Actividad04.NET.Properties.Resources.exitApp;
            this.btnExitApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExitApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(3);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Padding = new System.Windows.Forms.Padding(3);
            this.btnExitApp.Size = new System.Drawing.Size(90, 90);
            this.btnExitApp.Text = "toolStripButton7";
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.panel2);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 96);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(705, 260);
            this.pnlDatos.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpNotas);
            this.panel2.Controls.Add(this.grpDatos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 234);
            this.panel2.TabIndex = 14;
            // 
            // grpNotas
            // 
            this.grpNotas.Controls.Add(this.txtNota4);
            this.grpNotas.Controls.Add(this.label7);
            this.grpNotas.Controls.Add(this.txtNota3);
            this.grpNotas.Controls.Add(this.label6);
            this.grpNotas.Controls.Add(this.txtNota2);
            this.grpNotas.Controls.Add(this.label4);
            this.grpNotas.Controls.Add(this.txtNota1);
            this.grpNotas.Controls.Add(this.label3);
            this.grpNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNotas.Location = new System.Drawing.Point(491, 0);
            this.grpNotas.Name = "grpNotas";
            this.grpNotas.Size = new System.Drawing.Size(214, 234);
            this.grpNotas.TabIndex = 14;
            this.grpNotas.TabStop = false;
            this.grpNotas.Text = "Notas";
            // 
            // txtNota4
            // 
            this.txtNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota4.Location = new System.Drawing.Point(91, 161);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 26);
            this.txtNota4.TabIndex = 7;
            this.txtNota4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nota 4";
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(91, 125);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 26);
            this.txtNota3.TabIndex = 5;
            this.txtNota3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nota 3";
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(91, 89);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 26);
            this.txtNota2.TabIndex = 3;
            this.txtNota2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nota 2";
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(91, 53);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 26);
            this.txtNota1.TabIndex = 1;
            this.txtNota1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nota 1";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtCorreo);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.txtCodigo);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(0, 0);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(491, 234);
            this.grpDatos.TabIndex = 13;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos Estudiante";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(86, 158);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(373, 26);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.Click += new System.EventHandler(this.txtCorreo_Click);
            this.txtCorreo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCorreo_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(86, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(373, 26);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TabStop = false;
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNombre_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(293, 60);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(166, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Click += new System.EventHandler(this.txtCodigo_Click);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCodigo_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvTablaDtos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 356);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(7);
            this.panel3.Size = new System.Drawing.Size(705, 275);
            this.panel3.TabIndex = 2;
            // 
            // dtgvTablaDtos
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTablaDtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvTablaDtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTablaDtos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvTablaDtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTablaDtos.Location = new System.Drawing.Point(7, 7);
            this.dtgvTablaDtos.Name = "dtgvTablaDtos";
            this.dtgvTablaDtos.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTablaDtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvTablaDtos.RowHeadersVisible = false;
            this.dtgvTablaDtos.RowTemplate.DividerHeight = 1;
            this.dtgvTablaDtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTablaDtos.Size = new System.Drawing.Size(691, 261);
            this.dtgvTablaDtos.TabIndex = 0;
            this.dtgvTablaDtos.TabStop = false;
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmActividad04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmActividad04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista de diseño";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grpNotas.ResumeLayout(false);
            this.grpNotas.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTablaDtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.ToolStripButton btnAddUsser;
        private System.Windows.Forms.ToolStripButton btnSearchUsser;
        private System.Windows.Forms.ToolStripButton btnEditUsser;
        private System.Windows.Forms.ToolStripButton btnDeleteUsser;
        private System.Windows.Forms.ToolStripButton btnSaveFile;
        private System.Windows.Forms.ToolStripButton btnExitApp;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpNotas;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvTablaDtos;
        private System.Windows.Forms.ErrorProvider errorValidacion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

