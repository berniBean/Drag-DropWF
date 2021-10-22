using DragDrop.Clases;
using Singleton;
using Strategy;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop
{
    public partial class Form1 : Form
    {
        private InfoFiles model = new CarpetasFiles(new Archivo(), new NombreArchivos());
        private BindingSource bs;

        

        public Form1()
        {
            InitializeComponent();
            bs = new BindingSource();
            
        }



        private void DropFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void DropFiles_DragDrop(object sender, DragEventArgs e)
        {


            model.dir = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            model.performDirection();
            if (model.performTypeFile() == "File")
                model.DataFileService = new NombreArchivo();
            else
                model.DataFileService = new NombreArchivos();



            bs.DataSource = model.performNameFiles();
            DropFiles.DataSource = bs;
            DropFiles.DisplayMember = "_name";
            bs.CurrencyManager.Refresh();

        }

    }
}
