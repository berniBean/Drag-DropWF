using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop
{
    public partial class Form1 : Form
    {
        BindingListPDF obBinding;

        List<Pdfs> itemPdf = new List<Pdfs>();
        public Form1()
        {
            InitializeComponent();
        }

        private void DropFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void DropFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            
            DirectoryInfo di = new DirectoryInfo(string.Join(" ", archivos));

            foreach(var fi in di.GetFiles())
            {
                Pdfs item = new Pdfs(fi.Name);

                itemPdf.Add(item);
            }

            DropFiles.DataSource = itemPdf.ToString();
            
        }
    }
}
