namespace Laba1;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        panel2 = new Panel();
        tableLayoutPanel1 = new TableLayoutPanel();
        label_laboratory_work = new Label();
        label_variant = new Label();
        label_name = new Label();
        label_group = new Label();
        button_next = new Button();
        tableLayoutPanel2 = new TableLayoutPanel();
        tableLayoutPanel4 = new TableLayoutPanel();
        button_show = new Button();
        processMonthButton = new Button();
        panel3 = new Panel();
        numericUpDown_employeeCount = new NumericUpDown();
        numericUpDown_tariff = new NumericUpDown();
        numericUpDown_balance = new NumericUpDown();
        numericUpDown_paidResidentsCount = new NumericUpDown();
        textBox_residentHouseNum = new TextBox();
        textBox_residentName = new TextBox();
        numericUpDown_housingDepartmentNumber = new NumericUpDown();
        textBox_district = new TextBox();
        tableLayoutPanel3 = new TableLayoutPanel();
        button_exit = new Button();
        button_prev = new Button();
        label_saved_status = new Label();
        label_output_info = new Label();
        label_show_info = new Label();
        label_change_info = new Label();
        comboBox_fields = new ComboBox();
        button_save = new Button();
        panel_delimiter = new Panel();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_employeeCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_tariff).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_balance).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_paidResidentsCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_housingDepartmentNumber).BeginInit();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(panel2);
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Location = new Point(12, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(486, 391);
        panel1.TabIndex = 26;
        // 
        // panel2
        // 
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(548, 653);
        panel2.TabIndex = 29;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.Anchor = AnchorStyles.None;
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(label_laboratory_work, 0, 0);
        tableLayoutPanel1.Controls.Add(label_variant, 0, 1);
        tableLayoutPanel1.Controls.Add(label_name, 0, 2);
        tableLayoutPanel1.Controls.Add(label_group, 0, 3);
        tableLayoutPanel1.Controls.Add(button_next, 0, 4);
        tableLayoutPanel1.Location = new Point(3, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.Size = new Size(480, 385);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // label_laboratory_work
        // 
        label_laboratory_work.Anchor = AnchorStyles.Top;
        label_laboratory_work.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label_laboratory_work.Location = new Point(75, 0);
        label_laboratory_work.Name = "label_laboratory_work";
        label_laboratory_work.Size = new Size(330, 59);
        label_laboratory_work.TabIndex = 1;
        label_laboratory_work.Text = "Лабораторная работа 4";
        label_laboratory_work.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label_variant
        // 
        label_variant.Anchor = AnchorStyles.Top;
        label_variant.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label_variant.Location = new Point(103, 77);
        label_variant.Name = "label_variant";
        label_variant.Size = new Size(273, 59);
        label_variant.TabIndex = 3;
        label_variant.Text = "Вариант 4 - ЖЭК";
        label_variant.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label_name
        // 
        label_name.Anchor = AnchorStyles.Top;
        label_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label_name.Location = new Point(36, 154);
        label_name.Name = "label_name";
        label_name.Size = new Size(407, 59);
        label_name.TabIndex = 4;
        label_name.Text = "Выполнили: Федоров, Фомин";
        label_name.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label_group
        // 
        label_group.Anchor = AnchorStyles.Top;
        label_group.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label_group.Location = new Point(70, 231);
        label_group.Name = "label_group";
        label_group.Size = new Size(340, 59);
        label_group.TabIndex = 5;
        label_group.Text = "Группа 24ВП1";
        label_group.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // button_next
        // 
        button_next.Anchor = AnchorStyles.Top;
        button_next.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button_next.Location = new Point(161, 311);
        button_next.Name = "button_next";
        button_next.Size = new Size(157, 71);
        button_next.TabIndex = 9;
        button_next.Text = "Далее";
        button_next.UseVisualStyleBackColor = true;
        button_next.Click += button_next_Click;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
        tableLayoutPanel2.Controls.Add(panel3, 0, 6);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 8);
        tableLayoutPanel2.Controls.Add(label_output_info, 0, 0);
        tableLayoutPanel2.Controls.Add(label_show_info, 0, 1);
        tableLayoutPanel2.Controls.Add(label_change_info, 0, 4);
        tableLayoutPanel2.Controls.Add(comboBox_fields, 0, 5);
        tableLayoutPanel2.Controls.Add(button_save, 0, 7);
        tableLayoutPanel2.Controls.Add(panel_delimiter, 0, 3);
        tableLayoutPanel2.Location = new Point(34, 15);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 9;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.88413239F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1723747F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4675245F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.64605856F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.47295213F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.624043F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.884133F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.884133F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.884133F));
        tableLayoutPanel2.Size = new Size(542, 647);
        tableLayoutPanel2.TabIndex = 27;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
        tableLayoutPanel4.Controls.Add(button_show, 0, 0);
        tableLayoutPanel4.Controls.Add(processMonthButton, 1, 0);
        tableLayoutPanel4.Location = new Point(3, 358);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new Size(536, 39);
        tableLayoutPanel4.TabIndex = 28;
        // 
        // button_show
        // 
        button_show.Anchor = AnchorStyles.Top;
        button_show.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        button_show.Location = new Point(3, 3);
        button_show.Name = "button_show";
        button_show.Size = new Size(291, 33);
        button_show.TabIndex = 10;
        button_show.Text = "Показать информацию";
        button_show.UseVisualStyleBackColor = true;
        button_show.Click += button_show_Click;
        // 
        // processMonthButton
        // 
        processMonthButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        processMonthButton.Location = new Point(300, 3);
        processMonthButton.Name = "processMonthButton";
        processMonthButton.Size = new Size(233, 33);
        processMonthButton.TabIndex = 11;
        processMonthButton.Text = "Обработать месяц";
        processMonthButton.UseVisualStyleBackColor = true;
        processMonthButton.Click += OnProcessClick;
        // 
        // panel3
        // 
        panel3.Controls.Add(numericUpDown_employeeCount);
        panel3.Controls.Add(numericUpDown_tariff);
        panel3.Controls.Add(numericUpDown_balance);
        panel3.Controls.Add(numericUpDown_paidResidentsCount);
        panel3.Controls.Add(textBox_residentHouseNum);
        panel3.Controls.Add(textBox_residentName);
        panel3.Controls.Add(numericUpDown_housingDepartmentNumber);
        panel3.Controls.Add(textBox_district);
        panel3.Location = new Point(3, 516);
        panel3.Name = "panel3";
        panel3.Size = new Size(533, 37);
        panel3.TabIndex = 24;
        // 
        // numericUpDown_employeeCount
        // 
        numericUpDown_employeeCount.Location = new Point(3, 3);
        numericUpDown_employeeCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numericUpDown_employeeCount.Name = "numericUpDown_employeeCount";
        numericUpDown_employeeCount.Size = new Size(527, 27);
        numericUpDown_employeeCount.TabIndex = 24;
        // 
        // numericUpDown_tariff
        // 
        numericUpDown_tariff.DecimalPlaces = 2;
        numericUpDown_tariff.Location = new Point(3, 3);
        numericUpDown_tariff.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numericUpDown_tariff.Name = "numericUpDown_tariff";
        numericUpDown_tariff.Size = new Size(527, 27);
        numericUpDown_tariff.TabIndex = 24;
        // 
        // numericUpDown_balance
        // 
        numericUpDown_balance.DecimalPlaces = 2;
        numericUpDown_balance.Location = new Point(3, 3);
        numericUpDown_balance.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numericUpDown_balance.Name = "numericUpDown_balance";
        numericUpDown_balance.Size = new Size(527, 27);
        numericUpDown_balance.TabIndex = 24;
        // 
        // numericUpDown_paidResidentsCount
        // 
        numericUpDown_paidResidentsCount.Location = new Point(3, 4);
        numericUpDown_paidResidentsCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numericUpDown_paidResidentsCount.Name = "numericUpDown_paidResidentsCount";
        numericUpDown_paidResidentsCount.Size = new Size(527, 27);
        numericUpDown_paidResidentsCount.TabIndex = 24;
        // 
        // textBox_residentHouseNum
        // 
        textBox_residentHouseNum.Location = new Point(377, 3);
        textBox_residentHouseNum.Name = "textBox_residentHouseNum";
        textBox_residentHouseNum.Size = new Size(153, 27);
        textBox_residentHouseNum.TabIndex = 24;
        // 
        // textBox_residentName
        // 
        textBox_residentName.Location = new Point(3, 3);
        textBox_residentName.Name = "textBox_residentName";
        textBox_residentName.Size = new Size(368, 27);
        textBox_residentName.TabIndex = 23;
        // 
        // numericUpDown_housingDepartmentNumber
        // 
        numericUpDown_housingDepartmentNumber.Location = new Point(3, 4);
        numericUpDown_housingDepartmentNumber.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numericUpDown_housingDepartmentNumber.Name = "numericUpDown_housingDepartmentNumber";
        numericUpDown_housingDepartmentNumber.Size = new Size(527, 27);
        numericUpDown_housingDepartmentNumber.TabIndex = 22;
        // 
        // textBox_district
        // 
        textBox_district.Location = new Point(3, 3);
        textBox_district.Name = "textBox_district";
        textBox_district.Size = new Size(527, 27);
        textBox_district.TabIndex = 21;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 3;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel3.Controls.Add(button_exit, 2, 0);
        tableLayoutPanel3.Controls.Add(button_prev, 0, 0);
        tableLayoutPanel3.Controls.Add(label_saved_status, 1, 0);
        tableLayoutPanel3.Location = new Point(3, 602);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new Size(536, 41);
        tableLayoutPanel3.TabIndex = 24;
        // 
        // button_exit
        // 
        button_exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button_exit.Location = new Point(359, 3);
        button_exit.Name = "button_exit";
        button_exit.Size = new Size(174, 35);
        button_exit.TabIndex = 13;
        button_exit.Text = "Выход";
        button_exit.UseVisualStyleBackColor = true;
        button_exit.Click += button_exit_Click;
        // 
        // button_prev
        // 
        button_prev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button_prev.Location = new Point(3, 3);
        button_prev.Name = "button_prev";
        button_prev.Size = new Size(172, 35);
        button_prev.TabIndex = 12;
        button_prev.Text = "<<< Назад";
        button_prev.UseVisualStyleBackColor = true;
        button_prev.Click += button_prev_Click;
        // 
        // label_saved_status
        // 
        label_saved_status.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label_saved_status.ForeColor = Color.FromArgb(0, 192, 0);
        label_saved_status.Location = new Point(181, 0);
        label_saved_status.Name = "label_saved_status";
        label_saved_status.Size = new Size(172, 41);
        label_saved_status.TabIndex = 7;
        label_saved_status.Text = "Сохранено!";
        label_saved_status.TextAlign = ContentAlignment.MiddleCenter;
        label_saved_status.Visible = false;
        // 
        // label_output_info
        // 
        label_output_info.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label_output_info.Location = new Point(3, 0);
        label_output_info.Name = "label_output_info";
        label_output_info.Size = new Size(536, 43);
        label_output_info.TabIndex = 0;
        label_output_info.Text = "Вывод информации";
        label_output_info.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label_show_info
        // 
        label_show_info.Anchor = AnchorStyles.Top;
        label_show_info.BackColor = SystemColors.ControlLight;
        label_show_info.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label_show_info.Location = new Point(61, 43);
        label_show_info.Name = "label_show_info";
        label_show_info.Size = new Size(420, 309);
        label_show_info.TabIndex = 2;
        // 
        // label_change_info
        // 
        label_change_info.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label_change_info.Location = new Point(3, 463);
        label_change_info.Name = "label_change_info";
        label_change_info.Size = new Size(536, 15);
        label_change_info.TabIndex = 6;
        label_change_info.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // comboBox_fields
        // 
        comboBox_fields.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox_fields.FormattingEnabled = true;
        comboBox_fields.Items.AddRange(new object[] { "Район", "Номер ЖЭК'a", "Резиденты", "Количество оплативших резидентов", "Тариф", "Баланс", "Количество работников" });
        comboBox_fields.Location = new Point(3, 481);
        comboBox_fields.Name = "comboBox_fields";
        comboBox_fields.Size = new Size(536, 28);
        comboBox_fields.TabIndex = 14;
        comboBox_fields.SelectedIndexChanged += comboBox_fields_SelectedIndexChanged;
        // 
        // button_save
        // 
        button_save.Anchor = AnchorStyles.Top;
        button_save.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button_save.Location = new Point(199, 559);
        button_save.Name = "button_save";
        button_save.Size = new Size(144, 37);
        button_save.TabIndex = 11;
        button_save.Text = "Сохранить";
        button_save.UseVisualStyleBackColor = true;
        button_save.Click += button_save_Click;
        // 
        // panel_delimiter
        // 
        panel_delimiter.BackColor = SystemColors.Desktop;
        panel_delimiter.Location = new Point(3, 424);
        panel_delimiter.Name = "panel_delimiter";
        panel_delimiter.Size = new Size(536, 10);
        panel_delimiter.TabIndex = 8;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(610, 676);
        Controls.Add(tableLayoutPanel2);
        Controls.Add(panel1);
        Location = new Point(19, 19);
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimumSize = new Size(526, 451);
        Name = "Form1";
        Text = "ЖЭК";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_employeeCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_tariff).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_balance).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_paidResidentsCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_housingDepartmentNumber).EndInit();
        tableLayoutPanel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TextBox textBox_residentName;
    private System.Windows.Forms.TextBox textBox_residentHouseNum;
    private System.Windows.Forms.TextBox textBox_district;

    private System.Windows.Forms.NumericUpDown numericUpDown_housingDepartmentNumber;
    private System.Windows.Forms.NumericUpDown numericUpDown_balance;
    private System.Windows.Forms.NumericUpDown numericUpDown_paidResidentsCount;

    private System.Windows.Forms.NumericUpDown numericUpDown_employeeCount;
    private System.Windows.Forms.NumericUpDown numericUpDown_tariff;

    private System.Windows.Forms.ComboBox comboBox_fields;

    private System.Windows.Forms.Button button_exit;

    private System.Windows.Forms.Button button_show;
    private System.Windows.Forms.Button button_save;
    private System.Windows.Forms.Button button_prev;

    private System.Windows.Forms.Button button_next;

    private System.Windows.Forms.Panel panel_delimiter;

    private System.Windows.Forms.Label label_laboratory_work;
    private System.Windows.Forms.Label label_show_info;
    private System.Windows.Forms.Label label_variant;
    private System.Windows.Forms.Label label_name;
    private System.Windows.Forms.Label label_group;
    private System.Windows.Forms.Label label_change_info;
    private System.Windows.Forms.Label label_saved_status;

    private System.Windows.Forms.Label label_output_info;

    #endregion

    private TableLayoutPanel tableLayoutPanel4;
    private Button processMonthButton;
}