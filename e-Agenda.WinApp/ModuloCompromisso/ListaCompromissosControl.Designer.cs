namespace e_Agenda.WinApp.Compartilhado
{
    partial class ListaCompromissosControl
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
            this.listCompromissos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listCompromissos
            // 
            this.listCompromissos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCompromissos.FormattingEnabled = true;
            this.listCompromissos.ItemHeight = 15;
            this.listCompromissos.Location = new System.Drawing.Point(0, 0);
            this.listCompromissos.Name = "listCompromissos";
            this.listCompromissos.Size = new System.Drawing.Size(656, 444);
            this.listCompromissos.TabIndex = 1;
            // 
            // ListaCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listCompromissos);
            this.Name = "ListaCompromissos";
            this.Size = new System.Drawing.Size(656, 444);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listCompromissos;
    }
}
