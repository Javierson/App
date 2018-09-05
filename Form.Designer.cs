namespace App_2
{
    partial class Frame
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
            this.VerticalMenu = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Cita = new System.Windows.Forms.TabPage();
            this.DG = new System.Windows.Forms.DataGridView();
            this.BTNQueryCitas = new System.Windows.Forms.Button();
            this.GroupBoxCita = new System.Windows.Forms.GroupBox();
            this.LVCitasSubrogados = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estudio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Region = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Empresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Procedencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.Cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // VerticalMenu
            // 
            this.VerticalMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.VerticalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerticalMenu.Location = new System.Drawing.Point(0, 0);
            this.VerticalMenu.Name = "VerticalMenu";
            this.VerticalMenu.Size = new System.Drawing.Size(200, 544);
            this.VerticalMenu.TabIndex = 1;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Cita);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(200, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(778, 544);
            this.TabControl.TabIndex = 4;
            // 
            // Cita
            // 
            this.Cita.Controls.Add(this.DG);
            this.Cita.Controls.Add(this.BTNQueryCitas);
            this.Cita.Controls.Add(this.GroupBoxCita);
            this.Cita.Controls.Add(this.LVCitasSubrogados);
            this.Cita.Location = new System.Drawing.Point(4, 29);
            this.Cita.Name = "Cita";
            this.Cita.Padding = new System.Windows.Forms.Padding(3);
            this.Cita.Size = new System.Drawing.Size(770, 511);
            this.Cita.TabIndex = 0;
            this.Cita.Text = "Cita subrogada";
            this.Cita.UseVisualStyleBackColor = true;
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(38, 200);
            this.DG.Name = "DG";
            this.DG.RowTemplate.Height = 28;
            this.DG.Size = new System.Drawing.Size(470, 84);
            this.DG.TabIndex = 4;
            // 
            // BTNQueryCitas
            // 
            this.BTNQueryCitas.Location = new System.Drawing.Point(535, 200);
            this.BTNQueryCitas.Name = "BTNQueryCitas";
            this.BTNQueryCitas.Size = new System.Drawing.Size(200, 40);
            this.BTNQueryCitas.TabIndex = 3;
            this.BTNQueryCitas.Text = "Consultar todas las Citas";
            this.BTNQueryCitas.UseVisualStyleBackColor = true;
            this.BTNQueryCitas.Click += new System.EventHandler(this.BTNQueryCitas_Click);
            // 
            // GroupBoxCita
            // 
            this.GroupBoxCita.Location = new System.Drawing.Point(26, 34);
            this.GroupBoxCita.Name = "GroupBoxCita";
            this.GroupBoxCita.Size = new System.Drawing.Size(709, 131);
            this.GroupBoxCita.TabIndex = 2;
            this.GroupBoxCita.TabStop = false;
            this.GroupBoxCita.Text = "Formulario de cita subrogada";
            // 
            // LVCitasSubrogados
            // 
            this.LVCitasSubrogados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Paciente,
            this.Estudio,
            this.Clase,
            this.Region,
            this.Medico,
            this.Empresa,
            this.Procedencia,
            this.Coordinacion});
            this.LVCitasSubrogados.FullRowSelect = true;
            this.LVCitasSubrogados.GridLines = true;
            this.LVCitasSubrogados.Location = new System.Drawing.Point(26, 318);
            this.LVCitasSubrogados.Name = "LVCitasSubrogados";
            this.LVCitasSubrogados.Size = new System.Drawing.Size(709, 164);
            this.LVCitasSubrogados.TabIndex = 1;
            this.LVCitasSubrogados.UseCompatibleStateImageBehavior = false;
            this.LVCitasSubrogados.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 56;
            // 
            // Paciente
            // 
            this.Paciente.Text = "Paciente";
            this.Paciente.Width = 102;
            // 
            // Estudio
            // 
            this.Estudio.Text = "Estudio";
            this.Estudio.Width = 100;
            // 
            // Clase
            // 
            this.Clase.Text = "Clase";
            this.Clase.Width = 97;
            // 
            // Region
            // 
            this.Region.Text = "Region";
            this.Region.Width = 66;
            // 
            // Medico
            // 
            this.Medico.Text = "Medico";
            // 
            // Empresa
            // 
            this.Empresa.Text = "Empresa";
            // 
            // Procedencia
            // 
            this.Procedencia.Text = "Procedencia";
            // 
            // Coordinacion
            // 
            this.Coordinacion.Text = "Coordinacion";
            this.Coordinacion.Width = 103;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.VerticalMenu);
            this.Name = "Frame";
            this.Text = "App";
            this.TabControl.ResumeLayout(false);
            this.Cita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VerticalMenu;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Cita;
        private System.Windows.Forms.GroupBox GroupBoxCita;
        private System.Windows.Forms.ListView LVCitasSubrogados;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Paciente;
        private System.Windows.Forms.ColumnHeader Estudio;
        private System.Windows.Forms.ColumnHeader Clase;
        private System.Windows.Forms.ColumnHeader Region;
        private System.Windows.Forms.ColumnHeader Medico;
        private System.Windows.Forms.ColumnHeader Empresa;
        private System.Windows.Forms.ColumnHeader Procedencia;
        private System.Windows.Forms.ColumnHeader Coordinacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BTNQueryCitas;
        private System.Windows.Forms.DataGridView DG;
    }
}

