namespace 绿色通道人数统计
{
    partial class MainForm
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
            this.groupBoxBarForm = new System.Windows.Forms.GroupBox();
            this.buttonQuitFullScreen = new System.Windows.Forms.Button();
            this.buttonFullScreen = new System.Windows.Forms.Button();
            this.buttonBarGraphGenerate = new System.Windows.Forms.Button();
            this.groupBoxDataControl = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxBarForm.SuspendLayout();
            this.groupBoxDataControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBarForm
            // 
            this.groupBoxBarForm.Controls.Add(this.buttonQuitFullScreen);
            this.groupBoxBarForm.Controls.Add(this.buttonFullScreen);
            this.groupBoxBarForm.Controls.Add(this.buttonBarGraphGenerate);
            this.groupBoxBarForm.Location = new System.Drawing.Point(445, 95);
            this.groupBoxBarForm.Name = "groupBoxBarForm";
            this.groupBoxBarForm.Size = new System.Drawing.Size(195, 176);
            this.groupBoxBarForm.TabIndex = 0;
            this.groupBoxBarForm.TabStop = false;
            this.groupBoxBarForm.Text = "柱状图界面操作";
            // 
            // buttonQuitFullScreen
            // 
            this.buttonQuitFullScreen.Location = new System.Drawing.Point(42, 126);
            this.buttonQuitFullScreen.Name = "buttonQuitFullScreen";
            this.buttonQuitFullScreen.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitFullScreen.TabIndex = 2;
            this.buttonQuitFullScreen.Text = "退出全屏";
            this.buttonQuitFullScreen.UseVisualStyleBackColor = true;
            this.buttonQuitFullScreen.Click += new System.EventHandler(this.buttonQuitFullScreen_Click);
            // 
            // buttonFullScreen
            // 
            this.buttonFullScreen.Location = new System.Drawing.Point(42, 78);
            this.buttonFullScreen.Name = "buttonFullScreen";
            this.buttonFullScreen.Size = new System.Drawing.Size(75, 23);
            this.buttonFullScreen.TabIndex = 1;
            this.buttonFullScreen.Text = "全屏显示";
            this.buttonFullScreen.UseVisualStyleBackColor = true;
            this.buttonFullScreen.Click += new System.EventHandler(this.buttonFullScreen_Click);
            // 
            // buttonBarGraphGenerate
            // 
            this.buttonBarGraphGenerate.Location = new System.Drawing.Point(42, 34);
            this.buttonBarGraphGenerate.Name = "buttonBarGraphGenerate";
            this.buttonBarGraphGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonBarGraphGenerate.TabIndex = 0;
            this.buttonBarGraphGenerate.Text = "生成柱状图";
            this.buttonBarGraphGenerate.UseVisualStyleBackColor = true;
            this.buttonBarGraphGenerate.Click += new System.EventHandler(this.buttonBarGraphGenerate_Click);
            // 
            // groupBoxDataControl
            // 
            this.groupBoxDataControl.Controls.Add(this.label9);
            this.groupBoxDataControl.Controls.Add(this.numericUpDown9);
            this.groupBoxDataControl.Controls.Add(this.label8);
            this.groupBoxDataControl.Controls.Add(this.numericUpDown8);
            this.groupBoxDataControl.Controls.Add(this.label7);
            this.groupBoxDataControl.Controls.Add(this.numericUpDown7);
            this.groupBoxDataControl.Controls.Add(this.numericUpDown2);
            this.groupBoxDataControl.Controls.Add(this.numericUpDown6);
            this.groupBoxDataControl.Controls.Add(this.numericUpDown5);
            this.groupBoxDataControl.Controls.Add(this.numericUpDown4);
            this.groupBoxDataControl.Controls.Add(this.numericUpDown3);
            this.groupBoxDataControl.Controls.Add(this.numericUpDown1);
            this.groupBoxDataControl.Controls.Add(this.label2);
            this.groupBoxDataControl.Controls.Add(this.label6);
            this.groupBoxDataControl.Controls.Add(this.label5);
            this.groupBoxDataControl.Controls.Add(this.label4);
            this.groupBoxDataControl.Controls.Add(this.label3);
            this.groupBoxDataControl.Controls.Add(this.label1);
            this.groupBoxDataControl.Location = new System.Drawing.Point(99, 95);
            this.groupBoxDataControl.Name = "groupBoxDataControl";
            this.groupBoxDataControl.Size = new System.Drawing.Size(255, 260);
            this.groupBoxDataControl.TabIndex = 1;
            this.groupBoxDataControl.TabStop = false;
            this.groupBoxDataControl.Text = "数据统计(上下键控制数量，Tab键切换选项)";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(68, 64);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 21);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(68, 209);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(77, 21);
            this.numericUpDown6.TabIndex = 8;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(68, 175);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(77, 21);
            this.numericUpDown5.TabIndex = 7;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(68, 138);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(77, 21);
            this.numericUpDown4.TabIndex = 6;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(68, 100);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(77, 21);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 21);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Tag = "";
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "绿色通道";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "小礼包";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "大礼包";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "缓交学费";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "受灾地区";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "贫困专项";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(199, 32);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown7.TabIndex = 9;
            this.numericUpDown7.TabStop = false;
            this.numericUpDown7.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "上限";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(199, 64);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown8.TabIndex = 9;
            this.numericUpDown8.TabStop = false;
            this.numericUpDown8.Value = new decimal(new int[] {
            93,
            0,
            0,
            0});
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "上限";
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(199, 98);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown9.TabIndex = 9;
            this.numericUpDown9.TabStop = false;
            this.numericUpDown9.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown9.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "上限";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 471);
            this.Controls.Add(this.groupBoxDataControl);
            this.Controls.Add(this.groupBoxBarForm);
            this.Name = "MainForm";
            this.Text = "绿色通道人数统计系统";
            this.groupBoxBarForm.ResumeLayout(false);
            this.groupBoxDataControl.ResumeLayout(false);
            this.groupBoxDataControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBarForm;
        private System.Windows.Forms.GroupBox groupBoxDataControl;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuitFullScreen;
        private System.Windows.Forms.Button buttonFullScreen;
        private System.Windows.Forms.Button buttonBarGraphGenerate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
    }
}

