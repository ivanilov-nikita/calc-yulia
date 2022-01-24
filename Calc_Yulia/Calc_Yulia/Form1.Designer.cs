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
            this.Text = "Calculator";

            high_label = new Label();
            this.high_label.Location = new System.Drawing.Point(0, 0);
            this.high_label.Size = new Size(500, 100);
            this.high_label.BackColor = Color.Teal;
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

            distance_TextBox = new TextBox();
            this.distance_TextBox.Location = new Point(distance_label.Location.X + 330, distance_label.Location.Y);
            this.Controls.Add(distance_TextBox);

            average_cons_label = new Label();
            this.average_cons_label.Location = new Point(distance_label.Location.X, distance_label.Location.Y +60);
            this.average_cons_label.Size = new Size(300, 50);
            this.average_cons_label.Font = new Font("Times New Roman", 14);
            this.average_cons_label.Text = "Средний расход топлива(л/100км)";
            this.Controls.Add(average_cons_label);

            average_cons_TextBox = new TextBox();
            this.average_cons_TextBox.Location = new Point(distance_TextBox.Location.X, distance_TextBox.Location.Y + 60);
            this.Controls.Add(average_cons_TextBox);

            price_label = new Label();
            this.price_label.Location = new Point(average_cons_label.Location.X, average_cons_label.Location.Y + 60);
            this.price_label.Size = new Size(300, 50);
            this.price_label.Font = new Font("Times New Roman", 14);
            this.price_label.Text = "Цена 1л топлива(грн)";
            this.Controls.Add(price_label);

            price_TextBox = new TextBox();
            this.price_TextBox.Location = new Point(average_cons_TextBox.Location.X, average_cons_TextBox.Location.Y + 60);
            this.Controls.Add(price_TextBox);

            button = new Button();
            this.button.Text = "Расчитать";
            this.button.Location = new Point(130, price_TextBox.Location.Y + 100);
            this.button.Size = new Size(250, 50);
            button.Font = new Font("Times New Roman", 14);
            this.Controls.Add(button);

            fuel_result_Label = new Label();
            this.fuel_result_Label.Location = new Point(price_label.Location.X, button.Location.Y + 100);
            this.fuel_result_Label.Size = new Size(300, 50);
            this.fuel_result_Label.Font = new Font("Times New Roman", 14);
            this.fuel_result_Label.Text = "Потребуется топлива(л)";
            this.Controls.Add(fuel_result_Label);

            fuel_result_TextBox = new TextBox();
            this.fuel_result_TextBox.Location = new Point(average_cons_TextBox.Location.X, button.Location.Y + 100);
            this.Controls.Add(fuel_result_TextBox);

            price_result_Label = new Label();
            this.price_result_Label.Location = new Point(fuel_result_Label.Location.X, fuel_result_Label.Location.Y + 60);
            this.price_result_Label.Size = new Size(300, 50);
            this.price_result_Label.Font = new Font("Times New Roman", 14);
            this.price_result_Label.Text = "Стоимость топлива(грн)";
            this.Controls.Add(price_result_Label);

            price_result_TextBox = new TextBox();
            this.price_result_TextBox.Location = new Point(fuel_result_TextBox.Location.X, fuel_result_TextBox.Location.Y + 60);
            this.Controls.Add(price_result_TextBox);
        }

        Label high_label;
        Label title_label;
        Label distance_label;
        Label average_cons_label;
        Label price_label;
        Label fuel_result_Label;
        Label price_result_Label;

        TextBox distance_TextBox;
        TextBox average_cons_TextBox;
        TextBox price_TextBox;
        TextBox fuel_result_TextBox;
        TextBox price_result_TextBox;

        Button button;
        #endregion
    }
}

