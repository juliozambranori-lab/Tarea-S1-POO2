namespace GestionTareasPendientes
{
    partial class frmGestionTareas
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
            lblTitulo = new Label();
            txtTarea = new TextBox();
            btnAgregarTarea = new Button();
            lstTareas = new ListBox();
            btnEliminarTarea = new Button();
            btnLimpiarLista = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(145, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(113, 13);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Tareas Pendientes";
            lblTitulo.UseWaitCursor = true;
            lblTitulo.Click += label1_Click;
            // 
            // txtTarea
            // 
            txtTarea.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtTarea.Location = new Point(111, 25);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(174, 20);
            txtTarea.TabIndex = 1;
            txtTarea.UseWaitCursor = true;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor = Color.LightGreen;
            btnAgregarTarea.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnAgregarTarea.ForeColor = SystemColors.ControlText;
            btnAgregarTarea.Location = new Point(101, 51);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(100, 23);
            btnAgregarTarea.TabIndex = 2;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = false;
            btnAgregarTarea.UseWaitCursor = true;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // lstTareas
            // 
            lstTareas.Font = new Font("Microsoft Sans Serif", 8.25F);
            lstTareas.FormattingEnabled = true;
            lstTareas.Location = new Point(61, 80);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(262, 134);
            lstTareas.TabIndex = 3;
            lstTareas.UseWaitCursor = true;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.BackColor = Color.LightCoral;
            btnEliminarTarea.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnEliminarTarea.Location = new Point(71, 220);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(92, 23);
            btnEliminarTarea.TabIndex = 4;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = false;
            btnEliminarTarea.UseWaitCursor = true;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // btnLimpiarLista
            // 
            btnLimpiarLista.BackColor = Color.Khaki;
            btnLimpiarLista.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnLimpiarLista.Location = new Point(216, 220);
            btnLimpiarLista.Name = "btnLimpiarLista";
            btnLimpiarLista.Size = new Size(87, 23);
            btnLimpiarLista.TabIndex = 5;
            btnLimpiarLista.Text = "Borrar Lista";
            btnLimpiarLista.UseVisualStyleBackColor = false;
            btnLimpiarLista.UseWaitCursor = true;
            btnLimpiarLista.Click += button1_Click;
            // 
            // frmGestionTareas
            // 
            AutoScaleDimensions = new SizeF(478F, 1149F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(374, 297);
            Controls.Add(btnLimpiarLista);
            Controls.Add(btnEliminarTarea);
            Controls.Add(lstTareas);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtTarea);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Inch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(239, 287, 239, 287);
            MaximizeBox = false;
            Name = "frmGestionTareas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Tareas";
            UseWaitCursor = true;
            Load += frmGestionTareas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtTarea;
        private Button btnAgregarTarea;
        private ListBox lstTareas;
        private Button btnEliminarTarea;
        private Button btnLimpiarLista;
    }
}
