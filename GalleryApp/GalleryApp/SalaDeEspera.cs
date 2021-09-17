using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GalleryApp
{
    public partial class SalaDeEspera : Form
    {
        public SalaDeEspera()
        {
            InitializeComponent();
        }

        private void lvListaContenido_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
        }

        private void SalaDeEspera_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
            {
                String[] strGetFormats = e.Data.GetFormats();
                e.Effect = DragDropEffects.None;
            }
        }

        private void lvListaContenido_DragDrop(object sender, DragEventArgs e)
        {
            List<string> filepaths = new List<string>();
            var listaContenido = sender as ListView;

            foreach (var s in (string[])e.Data.GetData(DataFormats.FileDrop, false))
            {
                if (Directory.Exists(s))
                {
                    filepaths.AddRange(Directory.GetFiles(s));
                    //listaContenido.Items.Add(Directory.GetFiles(s));
                }
                else
                {
                    filepaths.Add(s);
                    listaContenido.Items.Add(s);
                }
            }
        }
    }
}
