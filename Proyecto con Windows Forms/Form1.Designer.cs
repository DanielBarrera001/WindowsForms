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
            label1 = new Label();
            txt_Edad = new TextBox();
            btn_Confirm = new Button();
            lblConfirm = new Label();
            btn_Editar = new Button();
            lblName = new Label();
            SuspendLayout();
            // 
            // Btn_OK
            // 
            Btn_OK.Location = new Point(140, 374);
            Btn_OK.Name = "Btn_OK";
            Btn_OK.Size = new Size(75, 23);
            Btn_OK.TabIndex = 0;
            Btn_OK.Text = "Registrar datos";
            Btn_OK.UseVisualStyleBackColor = true;
            Btn_OK.Click += Btn_OK_Click;
            // 
            // Btn_Close
            // 
            Btn_Close.Location = new Point(221, 374);
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
            lbl_texto.Location = new Point(25, 252);
            lbl_texto.Name = "lbl_texto";
            lbl_texto.Size = new Size(12, 15);
            lbl_texto.TabIndex = 2;
            lbl_texto.Text = "-";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(25, 58);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 105);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Edad:";
            // 
            // txt_Edad
            // 
            txt_Edad.Location = new Point(25, 138);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(100, 23);
            txt_Edad.TabIndex = 5;
            // 
            // btn_Confirm
            // 
            btn_Confirm.Location = new Point(59, 374);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(75, 23);
            btn_Confirm.TabIndex = 6;
            btn_Confirm.Text = "Confirmar";
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(25, 279);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(0, 15);
            lblConfirm.TabIndex = 7;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(221, 330);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 38);
            btn_Editar.TabIndex = 8;
            btn_Editar.Text = "Editar datos";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += button1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Nombre:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 431);
            Controls.Add(lblName);
            Controls.Add(btn_Editar);
            Controls.Add(lblConfirm);
            Controls.Add(btn_Confirm);
            Controls.Add(txt_Edad);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox txt_Edad;
        private Button btn_Confirm;
        private Label lblConfirm;
        private Button btn_Editar;
        private Label lblName;
    }
}
