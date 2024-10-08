namespace PromotoresApp
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblAlta_Prospecto = new Label();
            btnAlta_Propecto = new Button();
            btnSalir = new Button();
            btndoc = new Button();
            lblAgr_Doc = new Label();
            SuspendLayout();
            // 
            // LblAlta_Prospecto
            // 
            LblAlta_Prospecto.AutoSize = true;
            LblAlta_Prospecto.Location = new Point(32, 49);
            LblAlta_Prospecto.Name = "LblAlta_Prospecto";
            LblAlta_Prospecto.Size = new Size(129, 25);
            LblAlta_Prospecto.TabIndex = 0;
            LblAlta_Prospecto.Text = "Alta prospecto";
            // 
            // btnAlta_Propecto
            // 
            btnAlta_Propecto.Location = new Point(32, 101);
            btnAlta_Propecto.Name = "btnAlta_Propecto";
            btnAlta_Propecto.Size = new Size(112, 69);
            btnAlta_Propecto.TabIndex = 1;
            btnAlta_Propecto.Text = "Alta";
            btnAlta_Propecto.UseVisualStyleBackColor = true;
            btnAlta_Propecto.Click += btnAlta_Propecto_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(648, 328);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 64);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btndoc
            // 
            btndoc.Location = new Point(263, 101);
            btndoc.Name = "btndoc";
            btndoc.Size = new Size(153, 69);
            btndoc.TabIndex = 3;
            btndoc.Text = "Documentacion";
            btndoc.UseVisualStyleBackColor = true;
            btndoc.Click += btndoc_Click;
            // 
            // lblAgr_Doc
            // 
            lblAgr_Doc.AutoSize = true;
            lblAgr_Doc.Location = new Point(263, 49);
            lblAgr_Doc.Name = "lblAgr_Doc";
            lblAgr_Doc.Size = new Size(206, 25);
            lblAgr_Doc.TabIndex = 4;
            lblAgr_Doc.Text = "Agregar Documentacion";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAgr_Doc);
            Controls.Add(btndoc);
            Controls.Add(btnSalir);
            Controls.Add(btnAlta_Propecto);
            Controls.Add(LblAlta_Prospecto);
            Name = "FrmMenu";
            Text = "Menu";
            Load += FrmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAlta_Prospecto;
        private Button btnAlta_Propecto;
        private Button btnSalir;
        private Button btndoc;
        private Label lblAgr_Doc;
    }
}
