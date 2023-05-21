namespace e_Agenda.WinApp.ModuloContato
{
    partial class ListaContatosControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listContatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listContatos
            // 
            this.listContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 15;
            this.listContatos.Location = new System.Drawing.Point(0, 0);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(510, 366);
            this.listContatos.TabIndex = 0;
            // 
            // ListaContatosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listContatos);
            this.Name = "ListaContatosControl";
            this.Size = new System.Drawing.Size(510, 366);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listContatos;
    }
}
