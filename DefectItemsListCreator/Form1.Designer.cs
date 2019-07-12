namespace DefectItemsListCreator
{
    partial class Form1
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerText = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imagePathText = new System.Windows.Forms.TextBox();
            this.chooseImagePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationText = new System.Windows.Forms.TextBox();
            this.chooseDescription = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carModelText = new System.Windows.Forms.TextBox();
            this.codeText = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(27, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(46, 13);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "合同号:";
            // 
            // headerText
            // 
            this.headerText.Location = new System.Drawing.Point(79, 7);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(156, 20);
            this.headerText.TabIndex = 1;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(42, 206);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(278, 59);
            this.generate.TabIndex = 9;
            this.generate.Text = "创建文件";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "资料来源:";
            // 
            // imagePathText
            // 
            this.imagePathText.Location = new System.Drawing.Point(79, 122);
            this.imagePathText.Name = "imagePathText";
            this.imagePathText.Size = new System.Drawing.Size(156, 20);
            this.imagePathText.TabIndex = 5;
            // 
            // chooseImagePath
            // 
            this.chooseImagePath.Location = new System.Drawing.Point(241, 119);
            this.chooseImagePath.Name = "chooseImagePath";
            this.chooseImagePath.Size = new System.Drawing.Size(106, 23);
            this.chooseImagePath.TabIndex = 7;
            this.chooseImagePath.Text = "选择资料文件夹";
            this.chooseImagePath.UseVisualStyleBackColor = true;
            this.chooseImagePath.Click += new System.EventHandler(this.chooseImagePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "储存地点:";
            // 
            // destinationText
            // 
            this.destinationText.Location = new System.Drawing.Point(79, 146);
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(156, 20);
            this.destinationText.TabIndex = 6;
            this.destinationText.Text = "C:\\";
            // 
            // chooseDescription
            // 
            this.chooseDescription.Location = new System.Drawing.Point(241, 146);
            this.chooseDescription.Name = "chooseDescription";
            this.chooseDescription.Size = new System.Drawing.Size(106, 26);
            this.chooseDescription.TabIndex = 8;
            this.chooseDescription.Text = "选择储存地点";
            this.chooseDescription.UseVisualStyleBackColor = true;
            this.chooseDescription.Click += new System.EventHandler(this.chooseDescription_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "车型:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "索赔编号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "时间:";
            // 
            // carModelText
            // 
            this.carModelText.Location = new System.Drawing.Point(79, 33);
            this.carModelText.Name = "carModelText";
            this.carModelText.Size = new System.Drawing.Size(156, 20);
            this.carModelText.TabIndex = 2;
            // 
            // codeText
            // 
            this.codeText.Location = new System.Drawing.Point(79, 59);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(156, 20);
            this.codeText.TabIndex = 3;
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(79, 89);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(156, 20);
            this.dateText.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "文件名:";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(79, 177);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(156, 20);
            this.fileName.TabIndex = 13;
            this.fileName.Text = "defect_descript";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 293);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.carModelText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseDescription);
            this.Controls.Add(this.destinationText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseImagePath);
            this.Controls.Add(this.imagePathText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.headerLabel);
            this.Name = "Form1";
            this.Text = "Excel Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox headerText;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imagePathText;
        private System.Windows.Forms.Button chooseImagePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destinationText;
        private System.Windows.Forms.Button chooseDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox carModelText;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fileName;
    }
}

