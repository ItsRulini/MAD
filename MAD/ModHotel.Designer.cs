namespace MAD
{
    partial class ModHotel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnConfirmarCambios = new Button();
            groupBox6 = new GroupBox();
            label14 = new Label();
            CantTipoHab = new NumericUpDown();
            btnAgregarHabitacion = new Button();
            label13 = new Label();
            dgvHabExistentes = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            comboTipoHabitacion = new ComboBox();
            label12 = new Label();
            dgvHabAñadidas = new DataGridView();
            HabitacionNueva = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            EliminarHabitacion = new DataGridViewImageColumn();
            label11 = new Label();
            groupBox3 = new GroupBox();
            comboServicio = new ComboBox();
            label5 = new Label();
            dgvServicioAñadido = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            PrecioServicio = new DataGridViewTextBoxColumn();
            EliminarServicio = new DataGridViewImageColumn();
            dgvServicioExistente = new DataGridView();
            Servicio = new DataGridViewTextBoxColumn();
            Precio = new Label();
            label2 = new Label();
            textPrecioServicio = new TextBox();
            btnAgregarServicio = new Button();
            label1 = new Label();
            groupBox5 = new GroupBox();
            label10 = new Label();
            NumPisos = new NumericUpDown();
            groupBox4 = new GroupBox();
            btnInsertAmenidades = new Button();
            label7 = new Label();
            comboTipohabitacionAmenidad = new ComboBox();
            comboAmenidad = new ComboBox();
            btnAdgregarAmenidad = new Button();
            label6 = new Label();
            dgvAmenidadesAñadidas = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            dgvAmenidadExistentes = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            btnBusquedaHotel = new Button();
            label4 = new Label();
            label3 = new Label();
            textNombreHotel = new TextBox();
            comboCiudad = new ComboBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CantTipoHab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHabExistentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHabAñadidas).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicioAñadido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicioExistente).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumPisos).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAmenidadesAñadidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmenidadExistentes).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmarCambios);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1124, 710);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion del hotel";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnConfirmarCambios
            // 
            btnConfirmarCambios.Font = new Font("Times New Roman", 12F);
            btnConfirmarCambios.Location = new Point(700, 32);
            btnConfirmarCambios.Name = "btnConfirmarCambios";
            btnConfirmarCambios.Size = new Size(180, 64);
            btnConfirmarCambios.TabIndex = 22;
            btnConfirmarCambios.Text = "Confirmar cambios";
            btnConfirmarCambios.UseVisualStyleBackColor = true;
            btnConfirmarCambios.Click += btnConfirmarCambios_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(CantTipoHab);
            groupBox6.Controls.Add(btnAgregarHabitacion);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(dgvHabExistentes);
            groupBox6.Controls.Add(comboTipoHabitacion);
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(dgvHabAñadidas);
            groupBox6.Controls.Add(label11);
            groupBox6.Location = new Point(694, 111);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(418, 564);
            groupBox6.TabIndex = 21;
            groupBox6.TabStop = false;
            groupBox6.Text = "Gestión de habitaciones:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(172, 35);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 24;
            label14.Text = "Cantidad:";
            // 
            // CantTipoHab
            // 
            CantTipoHab.Location = new Point(172, 50);
            CantTipoHab.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CantTipoHab.Name = "CantTipoHab";
            CantTipoHab.Size = new Size(66, 23);
            CantTipoHab.TabIndex = 23;
            CantTipoHab.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarHabitacion
            // 
            btnAgregarHabitacion.Font = new Font("Times New Roman", 12F);
            btnAgregarHabitacion.Location = new Point(263, 42);
            btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            btnAgregarHabitacion.Size = new Size(135, 41);
            btnAgregarHabitacion.TabIndex = 17;
            btnAgregarHabitacion.Text = "Agregar habitación";
            btnAgregarHabitacion.UseVisualStyleBackColor = true;
            btnAgregarHabitacion.Click += btnAgregarHabitacion_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F);
            label13.Location = new Point(15, 333);
            label13.Name = "label13";
            label13.Size = new Size(259, 19);
            label13.TabIndex = 22;
            label13.Text = "Habitaciones existentes (No modificable):";
            // 
            // dgvHabExistentes
            // 
            dgvHabExistentes.AllowUserToAddRows = false;
            dgvHabExistentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabExistentes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4 });
            dgvHabExistentes.Location = new Point(15, 355);
            dgvHabExistentes.Name = "dgvHabExistentes";
            dgvHabExistentes.RowHeadersWidth = 51;
            dgvHabExistentes.Size = new Size(295, 195);
            dgvHabExistentes.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Habitación";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // comboTipoHabitacion
            // 
            comboTipoHabitacion.FormattingEnabled = true;
            comboTipoHabitacion.Location = new Point(15, 50);
            comboTipoHabitacion.Name = "comboTipoHabitacion";
            comboTipoHabitacion.Size = new Size(142, 23);
            comboTipoHabitacion.TabIndex = 20;
            comboTipoHabitacion.SelectedIndexChanged += comboTipoHabitacion_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F);
            label12.Location = new Point(15, 28);
            label12.Name = "label12";
            label12.Size = new Size(123, 19);
            label12.TabIndex = 20;
            label12.Text = "Tipo de habitación:";
            // 
            // dgvHabAñadidas
            // 
            dgvHabAñadidas.AllowUserToAddRows = false;
            dgvHabAñadidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabAñadidas.Columns.AddRange(new DataGridViewColumn[] { HabitacionNueva, Cantidad, EliminarHabitacion });
            dgvHabAñadidas.Location = new Point(15, 113);
            dgvHabAñadidas.Name = "dgvHabAñadidas";
            dgvHabAñadidas.RowHeadersWidth = 51;
            dgvHabAñadidas.Size = new Size(397, 195);
            dgvHabAñadidas.TabIndex = 18;
            dgvHabAñadidas.CellContentClick += dgvHabAñadidas_CellContentClick_1;
            // 
            // HabitacionNueva
            // 
            HabitacionNueva.HeaderText = "Habitación";
            HabitacionNueva.MinimumWidth = 6;
            HabitacionNueva.Name = "HabitacionNueva";
            HabitacionNueva.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // EliminarHabitacion
            // 
            EliminarHabitacion.HeaderText = "Eliminar";
            EliminarHabitacion.Image = Properties.Resources.basura;
            EliminarHabitacion.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EliminarHabitacion.MinimumWidth = 6;
            EliminarHabitacion.Name = "EliminarHabitacion";
            EliminarHabitacion.Resizable = DataGridViewTriState.True;
            EliminarHabitacion.SortMode = DataGridViewColumnSortMode.Automatic;
            EliminarHabitacion.Width = 125;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F);
            label11.Location = new Point(15, 91);
            label11.Name = "label11";
            label11.Size = new Size(147, 19);
            label11.TabIndex = 20;
            label11.Text = "Habitaciones añadidas:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboServicio);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dgvServicioAñadido);
            groupBox3.Controls.Add(dgvServicioExistente);
            groupBox3.Controls.Add(Precio);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textPrecioServicio);
            groupBox3.Controls.Add(btnAgregarServicio);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(5, 405);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(675, 292);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gestión de servicios:";
            // 
            // comboServicio
            // 
            comboServicio.FormattingEnabled = true;
            comboServicio.Location = new Point(9, 57);
            comboServicio.Name = "comboServicio";
            comboServicio.Size = new Size(148, 23);
            comboServicio.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(4, 97);
            label5.Name = "label5";
            label5.Size = new Size(125, 19);
            label5.TabIndex = 15;
            label5.Text = "Servicios añadidos:";
            // 
            // dgvServicioAñadido
            // 
            dgvServicioAñadido.AllowUserToAddRows = false;
            dgvServicioAñadido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicioAñadido.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, PrecioServicio, EliminarServicio });
            dgvServicioAñadido.Location = new Point(4, 119);
            dgvServicioAñadido.Name = "dgvServicioAñadido";
            dgvServicioAñadido.RowHeadersWidth = 51;
            dgvServicioAñadido.Size = new Size(369, 168);
            dgvServicioAñadido.TabIndex = 14;
            dgvServicioAñadido.CellContentClick += dgvServicioAñadido_CellContentClick_1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // PrecioServicio
            // 
            PrecioServicio.HeaderText = "Precio";
            PrecioServicio.MinimumWidth = 6;
            PrecioServicio.Name = "PrecioServicio";
            PrecioServicio.Width = 125;
            // 
            // EliminarServicio
            // 
            EliminarServicio.HeaderText = "Eliminar";
            EliminarServicio.Image = Properties.Resources.basura;
            EliminarServicio.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EliminarServicio.MinimumWidth = 6;
            EliminarServicio.Name = "EliminarServicio";
            EliminarServicio.Resizable = DataGridViewTriState.True;
            EliminarServicio.SortMode = DataGridViewColumnSortMode.Automatic;
            EliminarServicio.Width = 75;
            // 
            // dgvServicioExistente
            // 
            dgvServicioExistente.AllowUserToAddRows = false;
            dgvServicioExistente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicioExistente.Columns.AddRange(new DataGridViewColumn[] { Servicio });
            dgvServicioExistente.Location = new Point(388, 119);
            dgvServicioExistente.Name = "dgvServicioExistente";
            dgvServicioExistente.RowHeadersWidth = 51;
            dgvServicioExistente.Size = new Size(244, 168);
            dgvServicioExistente.TabIndex = 4;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Nombre";
            Servicio.MinimumWidth = 6;
            Servicio.Name = "Servicio";
            Servicio.Width = 200;
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Font = new Font("Times New Roman", 12F);
            Precio.Location = new Point(173, 35);
            Precio.Name = "Precio";
            Precio.Size = new Size(51, 19);
            Precio.TabIndex = 13;
            Precio.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(388, 98);
            label2.Name = "label2";
            label2.Size = new Size(236, 19);
            label2.TabIndex = 3;
            label2.Text = "Servicios existentes (No modificable):";
            // 
            // textPrecioServicio
            // 
            textPrecioServicio.Location = new Point(173, 57);
            textPrecioServicio.Name = "textPrecioServicio";
            textPrecioServicio.Size = new Size(158, 23);
            textPrecioServicio.TabIndex = 12;
            textPrecioServicio.KeyPress += textPrecioServicio_KeyPress;
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.Font = new Font("Times New Roman", 12F);
            btnAgregarServicio.Location = new Point(374, 49);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(168, 34);
            btnAgregarServicio.TabIndex = 1;
            btnAgregarServicio.Text = "Agregar servicio";
            btnAgregarServicio.UseVisualStyleBackColor = true;
            btnAgregarServicio.Click += btnAgregarServicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(5, 35);
            label1.Name = "label1";
            label1.Size = new Size(135, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre del servicio:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(NumPisos);
            groupBox5.Location = new Point(442, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(230, 83);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Configuración del hotel:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 19);
            label10.Name = "label10";
            label10.Size = new Size(100, 15);
            label10.TabIndex = 1;
            label10.Text = "Número de pisos:";
            // 
            // NumPisos
            // 
            NumPisos.Location = new Point(14, 46);
            NumPisos.Name = "NumPisos";
            NumPisos.Size = new Size(120, 23);
            NumPisos.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnInsertAmenidades);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(comboTipohabitacionAmenidad);
            groupBox4.Controls.Add(comboAmenidad);
            groupBox4.Controls.Add(btnAdgregarAmenidad);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(dgvAmenidadesAñadidas);
            groupBox4.Controls.Add(dgvAmenidadExistentes);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(5, 111);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(675, 286);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gestión de amenidades:";
            // 
            // btnInsertAmenidades
            // 
            btnInsertAmenidades.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsertAmenidades.Location = new Point(376, 10);
            btnInsertAmenidades.Margin = new Padding(3, 2, 3, 2);
            btnInsertAmenidades.Name = "btnInsertAmenidades";
            btnInsertAmenidades.Size = new Size(165, 34);
            btnInsertAmenidades.TabIndex = 20;
            btnInsertAmenidades.Text = "Agregar amenidades";
            btnInsertAmenidades.UseVisualStyleBackColor = true;
            btnInsertAmenidades.Click += btnInsertAmenidades_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.Location = new Point(11, 35);
            label7.Name = "label7";
            label7.Size = new Size(123, 19);
            label7.TabIndex = 19;
            label7.Text = "Tipo de habitación:";
            // 
            // comboTipohabitacionAmenidad
            // 
            comboTipohabitacionAmenidad.FormattingEnabled = true;
            comboTipohabitacionAmenidad.Location = new Point(13, 57);
            comboTipohabitacionAmenidad.Name = "comboTipohabitacionAmenidad";
            comboTipohabitacionAmenidad.Size = new Size(142, 23);
            comboTipohabitacionAmenidad.TabIndex = 18;
            comboTipohabitacionAmenidad.SelectedIndexChanged += comboTipohabitacionAmenidad_SelectedIndexChanged;
            // 
            // comboAmenidad
            // 
            comboAmenidad.FormattingEnabled = true;
            comboAmenidad.Location = new Point(173, 57);
            comboAmenidad.Name = "comboAmenidad";
            comboAmenidad.Size = new Size(158, 23);
            comboAmenidad.TabIndex = 17;
            // 
            // btnAdgregarAmenidad
            // 
            btnAdgregarAmenidad.Font = new Font("Times New Roman", 12F);
            btnAdgregarAmenidad.Location = new Point(376, 50);
            btnAdgregarAmenidad.Name = "btnAdgregarAmenidad";
            btnAdgregarAmenidad.Size = new Size(165, 40);
            btnAdgregarAmenidad.TabIndex = 16;
            btnAdgregarAmenidad.Text = "Añadir amenidad a la lista";
            btnAdgregarAmenidad.UseVisualStyleBackColor = true;
            btnAdgregarAmenidad.Click += btnAdgregarAmenidad_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(6, 98);
            label6.Name = "label6";
            label6.Size = new Size(141, 19);
            label6.TabIndex = 15;
            label6.Text = "Amenidades añadidas";
            // 
            // dgvAmenidadesAñadidas
            // 
            dgvAmenidadesAñadidas.AllowUserToAddRows = false;
            dgvAmenidadesAñadidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmenidadesAñadidas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Eliminar });
            dgvAmenidadesAñadidas.Location = new Point(6, 120);
            dgvAmenidadesAñadidas.Name = "dgvAmenidadesAñadidas";
            dgvAmenidadesAñadidas.RowHeadersWidth = 51;
            dgvAmenidadesAñadidas.Size = new Size(345, 160);
            dgvAmenidadesAñadidas.TabIndex = 14;
            dgvAmenidadesAñadidas.CellContentClick += dgvAmenidadesAñadidas_CellContentClick_1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.basura;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Width = 125;
            // 
            // dgvAmenidadExistentes
            // 
            dgvAmenidadExistentes.AllowUserToAddRows = false;
            dgvAmenidadExistentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmenidadExistentes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3 });
            dgvAmenidadExistentes.Location = new Point(376, 120);
            dgvAmenidadExistentes.Name = "dgvAmenidadExistentes";
            dgvAmenidadExistentes.RowHeadersWidth = 51;
            dgvAmenidadExistentes.Size = new Size(244, 160);
            dgvAmenidadExistentes.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F);
            label8.Location = new Point(376, 98);
            label8.Name = "label8";
            label8.Size = new Size(262, 19);
            label8.TabIndex = 3;
            label8.Text = "Amenidades existentes (No modificables):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F);
            label9.Location = new Point(173, 35);
            label9.Name = "label9";
            label9.Size = new Size(139, 19);
            label9.TabIndex = 0;
            label9.Text = "Seleccione amenidad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBusquedaHotel);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textNombreHotel);
            groupBox2.Controls.Add(comboCiudad);
            groupBox2.Location = new Point(7, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 83);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda de hotel:";
            // 
            // btnBusquedaHotel
            // 
            btnBusquedaHotel.Font = new Font("Times New Roman", 12F);
            btnBusquedaHotel.Location = new Point(338, 49);
            btnBusquedaHotel.Name = "btnBusquedaHotel";
            btnBusquedaHotel.Size = new Size(75, 25);
            btnBusquedaHotel.TabIndex = 4;
            btnBusquedaHotel.Text = "Buscar";
            btnBusquedaHotel.UseVisualStyleBackColor = true;
            btnBusquedaHotel.Click += btnBusquedaHotel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(198, 26);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 3;
            label4.Text = "Ciudad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(13, 26);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 2;
            label3.Text = "Nombre de hotel:";
            // 
            // textNombreHotel
            // 
            textNombreHotel.Font = new Font("Times New Roman", 12F);
            textNombreHotel.Location = new Point(13, 48);
            textNombreHotel.Name = "textNombreHotel";
            textNombreHotel.Size = new Size(154, 26);
            textNombreHotel.TabIndex = 1;
            // 
            // comboCiudad
            // 
            comboCiudad.FormattingEnabled = true;
            comboCiudad.Location = new Point(198, 51);
            comboCiudad.Name = "comboCiudad";
            comboCiudad.Size = new Size(121, 23);
            comboCiudad.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(975, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ModHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1148, 731);
            Controls.Add(groupBox1);
            Name = "ModHotel";
            Text = "Modificar Hotel";
            Load += ModHotel_Load;
            groupBox1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CantTipoHab).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHabExistentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHabAñadidas).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicioAñadido).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicioExistente).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumPisos).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAmenidadesAñadidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmenidadExistentes).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private DataGridView dgvServicioExistente;
        private DataGridViewTextBoxColumn Servicio;
        private Label label2;
        private TextBox textNombreServicio;
        private Button btnAgregarServicio;
        private Label label1;
        private Label Precio;
        private TextBox textPrecioServicio;
        private GroupBox groupBox2;
        private Button btnBusquedaHotel;
        private Label label4;
        private Label label3;
        private TextBox textNombreHotel;
        private ComboBox comboCiudad;
        private GroupBox groupBox3;
        private Label label5;
        private DataGridView dgvServicioAñadido;
        private Label label7;
        private TextBox textBox2;
        private GroupBox groupBox4;
        private ComboBox comboTipohabitacionAmenidad;
        private ComboBox comboAmenidad;
        private Button btnAdgregarAmenidad;
        private Label label6;
        private DataGridView dgvAmenidadesAñadidas;
        private DataGridView dgvAmenidadExistentes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label8;
        private Label label9;
        private ComboBox comboServicio;
        private GroupBox groupBox5;
        private NumericUpDown NumPisos;
        private Label label10;
        private GroupBox groupBox6;
        private DataGridView dgvHabAñadidas;
        private Label label11;
        private ComboBox comboTipoHabitacion;
        private Label label12;
        private Label label13;
        private DataGridView dgvHabExistentes;
        private Button btnConfirmarCambios;
        private Label label14;
        private NumericUpDown CantTipoHab;
        private Button btnAgregarHabitacion;
        private Button btnInsertAmenidades;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn HabitacionNueva;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewImageColumn EliminarHabitacion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn PrecioServicio;
        private DataGridViewImageColumn EliminarServicio;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewImageColumn Eliminar;
    }
}