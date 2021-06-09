using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Resize
{
    public partial class Frm_Recize : Form
    {
        private string folderDestination = "";
        private string folderOrigin = "";
        private IList<string> fileList = new List<string>();

        public Frm_Recize()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Selecionar_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    
                    var folderName = new DirectoryInfo(fbd.SelectedPath).Name;

                    folderOrigin = folderName;
                    
                    fileList = files.ToList();
                    
                    this.Lbl_FolderName.Text = $"Pasta selecionada: {folderName}.\nImagens encontradas: {fileList.Count}.";

                    var imagesSelected = fileList.Where(x => x.EndsWith(".png") || x.EndsWith(".jpg")).ToList();
                }
            }

        }

        private void Btn_Destino_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderDestination = new DirectoryInfo(fbd.SelectedPath).Name;

                    this.Lbl_Destination.Text = $"Pasta destino: {folderDestination}";
                }
            }
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (folderOrigin == folderDestination && !string.IsNullOrWhiteSpace(folderDestination) && !string.IsNullOrWhiteSpace(folderOrigin))
                MessageBox.Show("A pasta de Origem não pode ser a mesma do Destino", "Message");
            else
                MessageBox.Show("Redimensionando ...", "Message");
        }

        private void Btn_Cancell_Click(object sender, EventArgs e)
        {
            folderDestination = "";
            folderOrigin = "";
            fileList.Clear();

            this.Lbl_Destination.Text = "";
            this.Lbl_FolderName.Text = "";
        }
    }
}
