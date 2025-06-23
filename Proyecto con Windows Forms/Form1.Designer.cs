namespace Proyecto_con_Windows_Forms
{
    partial class Form1
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
            Btn_OK = new Button();
            Btn_Close = new Button();
            lbl_texto = new Label();
            txt_Nombre = new TextBox();
            SuspendLayout();
            // 
            // Btn_OK
            // 
            Btn_OK.Location = new Point(140, 396);
            Btn_OK.Name = "Btn_OK";
            Btn_OK.Size = new Size(75, 23);
            Btn_OK.TabIndex = 0;
            Btn_OK.Text = "Ok";
            Btn_OK.UseVisualStyleBackColor = true;
            Btn_OK.Click += Btn_OK_Click;
            // 
            // Btn_Close
            // 
            Btn_Close.Location = new Point(221, 396);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(75, 23);
            Btn_Close.TabIndex = 1;
            Btn_Close.Text = "Close";
            Btn_Close.UseVisualStyleBackColor = true;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // lbl_texto
            // 
            lbl_texto.AutoSize = true;
            lbl_texto.Location = new Point(25, 30);
            lbl_texto.Name = "lbl_texto";
            lbl_texto.Size = new Size(66, 15);
            lbl_texto.TabIndex = 2;
            lbl_texto.Text = "Bienvenido";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(25, 58);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 431);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_texto);
            Controls.Add(Btn_Close);
            Controls.Add(Btn_OK);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_OK;
        private Button Btn_Close;
        private Label lbl_texto;
        private TextBox txt_Nombre;
    }
}
