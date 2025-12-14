using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.PisarevMA.Sprint6.Task7.V18
{
    partial class FormAboutSprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutSprint));
            groupBoxTask = new GroupBox();
            groupBoxGroup = new GroupBox();
            groupBoxC = new GroupBox();
            groupBoxTyuiu = new GroupBox();
            buttonOk = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxGroup.SuspendLayout();
            groupBoxC.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxGroup);
            groupBoxTask.Location = new Point(10, 9);
            groupBoxTask.Margin = new Padding(3, 2, 3, 2);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(3, 2, 3, 2);
            groupBoxTask.Size = new Size(327, 112);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Разработчик: Писарев М. А.";
            // 
            // groupBoxGroup
            // 
            groupBoxGroup.Controls.Add(groupBoxC);
            groupBoxGroup.Location = new Point(0, 20);
            groupBoxGroup.Margin = new Padding(3, 2, 3, 2);
            groupBoxGroup.Name = "groupBoxGroup";
            groupBoxGroup.Padding = new Padding(3, 2, 3, 2);
            groupBoxGroup.Size = new Size(327, 92);
            groupBoxGroup.TabIndex = 0;
            groupBoxGroup.TabStop = false;
            groupBoxGroup.Text = "Группа: АСОиУб-25-1";
            // 
            // groupBoxC
            // 
            groupBoxC.Controls.Add(groupBoxTyuiu);
            groupBoxC.Location = new Point(0, 20);
            groupBoxC.Margin = new Padding(3, 2, 3, 2);
            groupBoxC.Name = "groupBoxC";
            groupBoxC.Padding = new Padding(3, 2, 3, 2);
            groupBoxC.Size = new Size(327, 73);
            groupBoxC.TabIndex = 0;
            groupBoxC.TabStop = false;
            groupBoxC.Text = "Программа разработана в рамках изучения языка C# ";
            // 
            // groupBoxTyuiu
            // 
            groupBoxTyuiu.Location = new Point(0, 34);
            groupBoxTyuiu.Margin = new Padding(3, 2, 3, 2);
            groupBoxTyuiu.Name = "groupBoxTyuiu";
            groupBoxTyuiu.Padding = new Padding(3, 2, 3, 2);
            groupBoxTyuiu.Size = new Size(327, 38);
            groupBoxTyuiu.TabIndex = 0;
            groupBoxTyuiu.TabStop = false;
            groupBoxTyuiu.Text = "Тюменский индустриальный университет. Высшая школа цифровых технологий.";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(220, 130);
            buttonOk.Margin = new Padding(3, 2, 3, 2);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(107, 26);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAboutSprint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 164);
            Controls.Add(buttonOk);
            Controls.Add(groupBoxTask);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAboutSprint";
            Text = "О программе";
            Load += FormAboutSprint_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxGroup.ResumeLayout(false);
            groupBoxC.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxGroup;
        private GroupBox groupBoxC;
        private GroupBox groupBoxTyuiu;
        private Button buttonOk;
    }
}