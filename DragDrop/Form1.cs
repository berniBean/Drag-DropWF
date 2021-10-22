using DragDrop.Clases;
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
        private InfoFiles model = new CarpetasFiles(new Archivo(), new NombreArchivos(),new  NombreArchivo());
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
            
            

            bs.DataSource = model.performNameFiles();
            DropFiles.DataSource = bs;
            DropFiles.DisplayMember = "_name";
            bs.CurrencyManager.Refresh();

        }



        /*


                private BindingSource bs;
                private DirFiles files = new DirFiles();
                private DirectionService NameFiles = new DirectionService();
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

                    files.direccionArchivos((string[])e.Data.GetData(DataFormats.FileDrop, false));

                    NameFiles.GetFileName(files.archivos);

                    bs.DataSource = NameFiles.itemPdf;
                    DropFiles.DataSource = bs;
                    DropFiles.DisplayMember = "_name";
                    bs.CurrencyManager.Refresh();

                }*/
    }
}
