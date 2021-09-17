namespace GalleryApp
{
    partial class SalaDeEspera
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaDeEspera));
            this.lvListaContenido = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvListaContenido
            // 
            this.lvListaContenido.AllowDrop = true;
            this.lvListaContenido.Location = new System.Drawing.Point(12, 43);
            this.lvListaContenido.Name = "lvListaContenido";
            this.lvListaContenido.ShowItemToolTips = true;
            this.lvListaContenido.Size = new System.Drawing.Size(745, 514);
            this.lvListaContenido.TabIndex = 0;
            this.lvListaContenido.UseCompatibleStateImageBehavior = false;
            this.lvListaContenido.View = System.Windows.Forms.View.List;
            this.lvListaContenido.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvListaContenido_DragDrop);
            this.lvListaContenido.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvListaContenido_DragEnter);
            // 
            // SalaDeEspera
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 569);
            this.Controls.Add(this.lvListaContenido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalaDeEspera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala de Espera";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SalaDeEspera_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvListaContenido;
    }
}

