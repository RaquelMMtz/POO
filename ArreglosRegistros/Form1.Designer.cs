﻿namespace ArreglosRegistros
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreDelProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPrecioDelProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porExistenciaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLosProductosConExistenciaParToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMenorPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLaSumaYPromedioDelPrecioDeLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDatosToolStripMenuItem,
            this.mostrarDatosToolStripMenuItem,
            this.eliminarDatosToolStripMenuItem,
            this.modificarDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // agregarDatosToolStripMenuItem
            // 
            this.agregarDatosToolStripMenuItem.Name = "agregarDatosToolStripMenuItem";
            this.agregarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarDatosToolStripMenuItem.Text = "Agregar Datos";
            this.agregarDatosToolStripMenuItem.Click += new System.EventHandler(this.agregarDatosToolStripMenuItem_Click);
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosDatosToolStripMenuItem,
            this.porNombreDelProductoToolStripMenuItem,
            this.porPrecioDelProductosToolStripMenuItem,
            this.porExistenciaDeProductosToolStripMenuItem});
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarDatosToolStripMenuItem.Text = "Mostrar Datos...";
            // 
            // todosLosDatosToolStripMenuItem
            // 
            this.todosLosDatosToolStripMenuItem.Name = "todosLosDatosToolStripMenuItem";
            this.todosLosDatosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.todosLosDatosToolStripMenuItem.Text = "Todos los datos";
            this.todosLosDatosToolStripMenuItem.Click += new System.EventHandler(this.todosLosDatosToolStripMenuItem_Click);
            // 
            // porNombreDelProductoToolStripMenuItem
            // 
            this.porNombreDelProductoToolStripMenuItem.Name = "porNombreDelProductoToolStripMenuItem";
            this.porNombreDelProductoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.porNombreDelProductoToolStripMenuItem.Text = "Por nombre de productos";
            this.porNombreDelProductoToolStripMenuItem.Click += new System.EventHandler(this.porNombreDelProductoToolStripMenuItem_Click);
            // 
            // porPrecioDelProductosToolStripMenuItem
            // 
            this.porPrecioDelProductosToolStripMenuItem.Name = "porPrecioDelProductosToolStripMenuItem";
            this.porPrecioDelProductosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.porPrecioDelProductosToolStripMenuItem.Text = "Por precio del productos";
            this.porPrecioDelProductosToolStripMenuItem.Click += new System.EventHandler(this.porPrecioDelProductosToolStripMenuItem_Click);
            // 
            // porExistenciaDeProductosToolStripMenuItem
            // 
            this.porExistenciaDeProductosToolStripMenuItem.Name = "porExistenciaDeProductosToolStripMenuItem";
            this.porExistenciaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.porExistenciaDeProductosToolStripMenuItem.Text = "Por existencia de productos";
            this.porExistenciaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.porExistenciaDeProductosToolStripMenuItem_Click);
            // 
            // eliminarDatosToolStripMenuItem
            // 
            this.eliminarDatosToolStripMenuItem.Name = "eliminarDatosToolStripMenuItem";
            this.eliminarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarDatosToolStripMenuItem.Text = "Eliminar Datos";
            this.eliminarDatosToolStripMenuItem.Click += new System.EventHandler(this.eliminarDatosToolStripMenuItem_Click);
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarDatosToolStripMenuItem.Text = "Modificar Datos";
            this.modificarDatosToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(91, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 187);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre del Producto";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio del Producto";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Existencia del Producto";
            this.columnHeader4.Width = 127;
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarLosProductosConExistenciaParToolStripMenuItem,
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem,
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem,
            this.mostrarElProductoDeMenorPrecioToolStripMenuItem,
            this.mostrarLaSumaYPromedioDelPrecioDeLosProductosToolStripMenuItem,
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem,
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // mostrarLosProductosConExistenciaParToolStripMenuItem
            // 
            this.mostrarLosProductosConExistenciaParToolStripMenuItem.Name = "mostrarLosProductosConExistenciaParToolStripMenuItem";
            this.mostrarLosProductosConExistenciaParToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.mostrarLosProductosConExistenciaParToolStripMenuItem.Text = "Mostrar los productos con existencia par";
            // 
            // mostrarLosProductosConExistenciaImparToolStripMenuItem
            // 
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Name = "mostrarLosProductosConExistenciaImparToolStripMenuItem";
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Text = "Mostrar los productos con existencia impar ";
            // 
            // mostrarElProductoDeMayorPrecioToolStripMenuItem
            // 
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem.Name = "mostrarElProductoDeMayorPrecioToolStripMenuItem";
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem.Text = "Mostrar el producto de mayor precio";
            // 
            // mostrarElProductoDeMenorPrecioToolStripMenuItem
            // 
            this.mostrarElProductoDeMenorPrecioToolStripMenuItem.Name = "mostrarElProductoDeMenorPrecioToolStripMenuItem";
            this.mostrarElProductoDeMenorPrecioToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.mostrarElProductoDeMenorPrecioToolStripMenuItem.Text = "Mostrar el producto de menor precio";
            // 
            // mostrarLaSumaYPromedioDelPrecioDeLosProductosToolStripMenuItem
            // 
            this.mostrarLaSumaYPromedioDelPrecioDeLosProductosToolStripMenuItem.Name = "mostrarLaSumaYPromedioDelPrecioDeLosProductosToolStripMenuItem";
            this.mostrarLaSumaYPromedioDelPrecioDeLosProductosToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.mostrarLaSumaYPromedioDelPrecioDeLosProductosToolStripMenuItem.Text = "Mostrar la suma y promedio del precio de los productos ";
            // 
            // mostrarElProductoDeMayorExistenciaToolStripMenuItem
            // 
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Name = "mostrarElProductoDeMayorExistenciaToolStripMenuItem";
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Text = "Mostrar el producto de mayor existencia";
            // 
            // mostrarElProductoDeMenorExistenciaToolStripMenuItem
            // 
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem.Name = "mostrarElProductoDeMenorExistenciaToolStripMenuItem";
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem.Text = "Mostrar el producto de menor existencia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 303);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Arreglos con Registros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreDelProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPrecioDelProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porExistenciaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLosProductosConExistenciaParToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLosProductosConExistenciaImparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMayorPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMenorPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLaSumaYPromedioDelPrecioDeLosProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMayorExistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMenorExistenciaToolStripMenuItem;
    }
}

