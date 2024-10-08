namespace PromotoresApp
{
    partial class FrmDocumentacioncs
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
            Guardar = new Button();
            lblDoc = new Label();
            txtDoc = new TextBox();
            SuspendLayout();
            // 
            // Guardar
            // 
            Guardar.Location = new Point(316, 329);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(166, 34);
            Guardar.TabIndex = 0;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(71, 108);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(137, 25);
            lblDoc.TabIndex = 1;
            lblDoc.Text = "Documentacion";
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(266, 105);
            txtDoc.Multiline = true;
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(246, 113);
            txtDoc.TabIndex = 2;
            // 
            // FrmDocumentacioncs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDoc);
            Controls.Add(lblDoc);
            Controls.Add(Guardar);
            Name = "FrmDocumentacioncs";
            Text = "FrmDocumentacioncs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Guardar;
        private Label lblDoc;
        private TextBox txtDoc;
    }
}