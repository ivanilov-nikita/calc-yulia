using System.Drawing;
using System.Windows.Forms;

namespace Calc_Yulia
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Text = "Form1";

            high_label = new Label();
            this.high_label.Location = new System.Drawing.Point(0, 0);
            this.high_label.Size = new Size(500, 100);
            this.high_label.BackColor = Color.Blue;
            this.Controls.Add(high_label);

            title_label = new Label();
            this.title_label.Location = new Point(80, 120);
            this.title_label.Size = new Size(350, 50);
            this.title_label.Font = new Font("Times New Roman", 18);
            this.title_label.Text = "Калькулятор по расходу топлива";
            this.Controls.Add(title_label);

            distance_label = new Label();
            this.distance_label.Location = new Point(10,title_label.Location.Y+120);
            this.distance_label.Size = new Size(250, 50);
            this.distance_label.Font = new Font("Times New Roman", 14);
            this.distance_label.Text = "Сколько хотите проехать(км)";
            this.Controls.Add(distance_label);

        }

        Label high_label;
        Label title_label;
        Label distance_label;
        #endregion
    }
}

