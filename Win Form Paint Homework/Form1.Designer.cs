using System.Reflection;
using System.Runtime.CompilerServices;

namespace Win_Form_Paint_Homework
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Paint";
            this.MouseDown += Mouse_Down;
            this.MouseUp += Mouse_Up;
            Icon icon = new Icon(new FileStream("C:\\Users\\hasan\\source\\repos\\Win Form Paint Homework\\Win Form Paint Homework\\Resources\\icons8-microsoft-paint-48.ico", FileMode.Open));
            this.Icon = icon;
        }


       

        #endregion
    }
}