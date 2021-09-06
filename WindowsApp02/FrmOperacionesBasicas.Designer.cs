
namespace WindowsApp02
{
    partial class FrmOperacionesBasicas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.ResultadosListBox = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SalirButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DividirRadioButton = new System.Windows.Forms.RadioButton();
            this.MultiplicarRadioButton = new System.Windows.Forms.RadioButton();
            this.RestarRadioButton = new System.Windows.Forms.RadioButton();
            this.SumarRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(107, 16);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Numero1TextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero 2:";
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(107, 52);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Numero2TextBox.TabIndex = 1;
            // 
            // ResultadosListBox
            // 
            this.ResultadosListBox.FormattingEnabled = true;
            this.ResultadosListBox.Location = new System.Drawing.Point(26, 259);
            this.ResultadosListBox.Name = "ResultadosListBox";
            this.ResultadosListBox.Size = new System.Drawing.Size(230, 121);
            this.ResultadosListBox.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SalirButton
            // 
            this.SalirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalirButton.Image = global::WindowsApp02.Properties.Resources.shutdown_36px;
            this.SalirButton.Location = new System.Drawing.Point(205, 405);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(51, 44);
            this.SalirButton.TabIndex = 5;
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Image = global::WindowsApp02.Properties.Resources.save_24px;
            this.OKButton.Location = new System.Drawing.Point(26, 182);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(62, 54);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::WindowsApp02.Properties.Resources.cancel_24px;
            this.CancelarButton.Location = new System.Drawing.Point(194, 182);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(62, 54);
            this.CancelarButton.TabIndex = 4;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DividirRadioButton);
            this.groupBox1.Controls.Add(this.MultiplicarRadioButton);
            this.groupBox1.Controls.Add(this.RestarRadioButton);
            this.groupBox1.Controls.Add(this.SumarRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Operaciones ";
            // 
            // DividirRadioButton
            // 
            this.DividirRadioButton.AutoSize = true;
            this.DividirRadioButton.Location = new System.Drawing.Point(109, 43);
            this.DividirRadioButton.Name = "DividirRadioButton";
            this.DividirRadioButton.Size = new System.Drawing.Size(54, 17);
            this.DividirRadioButton.TabIndex = 0;
            this.DividirRadioButton.Text = "Dividir";
            this.DividirRadioButton.UseVisualStyleBackColor = true;
            this.DividirRadioButton.UseWaitCursor = true;
            // 
            // MultiplicarRadioButton
            // 
            this.MultiplicarRadioButton.AutoSize = true;
            this.MultiplicarRadioButton.Location = new System.Drawing.Point(109, 20);
            this.MultiplicarRadioButton.Name = "MultiplicarRadioButton";
            this.MultiplicarRadioButton.Size = new System.Drawing.Size(72, 17);
            this.MultiplicarRadioButton.TabIndex = 0;
            this.MultiplicarRadioButton.Text = "Multiplicar";
            this.MultiplicarRadioButton.UseVisualStyleBackColor = true;
            this.MultiplicarRadioButton.UseWaitCursor = true;
            // 
            // RestarRadioButton
            // 
            this.RestarRadioButton.AutoSize = true;
            this.RestarRadioButton.Location = new System.Drawing.Point(16, 43);
            this.RestarRadioButton.Name = "RestarRadioButton";
            this.RestarRadioButton.Size = new System.Drawing.Size(53, 17);
            this.RestarRadioButton.TabIndex = 0;
            this.RestarRadioButton.Text = "Resta";
            this.RestarRadioButton.UseVisualStyleBackColor = true;
            this.RestarRadioButton.UseWaitCursor = true;
            // 
            // SumarRadioButton
            // 
            this.SumarRadioButton.AutoSize = true;
            this.SumarRadioButton.Checked = true;
            this.SumarRadioButton.Location = new System.Drawing.Point(16, 20);
            this.SumarRadioButton.Name = "SumarRadioButton";
            this.SumarRadioButton.Size = new System.Drawing.Size(52, 17);
            this.SumarRadioButton.TabIndex = 0;
            this.SumarRadioButton.TabStop = true;
            this.SumarRadioButton.Text = "Suma";
            this.SumarRadioButton.UseVisualStyleBackColor = true;
            this.SumarRadioButton.UseWaitCursor = true;
            // 
            // FrmOperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResultadosListBox);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "FrmOperacionesBasicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones Básicas";
            this.Load += new System.EventHandler(this.FrmOperacionesBasicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.ListBox ResultadosListBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DividirRadioButton;
        private System.Windows.Forms.RadioButton MultiplicarRadioButton;
        private System.Windows.Forms.RadioButton RestarRadioButton;
        private System.Windows.Forms.RadioButton SumarRadioButton;
    }
}

