namespace kama_ztj
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_работникаLabel;
            System.Windows.Forms.Label фИО_РаботникаLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label дата_рождениеLabel;
            System.Windows.Forms.Label дата_поступлениеLabel;
            System.Windows.Forms.Label национальностьLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label категорияLabel;
            System.Windows.Forms.Label признак_военнообязанностиLabel;
            System.Windows.Forms.Label код_должностиLabel;
            this.dataSet1 = new kama_ztj.DataSet1();
            this.работникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работникиTableAdapter = new kama_ztj.DataSet1TableAdapters.РаботникиTableAdapter();
            this.tableAdapterManager = new kama_ztj.DataSet1TableAdapters.TableAdapterManager();
            this.работникиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.работникиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_работникаTextBox = new System.Windows.Forms.TextBox();
            this.фИО_РаботникаTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.дата_рождениеDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_поступлениеDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.национальностьTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.категорияTextBox = new System.Windows.Forms.TextBox();
            this.признак_военнообязанностиTextBox = new System.Windows.Forms.TextBox();
            this.код_должностиTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.работникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_работникаLabel = new System.Windows.Forms.Label();
            фИО_РаботникаLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            дата_рождениеLabel = new System.Windows.Forms.Label();
            дата_поступлениеLabel = new System.Windows.Forms.Label();
            национальностьLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            категорияLabel = new System.Windows.Forms.Label();
            признак_военнообязанностиLabel = new System.Windows.Forms.Label();
            код_должностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingNavigator)).BeginInit();
            this.работникиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.работникиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_работникаLabel
            // 
            код_работникаLabel.AutoSize = true;
            код_работникаLabel.Location = new System.Drawing.Point(686, 526);
            код_работникаLabel.Name = "код_работникаLabel";
            код_работникаLabel.Size = new System.Drawing.Size(125, 20);
            код_работникаLabel.TabIndex = 2;
            код_работникаLabel.Text = "код работника:";
            // 
            // фИО_РаботникаLabel
            // 
            фИО_РаботникаLabel.AutoSize = true;
            фИО_РаботникаLabel.Location = new System.Drawing.Point(686, 558);
            фИО_РаботникаLabel.Name = "фИО_РаботникаLabel";
            фИО_РаботникаLabel.Size = new System.Drawing.Size(136, 20);
            фИО_РаботникаLabel.TabIndex = 4;
            фИО_РаботникаLabel.Text = "ФИО Работника:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(686, 590);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(59, 20);
            адресLabel.TabIndex = 6;
            адресLabel.Text = "адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(686, 622);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(83, 20);
            телефонLabel.TabIndex = 8;
            телефонLabel.Text = "телефон:";
            // 
            // дата_рождениеLabel
            // 
            дата_рождениеLabel.AutoSize = true;
            дата_рождениеLabel.Location = new System.Drawing.Point(686, 655);
            дата_рождениеLabel.Name = "дата_рождениеLabel";
            дата_рождениеLabel.Size = new System.Drawing.Size(131, 20);
            дата_рождениеLabel.TabIndex = 10;
            дата_рождениеLabel.Text = "дата рождение:";
            // 
            // дата_поступлениеLabel
            // 
            дата_поступлениеLabel.AutoSize = true;
            дата_поступлениеLabel.Location = new System.Drawing.Point(686, 687);
            дата_поступлениеLabel.Name = "дата_поступлениеLabel";
            дата_поступлениеLabel.Size = new System.Drawing.Size(152, 20);
            дата_поступлениеLabel.TabIndex = 12;
            дата_поступлениеLabel.Text = "дата поступление:";
            // 
            // национальностьLabel
            // 
            национальностьLabel.AutoSize = true;
            национальностьLabel.Location = new System.Drawing.Point(686, 718);
            национальностьLabel.Name = "национальностьLabel";
            национальностьLabel.Size = new System.Drawing.Size(139, 20);
            национальностьLabel.TabIndex = 14;
            национальностьLabel.Text = "национальность:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(686, 750);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(41, 20);
            полLabel.TabIndex = 16;
            полLabel.Text = "пол:";
            // 
            // категорияLabel
            // 
            категорияLabel.AutoSize = true;
            категорияLabel.Location = new System.Drawing.Point(686, 782);
            категорияLabel.Name = "категорияLabel";
            категорияLabel.Size = new System.Drawing.Size(91, 20);
            категорияLabel.TabIndex = 18;
            категорияLabel.Text = "категория:";
            // 
            // признак_военнообязанностиLabel
            // 
            признак_военнообязанностиLabel.AutoSize = true;
            признак_военнообязанностиLabel.Location = new System.Drawing.Point(686, 814);
            признак_военнообязанностиLabel.Name = "признак_военнообязанностиLabel";
            признак_военнообязанностиLabel.Size = new System.Drawing.Size(229, 20);
            признак_военнообязанностиLabel.TabIndex = 20;
            признак_военнообязанностиLabel.Text = "признак военнообязанности:";
            // 
            // код_должностиLabel
            // 
            код_должностиLabel.AutoSize = true;
            код_должностиLabel.Location = new System.Drawing.Point(686, 846);
            код_должностиLabel.Name = "код_должностиLabel";
            код_должностиLabel.Size = new System.Drawing.Size(130, 20);
            код_должностиLabel.TabIndex = 22;
            код_должностиLabel.Text = "код должности:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работникиBindingSource
            // 
            this.работникиBindingSource.DataMember = "Работники";
            this.работникиBindingSource.DataSource = this.dataSet1;
            // 
            // работникиTableAdapter
            // 
            this.работникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = kama_ztj.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.РаботникиTableAdapter = this.работникиTableAdapter;
            // 
            // работникиBindingNavigator
            // 
            this.работникиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.работникиBindingNavigator.BindingSource = this.работникиBindingSource;
            this.работникиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.работникиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.работникиBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.работникиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.работникиBindingNavigatorSaveItem});
            this.работникиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.работникиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.работникиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.работникиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.работникиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.работникиBindingNavigator.Name = "работникиBindingNavigator";
            this.работникиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.работникиBindingNavigator.Size = new System.Drawing.Size(1540, 38);
            this.работникиBindingNavigator.TabIndex = 0;
            this.работникиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // работникиBindingNavigatorSaveItem
            // 
            this.работникиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.работникиBindingNavigatorSaveItem.Name = "работникиBindingNavigatorSaveItem";
            this.работникиBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.работникиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.работникиBindingNavigatorSaveItem.Click += new System.EventHandler(this.работникиBindingNavigatorSaveItem_Click);
            // 
            // код_работникаTextBox
            // 
            this.код_работникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работникиBindingSource, "код работника", true));
            this.код_работникаTextBox.Location = new System.Drawing.Point(921, 523);
            this.код_работникаTextBox.Name = "код_работникаTextBox";
            this.код_работникаTextBox.Size = new System.Drawing.Size(200, 26);
            this.код_работникаTextBox.TabIndex = 3;
            // 
            // фИО_РаботникаTextBox
            // 
            this.фИО_РаботникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работникиBindingSource, "ФИО Работника", true));
            this.фИО_РаботникаTextBox.Location = new System.Drawing.Point(921, 555);
            this.фИО_РаботникаTextBox.Name = "фИО_РаботникаTextBox";
            this.фИО_РаботникаTextBox.Size = new System.Drawing.Size(200, 26);
            this.фИО_РаботникаTextBox.TabIndex = 5;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работникиBindingSource, "адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(921, 587);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(200, 26);
            this.адресTextBox.TabIndex = 7;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работникиBindingSource, "телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(921, 619);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 26);
            this.телефонTextBox.TabIndex = 9;
            // 
            // дата_рождениеDateTimePicker
            // 
            this.дата_рождениеDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.работникиBindingSource, "дата рождение", true));
            this.дата_рождениеDateTimePicker.Location = new System.Drawing.Point(921, 651);
            this.дата_рождениеDateTimePicker.Name = "дата_рождениеDateTimePicker";
            this.дата_рождениеDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.дата_рождениеDateTimePicker.TabIndex = 11;
            // 
            // дата_поступлениеDateTimePicker
            // 
            this.дата_поступлениеDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.работникиBindingSource, "дата поступление", true));
            this.дата_поступлениеDateTimePicker.Location = new System.Drawing.Point(921, 683);
            this.дата_поступлениеDateTimePicker.Name = "дата_поступлениеDateTimePicker";
            this.дата_поступлениеDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.дата_поступлениеDateTimePicker.TabIndex = 13;
            // 
            // национальностьTextBox
            // 
            this.национальностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работникиBindingSource, "национальность", true));
            this.национальностьTextBox.Location = new System.Drawing.Point(921, 715);
            this.национальностьTextBox.Name = "национальностьTextBox";
            this.национальностьTextBox.Size = new System.Drawing.Size(200, 26);
            this.национальностьTextBox.TabIndex = 15;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работникиBindingSource, "пол", true));
            this.полTextBox.Location = new System.Drawing.Point(921, 747);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(200, 26);
            this.полTextBox.TabIndex = 17;
            // 
            // категорияTextBox
            // 
            this.категорияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работникиBindingSource, "категория", true));
            this.категорияTextBox.Location = new System.Drawing.Point(921, 779);
            this.категорияTextBox.Name = "категорияTextBox";
            this.категорияTextBox.Size = new System.Drawing.Size(200, 26);
            this.категорияTextBox.TabIndex = 19;
            // 
            // признак_военнообязанностиTextBox
            // 
            this.признак_военнообязанностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работникиBindingSource, "признак военнообязанности", true));
            this.признак_военнообязанностиTextBox.Location = new System.Drawing.Point(921, 811);
            this.признак_военнообязанностиTextBox.Name = "признак_военнообязанностиTextBox";
            this.признак_военнообязанностиTextBox.Size = new System.Drawing.Size(200, 26);
            this.признак_военнообязанностиTextBox.TabIndex = 21;
            // 
            // код_должностиTextBox
            // 
            this.код_должностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работникиBindingSource, "код должности", true));
            this.код_должностиTextBox.Location = new System.Drawing.Point(921, 843);
            this.код_должностиTextBox.Name = "код_должностиTextBox";
            this.код_должностиTextBox.Size = new System.Drawing.Size(200, 26);
            this.код_должностиTextBox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 74);
            this.button1.TabIndex = 36;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // работникиDataGridView
            // 
            this.работникиDataGridView.AutoGenerateColumns = false;
            this.работникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.работникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.работникиDataGridView.DataSource = this.работникиBindingSource;
            this.работникиDataGridView.Location = new System.Drawing.Point(0, 34);
            this.работникиDataGridView.Name = "работникиDataGridView";
            this.работникиDataGridView.RowHeadersWidth = 62;
            this.работникиDataGridView.RowTemplate.Height = 28;
            this.работникиDataGridView.Size = new System.Drawing.Size(1550, 412);
            this.работникиDataGridView.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "код работника";
            this.dataGridViewTextBoxColumn1.HeaderText = "код работника";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО Работника";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО Работника";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "адрес";
            this.dataGridViewTextBoxColumn3.HeaderText = "адрес";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "телефон";
            this.dataGridViewTextBoxColumn4.HeaderText = "телефон";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "дата рождение";
            this.dataGridViewTextBoxColumn5.HeaderText = "дата рождение";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "дата поступление";
            this.dataGridViewTextBoxColumn6.HeaderText = "дата поступление";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "национальность";
            this.dataGridViewTextBoxColumn7.HeaderText = "национальность";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "пол";
            this.dataGridViewTextBoxColumn8.HeaderText = "пол";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "категория";
            this.dataGridViewTextBoxColumn9.HeaderText = "категория";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "признак военнообязанности";
            this.dataGridViewTextBoxColumn10.HeaderText = "признак военнообязанности";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "код должности";
            this.dataGridViewTextBoxColumn11.HeaderText = "код должности";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "кол-во детей";
            this.dataGridViewTextBoxColumn12.HeaderText = "кол-во детей";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "код цеха";
            this.dataGridViewTextBoxColumn13.HeaderText = "код цеха";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "код учетно специальности";
            this.dataGridViewTextBoxColumn14.HeaderText = "код учетно специальности";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "таб номер";
            this.dataGridViewTextBoxColumn15.HeaderText = "таб номер";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "рнн";
            this.dataGridViewTextBoxColumn16.HeaderText = "рнн";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "сик";
            this.dataGridViewTextBoxColumn17.HeaderText = "сик";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 889);
            this.Controls.Add(this.работникиDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_работникаLabel);
            this.Controls.Add(this.код_работникаTextBox);
            this.Controls.Add(фИО_РаботникаLabel);
            this.Controls.Add(this.фИО_РаботникаTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(дата_рождениеLabel);
            this.Controls.Add(this.дата_рождениеDateTimePicker);
            this.Controls.Add(дата_поступлениеLabel);
            this.Controls.Add(this.дата_поступлениеDateTimePicker);
            this.Controls.Add(национальностьLabel);
            this.Controls.Add(this.национальностьTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(категорияLabel);
            this.Controls.Add(this.категорияTextBox);
            this.Controls.Add(признак_военнообязанностиLabel);
            this.Controls.Add(this.признак_военнообязанностиTextBox);
            this.Controls.Add(код_должностиLabel);
            this.Controls.Add(this.код_должностиTextBox);
            this.Controls.Add(this.работникиBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingNavigator)).EndInit();
            this.работникиBindingNavigator.ResumeLayout(false);
            this.работникиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.работникиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource работникиBindingSource;
        private DataSet1TableAdapters.РаботникиTableAdapter работникиTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator работникиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton работникиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_работникаTextBox;
        private System.Windows.Forms.TextBox фИО_РаботникаTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.DateTimePicker дата_рождениеDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_поступлениеDateTimePicker;
        private System.Windows.Forms.TextBox национальностьTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox категорияTextBox;
        private System.Windows.Forms.TextBox признак_военнообязанностиTextBox;
        private System.Windows.Forms.TextBox код_должностиTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView работникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}

