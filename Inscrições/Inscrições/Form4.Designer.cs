namespace Inscrições
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label iDAlunoLabel;
            System.Windows.Forms.Label iDCursoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.basedadosDataSet = new Inscrições.BasedadosDataSet();
            this.inscricoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricoesTableAdapter = new Inscrições.BasedadosDataSetTableAdapters.InscricoesTableAdapter();
            this.tableAdapterManager = new Inscrições.BasedadosDataSetTableAdapters.TableAdapterManager();
            this.inscricoesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inscricoesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iDAlunoTextBox = new System.Windows.Forms.TextBox();
            this.iDCursoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            iDAlunoLabel = new System.Windows.Forms.Label();
            iDCursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basedadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingNavigator)).BeginInit();
            this.inscricoesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(91, 105);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(91, 138);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(48, 20);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "Data:";
            // 
            // iDAlunoLabel
            // 
            iDAlunoLabel.AutoSize = true;
            iDAlunoLabel.Location = new System.Drawing.Point(91, 169);
            iDAlunoLabel.Name = "iDAlunoLabel";
            iDAlunoLabel.Size = new System.Drawing.Size(71, 20);
            iDAlunoLabel.TabIndex = 5;
            iDAlunoLabel.Text = "IDAluno:";
            // 
            // iDCursoLabel
            // 
            iDCursoLabel.AutoSize = true;
            iDCursoLabel.Location = new System.Drawing.Point(91, 201);
            iDCursoLabel.Name = "iDCursoLabel";
            iDCursoLabel.Size = new System.Drawing.Size(72, 20);
            iDCursoLabel.TabIndex = 7;
            iDCursoLabel.Text = "IDCurso:";
            // 
            // basedadosDataSet
            // 
            this.basedadosDataSet.DataSetName = "BasedadosDataSet";
            this.basedadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscricoesBindingSource
            // 
            this.inscricoesBindingSource.DataMember = "Inscricoes";
            this.inscricoesBindingSource.DataSource = this.basedadosDataSet;
            // 
            // inscricoesTableAdapter
            // 
            this.inscricoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.InscricoesTableAdapter = this.inscricoesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Inscrições.BasedadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inscricoesBindingNavigator
            // 
            this.inscricoesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inscricoesBindingNavigator.BindingSource = this.inscricoesBindingSource;
            this.inscricoesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inscricoesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inscricoesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.inscricoesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.inscricoesBindingNavigatorSaveItem});
            this.inscricoesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inscricoesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inscricoesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inscricoesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inscricoesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inscricoesBindingNavigator.Name = "inscricoesBindingNavigator";
            this.inscricoesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inscricoesBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.inscricoesBindingNavigator.TabIndex = 0;
            this.inscricoesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // inscricoesBindingNavigatorSaveItem
            // 
            this.inscricoesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inscricoesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inscricoesBindingNavigatorSaveItem.Image")));
            this.inscricoesBindingNavigatorSaveItem.Name = "inscricoesBindingNavigatorSaveItem";
            this.inscricoesBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.inscricoesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.inscricoesBindingNavigatorSaveItem.Click += new System.EventHandler(this.inscricoesBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricoesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(169, 102);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inscricoesBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(169, 134);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // iDAlunoTextBox
            // 
            this.iDAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricoesBindingSource, "IDAluno", true));
            this.iDAlunoTextBox.Location = new System.Drawing.Point(169, 166);
            this.iDAlunoTextBox.Name = "iDAlunoTextBox";
            this.iDAlunoTextBox.Size = new System.Drawing.Size(200, 26);
            this.iDAlunoTextBox.TabIndex = 6;
            // 
            // iDCursoTextBox
            // 
            this.iDCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricoesBindingSource, "IDCurso", true));
            this.iDCursoTextBox.Location = new System.Drawing.Point(169, 198);
            this.iDCursoTextBox.Name = "iDCursoTextBox";
            this.iDCursoTextBox.Size = new System.Drawing.Size(200, 26);
            this.iDCursoTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome do Aluno";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome do Curso";
            this.label2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(520, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(520, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(iDAlunoLabel);
            this.Controls.Add(this.iDAlunoTextBox);
            this.Controls.Add(iDCursoLabel);
            this.Controls.Add(this.iDCursoTextBox);
            this.Controls.Add(this.inscricoesBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basedadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBindingNavigator)).EndInit();
            this.inscricoesBindingNavigator.ResumeLayout(false);
            this.inscricoesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasedadosDataSet basedadosDataSet;
        private System.Windows.Forms.BindingSource inscricoesBindingSource;
        private BasedadosDataSetTableAdapters.InscricoesTableAdapter inscricoesTableAdapter;
        private BasedadosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inscricoesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton inscricoesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox iDAlunoTextBox;
        private System.Windows.Forms.TextBox iDCursoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}