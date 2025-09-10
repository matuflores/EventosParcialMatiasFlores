namespace EventoParcial.Windows
{
    partial class FrmFiltro
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
            label1 = new Label();
            textBoxNombreSalon = new TextBox();
            button1 = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 83);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Salon:";
            // 
            // textBoxNombreSalon
            // 
            textBoxNombreSalon.Location = new Point(130, 80);
            textBoxNombreSalon.Name = "textBoxNombreSalon";
            textBoxNombreSalon.Size = new Size(327, 27);
            textBoxNombreSalon.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Aceptar1;
            button1.Location = new Point(75, 132);
            button1.Name = "button1";
            button1.Size = new Size(70, 60);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Image = Properties.Resources.Aceptar1;
            buttonCancel.Location = new Point(387, 132);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(70, 60);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "OK";
            buttonCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FrmFiltro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(button1);
            Controls.Add(textBoxNombreSalon);
            Controls.Add(label1);
            Name = "FrmFiltro";
            Text = "FrmFiltro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombreSalon;
        private Button button1;
        private Button buttonCancel;
    }
}