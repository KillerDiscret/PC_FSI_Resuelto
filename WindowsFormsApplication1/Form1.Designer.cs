namespace WindowsFormsApplication1
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
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCuartelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSoldadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuartelToolStripMenuItem,
            this.registrarSoldadoToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem,
            this.listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem,
            this.mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem,
            this.mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // crearCuartelToolStripMenuItem
            // 
            this.crearCuartelToolStripMenuItem.Name = "crearCuartelToolStripMenuItem";
            this.crearCuartelToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.crearCuartelToolStripMenuItem.Text = "Crear cuartel";
            this.crearCuartelToolStripMenuItem.Click += new System.EventHandler(this.crearCuartelToolStripMenuItem_Click);
            // 
            // registrarSoldadoToolStripMenuItem
            // 
            this.registrarSoldadoToolStripMenuItem.Name = "registrarSoldadoToolStripMenuItem";
            this.registrarSoldadoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.registrarSoldadoToolStripMenuItem.Text = "Registrar soldado";
            this.registrarSoldadoToolStripMenuItem.Click += new System.EventHandler(this.registrarSoldadoToolStripMenuItem_Click);
            // 
            // listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem
            // 
            this.listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem.Name = "listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem";
            this.listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem.Size = new System.Drawing.Size(427, 22);
            this.listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem.Text = "Listar cuarteles con soldados de mayor edad";
            this.listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem.Click += new System.EventHandler(this.listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem_Click);
            // 
            // listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem
            // 
            this.listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem.Name = "listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem";
            this.listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem.Size = new System.Drawing.Size(427, 22);
            this.listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem.Text = "Listar cuarteles con mayor cantidad de soldados de una especialiad";
            this.listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem.Click += new System.EventHandler(this.listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem_Click);
            // 
            // mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem
            // 
            this.mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem.Name = "mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem";
            this.mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem.Size = new System.Drawing.Size(427, 22);
            this.mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem.Text = "Mostrar especialidades que tienen menor cantidad de soldados";
            this.mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem_Click);
            // 
            // mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem
            // 
            this.mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem.Name = "mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem";
            this.mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(427, 22);
            this.mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem.Text = "Mostrar edad promedio de soldados por especialidad";
            this.mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCuartelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSoldadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem;
    }
}

