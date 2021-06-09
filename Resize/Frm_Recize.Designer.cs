
namespace Resize
{
    partial class Frm_Recize
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Btn_Selecionar = new System.Windows.Forms.Button();
            this.Lbl_FolderName = new System.Windows.Forms.Label();
            this.Btn_Destino = new System.Windows.Forms.Button();
            this.Lbl_Destination = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Cancell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(29, 18);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(269, 15);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Selecione a pasta onde as imagens estão situadas:";
            this.lbl_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Btn_Selecionar
            // 
            this.Btn_Selecionar.Location = new System.Drawing.Point(29, 78);
            this.Btn_Selecionar.Name = "Btn_Selecionar";
            this.Btn_Selecionar.Size = new System.Drawing.Size(114, 54);
            this.Btn_Selecionar.TabIndex = 1;
            this.Btn_Selecionar.Text = "Selecionar";
            this.Btn_Selecionar.UseVisualStyleBackColor = true;
            this.Btn_Selecionar.Click += new System.EventHandler(this.Btn_Selecionar_Click);
            // 
            // Lbl_FolderName
            // 
            this.Lbl_FolderName.AutoSize = true;
            this.Lbl_FolderName.Location = new System.Drawing.Point(185, 78);
            this.Lbl_FolderName.Name = "Lbl_FolderName";
            this.Lbl_FolderName.Size = new System.Drawing.Size(0, 15);
            this.Lbl_FolderName.TabIndex = 2;
            this.Lbl_FolderName.Tag = "Lbl_FolderName";
            // 
            // Btn_Destino
            // 
            this.Btn_Destino.Location = new System.Drawing.Point(25, 240);
            this.Btn_Destino.Name = "Btn_Destino";
            this.Btn_Destino.Size = new System.Drawing.Size(118, 58);
            this.Btn_Destino.TabIndex = 3;
            this.Btn_Destino.Text = "Destino";
            this.Btn_Destino.UseVisualStyleBackColor = true;
            this.Btn_Destino.Click += new System.EventHandler(this.Btn_Destino_Click);
            // 
            // Lbl_Destination
            // 
            this.Lbl_Destination.AutoSize = true;
            this.Lbl_Destination.Location = new System.Drawing.Point(185, 240);
            this.Lbl_Destination.Name = "Lbl_Destination";
            this.Lbl_Destination.Size = new System.Drawing.Size(0, 15);
            this.Lbl_Destination.TabIndex = 4;
            this.Lbl_Destination.Tag = "Lbl_Destination";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Submit.Location = new System.Drawing.Point(117, 390);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(107, 23);
            this.Btn_Submit.TabIndex = 5;
            this.Btn_Submit.Tag = "Btn_Submit";
            this.Btn_Submit.Text = "Redimensionar";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Cancell
            // 
            this.Btn_Cancell.Location = new System.Drawing.Point(278, 390);
            this.Btn_Cancell.Name = "Btn_Cancell";
            this.Btn_Cancell.Size = new System.Drawing.Size(96, 23);
            this.Btn_Cancell.TabIndex = 6;
            this.Btn_Cancell.Tag = "Btn_Cancell";
            this.Btn_Cancell.Text = "Cancelar";
            this.Btn_Cancell.UseVisualStyleBackColor = true;
            this.Btn_Cancell.Click += new System.EventHandler(this.Btn_Cancell_Click);
            // 
            // Frm_Recize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(476, 425);
            this.Controls.Add(this.Btn_Cancell);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Lbl_Destination);
            this.Controls.Add(this.Btn_Destino);
            this.Controls.Add(this.Lbl_FolderName);
            this.Controls.Add(this.Btn_Selecionar);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Frm_Recize";
            this.Text = "Resize";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Btn_Selecionar;
        private System.Windows.Forms.Label Lbl_FolderName;
        private System.Windows.Forms.Button Btn_Destino;
        private System.Windows.Forms.Label Lbl_Destination;
        private System.Windows.Forms.Button Btn_Cancell;
        private System.Windows.Forms.Button Btn_Submit;
    }
}

