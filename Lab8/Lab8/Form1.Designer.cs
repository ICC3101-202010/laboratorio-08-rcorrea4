namespace Lab8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.buttonVer = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.panelAtributo = new System.Windows.Forms.Panel();
            this.labelNSalas = new System.Windows.Forms.Label();
            this.checkBoxEx = new System.Windows.Forms.CheckBox();
            this.textBoxNSalas = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.labelH = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxNd = new System.Windows.Forms.TextBox();
            this.labelND = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelRevisar = new System.Windows.Forms.Panel();
            this.buttonVerTodos = new System.Windows.Forms.Button();
            this.buttonAtras2 = new System.Windows.Forms.Button();
            this.buttonVerInfo = new System.Windows.Forms.Button();
            this.comboBoxLocales = new System.Windows.Forms.ComboBox();
            this.panelEntrada.SuspendLayout();
            this.panelAgregar.SuspendLayout();
            this.panelAtributo.SuspendLayout();
            this.panelRevisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "LocalsApp";
            // 
            // panelEntrada
            // 
            this.panelEntrada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEntrada.BackgroundImage")));
            this.panelEntrada.Controls.Add(this.buttonVer);
            this.panelEntrada.Controls.Add(this.buttonAgregar);
            this.panelEntrada.Location = new System.Drawing.Point(-5, 66);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Size = new System.Drawing.Size(599, 293);
            this.panelEntrada.TabIndex = 1;
            this.panelEntrada.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEntrada_Paint);
            // 
            // buttonVer
            // 
            this.buttonVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVer.Location = new System.Drawing.Point(343, 75);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(172, 112);
            this.buttonVer.TabIndex = 1;
            this.buttonVer.Text = "Revisar Informacion";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(81, 75);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(172, 112);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.Text = "Agregar Local";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // panelAgregar
            // 
            this.panelAgregar.Controls.Add(this.buttonAtras);
            this.panelAgregar.Controls.Add(this.buttonCrear);
            this.panelAgregar.Controls.Add(this.panelAtributo);
            this.panelAgregar.Controls.Add(this.textBoxH);
            this.panelAgregar.Controls.Add(this.labelH);
            this.panelAgregar.Controls.Add(this.textBoxId);
            this.panelAgregar.Controls.Add(this.labelId);
            this.panelAgregar.Controls.Add(this.textBoxNd);
            this.panelAgregar.Controls.Add(this.labelND);
            this.panelAgregar.Controls.Add(this.comboBox1);
            this.panelAgregar.Location = new System.Drawing.Point(15, 66);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(565, 277);
            this.panelAgregar.TabIndex = 2;
            this.panelAgregar.Visible = false;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(137, 221);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(67, 38);
            this.buttonAtras.TabIndex = 14;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(47, 221);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(67, 38);
            this.buttonCrear.TabIndex = 13;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // panelAtributo
            // 
            this.panelAtributo.Controls.Add(this.labelNSalas);
            this.panelAtributo.Controls.Add(this.checkBoxEx);
            this.panelAtributo.Controls.Add(this.textBoxNSalas);
            this.panelAtributo.Location = new System.Drawing.Point(254, 159);
            this.panelAtributo.Name = "panelAtributo";
            this.panelAtributo.Size = new System.Drawing.Size(200, 100);
            this.panelAtributo.TabIndex = 12;
            this.panelAtributo.Visible = false;
            // 
            // labelNSalas
            // 
            this.labelNSalas.AutoSize = true;
            this.labelNSalas.Location = new System.Drawing.Point(3, 17);
            this.labelNSalas.Name = "labelNSalas";
            this.labelNSalas.Size = new System.Drawing.Size(44, 13);
            this.labelNSalas.TabIndex = 9;
            this.labelNSalas.Text = "N Salas";
            // 
            // checkBoxEx
            // 
            this.checkBoxEx.AutoSize = true;
            this.checkBoxEx.Location = new System.Drawing.Point(100, 16);
            this.checkBoxEx.Name = "checkBoxEx";
            this.checkBoxEx.Size = new System.Drawing.Size(71, 17);
            this.checkBoxEx.TabIndex = 11;
            this.checkBoxEx.Text = "Exclusivo";
            this.checkBoxEx.UseVisualStyleBackColor = true;
            this.checkBoxEx.Visible = false;
            // 
            // textBoxNSalas
            // 
            this.textBoxNSalas.Location = new System.Drawing.Point(100, 14);
            this.textBoxNSalas.Name = "textBoxNSalas";
            this.textBoxNSalas.Size = new System.Drawing.Size(100, 20);
            this.textBoxNSalas.TabIndex = 8;
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(354, 123);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 20);
            this.textBoxH.TabIndex = 7;
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(260, 123);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(41, 13);
            this.labelH.TabIndex = 6;
            this.labelH.Text = "Horario";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(354, 89);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(260, 89);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id";
            // 
            // textBoxNd
            // 
            this.textBoxNd.Location = new System.Drawing.Point(354, 53);
            this.textBoxNd.Name = "textBoxNd";
            this.textBoxNd.Size = new System.Drawing.Size(100, 20);
            this.textBoxNd.TabIndex = 3;
            // 
            // labelND
            // 
            this.labelND.AutoSize = true;
            this.labelND.Location = new System.Drawing.Point(260, 56);
            this.labelND.Name = "labelND";
            this.labelND.Size = new System.Drawing.Size(79, 13);
            this.labelND.TabIndex = 2;
            this.labelND.Text = "Nombre Dueno";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cine",
            "Recreacional",
            "Restaurant",
            "Tienda"});
            this.comboBox1.Location = new System.Drawing.Point(47, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelRevisar
            // 
            this.panelRevisar.BackColor = System.Drawing.SystemColors.Control;
            this.panelRevisar.Controls.Add(this.buttonVerTodos);
            this.panelRevisar.Controls.Add(this.buttonAtras2);
            this.panelRevisar.Controls.Add(this.buttonVerInfo);
            this.panelRevisar.Controls.Add(this.comboBoxLocales);
            this.panelRevisar.Location = new System.Drawing.Point(12, 66);
            this.panelRevisar.Name = "panelRevisar";
            this.panelRevisar.Size = new System.Drawing.Size(568, 281);
            this.panelRevisar.TabIndex = 2;
            this.panelRevisar.Visible = false;
            // 
            // buttonVerTodos
            // 
            this.buttonVerTodos.Location = new System.Drawing.Point(367, 51);
            this.buttonVerTodos.Name = "buttonVerTodos";
            this.buttonVerTodos.Size = new System.Drawing.Size(119, 23);
            this.buttonVerTodos.TabIndex = 16;
            this.buttonVerTodos.Text = "Ver Todos";
            this.buttonVerTodos.UseVisualStyleBackColor = true;
            this.buttonVerTodos.Click += new System.EventHandler(this.buttonVerTodos_Click);
            // 
            // buttonAtras2
            // 
            this.buttonAtras2.Location = new System.Drawing.Point(64, 221);
            this.buttonAtras2.Name = "buttonAtras2";
            this.buttonAtras2.Size = new System.Drawing.Size(67, 38);
            this.buttonAtras2.TabIndex = 15;
            this.buttonAtras2.Text = "Atras";
            this.buttonAtras2.UseVisualStyleBackColor = true;
            this.buttonAtras2.Click += new System.EventHandler(this.buttonAtras2_Click);
            // 
            // buttonVerInfo
            // 
            this.buttonVerInfo.Location = new System.Drawing.Point(219, 50);
            this.buttonVerInfo.Name = "buttonVerInfo";
            this.buttonVerInfo.Size = new System.Drawing.Size(113, 23);
            this.buttonVerInfo.TabIndex = 1;
            this.buttonVerInfo.Text = "Ver";
            this.buttonVerInfo.UseVisualStyleBackColor = true;
            this.buttonVerInfo.Click += new System.EventHandler(this.buttonVerInfo_Click);
            // 
            // comboBoxLocales
            // 
            this.comboBoxLocales.FormattingEnabled = true;
            this.comboBoxLocales.Location = new System.Drawing.Point(64, 48);
            this.comboBoxLocales.Name = "comboBoxLocales";
            this.comboBoxLocales.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocales.TabIndex = 0;
            this.comboBoxLocales.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocales_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelEntrada);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.panelRevisar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelEntrada.ResumeLayout(false);
            this.panelAgregar.ResumeLayout(false);
            this.panelAgregar.PerformLayout();
            this.panelAtributo.ResumeLayout(false);
            this.panelAtributo.PerformLayout();
            this.panelRevisar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEntrada;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxNd;
        private System.Windows.Forms.Label labelND;
        private System.Windows.Forms.Label labelNSalas;
        private System.Windows.Forms.TextBox textBoxNSalas;
        private System.Windows.Forms.CheckBox checkBoxEx;
        private System.Windows.Forms.Panel panelAtributo;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Panel panelRevisar;
        private System.Windows.Forms.ComboBox comboBoxLocales;
        private System.Windows.Forms.Button buttonVerInfo;
        private System.Windows.Forms.Button buttonAtras2;
        private System.Windows.Forms.Button buttonVerTodos;
    }
}

