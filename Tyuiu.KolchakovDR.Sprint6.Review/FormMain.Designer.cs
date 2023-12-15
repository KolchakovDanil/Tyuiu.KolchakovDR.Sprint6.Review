
namespace Tyuiu.KolchakovDR.Sprint6.Review
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.saveFileDialogTask_KDR = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTask_KDR = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_KDR = new System.Windows.Forms.ToolTip(this.components);
            this.buttonHelp_KDR = new System.Windows.Forms.Button();
            this.buttonLoadFile_KDR = new System.Windows.Forms.Button();
            this.buttonAddMat_KDR = new System.Windows.Forms.Button();
            this.labelTask_KDR = new System.Windows.Forms.Label();
            this.groupBoxTask_KDR = new System.Windows.Forms.GroupBox();
            this.panelTopTwo_KDR = new System.Windows.Forms.Panel();
            this.panelTopOne_KDR = new System.Windows.Forms.Panel();
            this.panelLeft_KDR = new System.Windows.Forms.Panel();
            this.groupBoKL_KDR = new System.Windows.Forms.GroupBox();
            this.labelC_KDR = new System.Windows.Forms.Label();
            this.textBoxC_KDR = new System.Windows.Forms.TextBox();
            this.textBoxL_KDR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxK_KDR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRow_KDR = new System.Windows.Forms.Label();
            this.textBoxColu_KDR = new System.Windows.Forms.TextBox();
            this.textBoxRow_KDR = new System.Windows.Forms.TextBox();
            this.groupBoxN1N2_KDR = new System.Windows.Forms.GroupBox();
            this.textBoxDo_KDR = new System.Windows.Forms.TextBox();
            this.labelDo_KDR = new System.Windows.Forms.Label();
            this.labelOt_KDR = new System.Windows.Forms.Label();
            this.textBoxOt_KDR = new System.Windows.Forms.TextBox();
            this.splitterL_KDR = new System.Windows.Forms.Splitter();
            this.panelFill_KDR = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_KDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_KDR = new System.Windows.Forms.DataGridView();
            this.textBoxRes_KDR = new System.Windows.Forms.TextBox();
            this.labelRes_KDR = new System.Windows.Forms.Label();
            this.groupBoxTask_KDR.SuspendLayout();
            this.panelTopTwo_KDR.SuspendLayout();
            this.panelTopOne_KDR.SuspendLayout();
            this.panelLeft_KDR.SuspendLayout();
            this.groupBoKL_KDR.SuspendLayout();
            this.groupBoxN1N2_KDR.SuspendLayout();
            this.panelFill_KDR.SuspendLayout();
            this.groupBoxOutputData_KDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KDR)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogTask_KDR
            // 
            this.openFileDialogTask_KDR.FileName = "openFileDialog1";
            // 
            // toolTip_KDR
            // 
            this.toolTip_KDR.IsBalloon = true;
            this.toolTip_KDR.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_KDR
            // 
            this.buttonHelp_KDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KDR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KDR.BackgroundImage")));
            this.buttonHelp_KDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp_KDR.Location = new System.Drawing.Point(712, 3);
            this.buttonHelp_KDR.Name = "buttonHelp_KDR";
            this.buttonHelp_KDR.Size = new System.Drawing.Size(61, 49);
            this.buttonHelp_KDR.TabIndex = 2;
            this.toolTip_KDR.SetToolTip(this.buttonHelp_KDR, "О программе");
            this.buttonHelp_KDR.UseVisualStyleBackColor = true;
            // 
            // buttonLoadFile_KDR
            // 
            this.buttonLoadFile_KDR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLoadFile_KDR.BackgroundImage")));
            this.buttonLoadFile_KDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLoadFile_KDR.Enabled = false;
            this.buttonLoadFile_KDR.Location = new System.Drawing.Point(71, 3);
            this.buttonLoadFile_KDR.Name = "buttonLoadFile_KDR";
            this.buttonLoadFile_KDR.Size = new System.Drawing.Size(61, 49);
            this.buttonLoadFile_KDR.TabIndex = 1;
            this.toolTip_KDR.SetToolTip(this.buttonLoadFile_KDR, "Произвести подсчёт");
            this.buttonLoadFile_KDR.UseVisualStyleBackColor = true;
            this.buttonLoadFile_KDR.Click += new System.EventHandler(this.buttonLoadFile_KDR_Click);
            // 
            // buttonAddMat_KDR
            // 
            this.buttonAddMat_KDR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddMat_KDR.BackgroundImage")));
            this.buttonAddMat_KDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddMat_KDR.Location = new System.Drawing.Point(8, 3);
            this.buttonAddMat_KDR.Name = "buttonAddMat_KDR";
            this.buttonAddMat_KDR.Size = new System.Drawing.Size(57, 49);
            this.buttonAddMat_KDR.TabIndex = 0;
            this.toolTip_KDR.SetToolTip(this.buttonAddMat_KDR, "Создать матрицу");
            this.buttonAddMat_KDR.UseVisualStyleBackColor = true;
            this.buttonAddMat_KDR.Click += new System.EventHandler(this.buttonAddMat_KDR_Click);
            // 
            // labelTask_KDR
            // 
            this.labelTask_KDR.AutoSize = true;
            this.labelTask_KDR.Location = new System.Drawing.Point(13, 15);
            this.labelTask_KDR.Name = "labelTask_KDR";
            this.labelTask_KDR.Padding = new System.Windows.Forms.Padding(5);
            this.labelTask_KDR.Size = new System.Drawing.Size(726, 49);
            this.labelTask_KDR.TabIndex = 2;
            this.labelTask_KDR.Text = resources.GetString("labelTask_KDR.Text");
            // 
            // groupBoxTask_KDR
            // 
            this.groupBoxTask_KDR.Controls.Add(this.labelTask_KDR);
            this.groupBoxTask_KDR.Location = new System.Drawing.Point(3, 2);
            this.groupBoxTask_KDR.Name = "groupBoxTask_KDR";
            this.groupBoxTask_KDR.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxTask_KDR.Size = new System.Drawing.Size(769, 72);
            this.groupBoxTask_KDR.TabIndex = 17;
            this.groupBoxTask_KDR.TabStop = false;
            this.groupBoxTask_KDR.Text = "Условие";
            // 
            // panelTopTwo_KDR
            // 
            this.panelTopTwo_KDR.Controls.Add(this.groupBoxTask_KDR);
            this.panelTopTwo_KDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTwo_KDR.Location = new System.Drawing.Point(0, 58);
            this.panelTopTwo_KDR.Name = "panelTopTwo_KDR";
            this.panelTopTwo_KDR.Size = new System.Drawing.Size(784, 77);
            this.panelTopTwo_KDR.TabIndex = 12;
            // 
            // panelTopOne_KDR
            // 
            this.panelTopOne_KDR.Controls.Add(this.buttonHelp_KDR);
            this.panelTopOne_KDR.Controls.Add(this.buttonLoadFile_KDR);
            this.panelTopOne_KDR.Controls.Add(this.buttonAddMat_KDR);
            this.panelTopOne_KDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopOne_KDR.Location = new System.Drawing.Point(0, 0);
            this.panelTopOne_KDR.Name = "panelTopOne_KDR";
            this.panelTopOne_KDR.Size = new System.Drawing.Size(784, 58);
            this.panelTopOne_KDR.TabIndex = 11;
            // 
            // panelLeft_KDR
            // 
            this.panelLeft_KDR.Controls.Add(this.labelRes_KDR);
            this.panelLeft_KDR.Controls.Add(this.textBoxRes_KDR);
            this.panelLeft_KDR.Controls.Add(this.groupBoKL_KDR);
            this.panelLeft_KDR.Controls.Add(this.label1);
            this.panelLeft_KDR.Controls.Add(this.labelRow_KDR);
            this.panelLeft_KDR.Controls.Add(this.textBoxColu_KDR);
            this.panelLeft_KDR.Controls.Add(this.textBoxRow_KDR);
            this.panelLeft_KDR.Controls.Add(this.groupBoxN1N2_KDR);
            this.panelLeft_KDR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KDR.Location = new System.Drawing.Point(0, 135);
            this.panelLeft_KDR.Name = "panelLeft_KDR";
            this.panelLeft_KDR.Size = new System.Drawing.Size(312, 324);
            this.panelLeft_KDR.TabIndex = 13;
            // 
            // groupBoKL_KDR
            // 
            this.groupBoKL_KDR.Controls.Add(this.labelC_KDR);
            this.groupBoKL_KDR.Controls.Add(this.textBoxC_KDR);
            this.groupBoKL_KDR.Controls.Add(this.textBoxL_KDR);
            this.groupBoKL_KDR.Controls.Add(this.label2);
            this.groupBoKL_KDR.Controls.Add(this.label3);
            this.groupBoKL_KDR.Controls.Add(this.textBoxK_KDR);
            this.groupBoKL_KDR.Location = new System.Drawing.Point(8, 134);
            this.groupBoKL_KDR.Name = "groupBoKL_KDR";
            this.groupBoKL_KDR.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBoKL_KDR.Size = new System.Drawing.Size(298, 130);
            this.groupBoKL_KDR.TabIndex = 24;
            this.groupBoKL_KDR.TabStop = false;
            this.groupBoKL_KDR.Text = "Диапозон элементов расчёта:";
            // 
            // labelC_KDR
            // 
            this.labelC_KDR.AutoSize = true;
            this.labelC_KDR.Location = new System.Drawing.Point(8, 74);
            this.labelC_KDR.Name = "labelC_KDR";
            this.labelC_KDR.Size = new System.Drawing.Size(64, 13);
            this.labelC_KDR.TabIndex = 25;
            this.labelC_KDR.Text = "Столбец(с):";
            // 
            // textBoxC_KDR
            // 
            this.textBoxC_KDR.Enabled = false;
            this.textBoxC_KDR.Location = new System.Drawing.Point(11, 90);
            this.textBoxC_KDR.Name = "textBoxC_KDR";
            this.textBoxC_KDR.Size = new System.Drawing.Size(100, 20);
            this.textBoxC_KDR.TabIndex = 25;
            // 
            // textBoxL_KDR
            // 
            this.textBoxL_KDR.Enabled = false;
            this.textBoxL_KDR.Location = new System.Drawing.Point(173, 32);
            this.textBoxL_KDR.Name = "textBoxL_KDR";
            this.textBoxL_KDR.Size = new System.Drawing.Size(79, 20);
            this.textBoxL_KDR.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "До(l):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "От(k):";
            // 
            // textBoxK_KDR
            // 
            this.textBoxK_KDR.Enabled = false;
            this.textBoxK_KDR.Location = new System.Drawing.Point(11, 32);
            this.textBoxK_KDR.Name = "textBoxK_KDR";
            this.textBoxK_KDR.Size = new System.Drawing.Size(79, 20);
            this.textBoxK_KDR.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Столбцы:";
            // 
            // labelRow_KDR
            // 
            this.labelRow_KDR.AutoSize = true;
            this.labelRow_KDR.Location = new System.Drawing.Point(9, 13);
            this.labelRow_KDR.Name = "labelRow_KDR";
            this.labelRow_KDR.Size = new System.Drawing.Size(46, 13);
            this.labelRow_KDR.TabIndex = 2;
            this.labelRow_KDR.Text = "Строки:";
            // 
            // textBoxColu_KDR
            // 
            this.textBoxColu_KDR.Location = new System.Drawing.Point(181, 29);
            this.textBoxColu_KDR.Name = "textBoxColu_KDR";
            this.textBoxColu_KDR.Size = new System.Drawing.Size(100, 20);
            this.textBoxColu_KDR.TabIndex = 1;
            // 
            // textBoxRow_KDR
            // 
            this.textBoxRow_KDR.Location = new System.Drawing.Point(12, 29);
            this.textBoxRow_KDR.Name = "textBoxRow_KDR";
            this.textBoxRow_KDR.Size = new System.Drawing.Size(100, 20);
            this.textBoxRow_KDR.TabIndex = 0;
            // 
            // groupBoxN1N2_KDR
            // 
            this.groupBoxN1N2_KDR.Controls.Add(this.textBoxDo_KDR);
            this.groupBoxN1N2_KDR.Controls.Add(this.labelDo_KDR);
            this.groupBoxN1N2_KDR.Controls.Add(this.labelOt_KDR);
            this.groupBoxN1N2_KDR.Controls.Add(this.textBoxOt_KDR);
            this.groupBoxN1N2_KDR.Location = new System.Drawing.Point(8, 60);
            this.groupBoxN1N2_KDR.Name = "groupBoxN1N2_KDR";
            this.groupBoxN1N2_KDR.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBoxN1N2_KDR.Size = new System.Drawing.Size(298, 68);
            this.groupBoxN1N2_KDR.TabIndex = 20;
            this.groupBoxN1N2_KDR.TabStop = false;
            this.groupBoxN1N2_KDR.Text = "Диапозон значений массива:";
            // 
            // textBoxDo_KDR
            // 
            this.textBoxDo_KDR.Location = new System.Drawing.Point(173, 32);
            this.textBoxDo_KDR.Name = "textBoxDo_KDR";
            this.textBoxDo_KDR.Size = new System.Drawing.Size(79, 20);
            this.textBoxDo_KDR.TabIndex = 23;
            // 
            // labelDo_KDR
            // 
            this.labelDo_KDR.AutoSize = true;
            this.labelDo_KDR.Location = new System.Drawing.Point(170, 16);
            this.labelDo_KDR.Name = "labelDo_KDR";
            this.labelDo_KDR.Size = new System.Drawing.Size(43, 13);
            this.labelDo_KDR.TabIndex = 22;
            this.labelDo_KDR.Text = "До(n2):";
            // 
            // labelOt_KDR
            // 
            this.labelOt_KDR.AutoSize = true;
            this.labelOt_KDR.Location = new System.Drawing.Point(8, 16);
            this.labelOt_KDR.Name = "labelOt_KDR";
            this.labelOt_KDR.Size = new System.Drawing.Size(41, 13);
            this.labelOt_KDR.TabIndex = 21;
            this.labelOt_KDR.Text = "От(n1):";
            // 
            // textBoxOt_KDR
            // 
            this.textBoxOt_KDR.Location = new System.Drawing.Point(11, 32);
            this.textBoxOt_KDR.Name = "textBoxOt_KDR";
            this.textBoxOt_KDR.Size = new System.Drawing.Size(79, 20);
            this.textBoxOt_KDR.TabIndex = 4;
            // 
            // splitterL_KDR
            // 
            this.splitterL_KDR.Location = new System.Drawing.Point(312, 135);
            this.splitterL_KDR.Name = "splitterL_KDR";
            this.splitterL_KDR.Size = new System.Drawing.Size(5, 324);
            this.splitterL_KDR.TabIndex = 14;
            this.splitterL_KDR.TabStop = false;
            // 
            // panelFill_KDR
            // 
            this.panelFill_KDR.Controls.Add(this.groupBoxOutputData_KDR);
            this.panelFill_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_KDR.Location = new System.Drawing.Point(317, 135);
            this.panelFill_KDR.Name = "panelFill_KDR";
            this.panelFill_KDR.Size = new System.Drawing.Size(467, 324);
            this.panelFill_KDR.TabIndex = 15;
            // 
            // groupBoxOutputData_KDR
            // 
            this.groupBoxOutputData_KDR.Controls.Add(this.dataGridViewOut_KDR);
            this.groupBoxOutputData_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_KDR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_KDR.Name = "groupBoxOutputData_KDR";
            this.groupBoxOutputData_KDR.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBoxOutputData_KDR.Size = new System.Drawing.Size(467, 324);
            this.groupBoxOutputData_KDR.TabIndex = 19;
            this.groupBoxOutputData_KDR.TabStop = false;
            this.groupBoxOutputData_KDR.Text = "Вывод данных:";
            // 
            // dataGridViewOut_KDR
            // 
            this.dataGridViewOut_KDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_KDR.ColumnHeadersVisible = false;
            this.dataGridViewOut_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_KDR.Location = new System.Drawing.Point(5, 16);
            this.dataGridViewOut_KDR.Name = "dataGridViewOut_KDR";
            this.dataGridViewOut_KDR.RowHeadersVisible = false;
            this.dataGridViewOut_KDR.Size = new System.Drawing.Size(457, 305);
            this.dataGridViewOut_KDR.TabIndex = 1;
            // 
            // textBoxRes_KDR
            // 
            this.textBoxRes_KDR.Enabled = false;
            this.textBoxRes_KDR.Location = new System.Drawing.Point(12, 290);
            this.textBoxRes_KDR.Name = "textBoxRes_KDR";
            this.textBoxRes_KDR.ReadOnly = true;
            this.textBoxRes_KDR.Size = new System.Drawing.Size(220, 20);
            this.textBoxRes_KDR.TabIndex = 26;
            // 
            // labelRes_KDR
            // 
            this.labelRes_KDR.AutoSize = true;
            this.labelRes_KDR.Location = new System.Drawing.Point(9, 274);
            this.labelRes_KDR.Name = "labelRes_KDR";
            this.labelRes_KDR.Size = new System.Drawing.Size(288, 13);
            this.labelRes_KDR.TabIndex = 26;
            this.labelRes_KDR.Text = "Произведение нечётных элементов массива (от k до l):";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.panelFill_KDR);
            this.Controls.Add(this.splitterL_KDR);
            this.Controls.Add(this.panelLeft_KDR);
            this.Controls.Add(this.panelTopTwo_KDR);
            this.Controls.Add(this.panelTopOne_KDR);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | ТаскРевью | Вариант 6 | Колчаков Д. Р.";
            this.groupBoxTask_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.PerformLayout();
            this.panelTopTwo_KDR.ResumeLayout(false);
            this.panelTopOne_KDR.ResumeLayout(false);
            this.panelLeft_KDR.ResumeLayout(false);
            this.panelLeft_KDR.PerformLayout();
            this.groupBoKL_KDR.ResumeLayout(false);
            this.groupBoKL_KDR.PerformLayout();
            this.groupBoxN1N2_KDR.ResumeLayout(false);
            this.groupBoxN1N2_KDR.PerformLayout();
            this.panelFill_KDR.ResumeLayout(false);
            this.groupBoxOutputData_KDR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_KDR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KDR;
        private System.Windows.Forms.ToolTip toolTip_KDR;
        private System.Windows.Forms.Button buttonHelp_KDR;
        private System.Windows.Forms.Button buttonLoadFile_KDR;
        private System.Windows.Forms.Button buttonAddMat_KDR;
        private System.Windows.Forms.Label labelTask_KDR;
        private System.Windows.Forms.GroupBox groupBoxTask_KDR;
        private System.Windows.Forms.Panel panelTopTwo_KDR;
        private System.Windows.Forms.Panel panelTopOne_KDR;
        private System.Windows.Forms.Panel panelLeft_KDR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRow_KDR;
        private System.Windows.Forms.TextBox textBoxColu_KDR;
        private System.Windows.Forms.TextBox textBoxRow_KDR;
        private System.Windows.Forms.Splitter splitterL_KDR;
        private System.Windows.Forms.Panel panelFill_KDR;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KDR;
        private System.Windows.Forms.DataGridView dataGridViewOut_KDR;
        private System.Windows.Forms.GroupBox groupBoxN1N2_KDR;
        private System.Windows.Forms.TextBox textBoxDo_KDR;
        private System.Windows.Forms.Label labelDo_KDR;
        private System.Windows.Forms.Label labelOt_KDR;
        private System.Windows.Forms.TextBox textBoxOt_KDR;
        private System.Windows.Forms.GroupBox groupBoKL_KDR;
        private System.Windows.Forms.TextBox textBoxL_KDR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxK_KDR;
        private System.Windows.Forms.Label labelC_KDR;
        private System.Windows.Forms.TextBox textBoxC_KDR;
        private System.Windows.Forms.Label labelRes_KDR;
        private System.Windows.Forms.TextBox textBoxRes_KDR;
    }
}

