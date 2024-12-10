namespace Metodo_de_Busqueda
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
            btnGenerate = new Button();
            txtNumbers = new TextBox();
            txtSearch = new TextBox();
            btnSequentialSearch = new Button();
            btnBinarySearch = new Button();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(277, 52);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(122, 51);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtNumbers
            // 
            txtNumbers.Location = new Point(33, 73);
            txtNumbers.Multiline = true;
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(160, 40);
            txtNumbers.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(33, 169);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(160, 38);
            txtSearch.TabIndex = 2;
            // 
            // btnSequentialSearch
            // 
            btnSequentialSearch.Location = new Point(277, 118);
            btnSequentialSearch.Name = "btnSequentialSearch";
            btnSequentialSearch.Size = new Size(144, 60);
            btnSequentialSearch.TabIndex = 3;
            btnSequentialSearch.Text = "SequentialSearch";
            btnSequentialSearch.UseVisualStyleBackColor = true;
            btnSequentialSearch.Click += btnSequentialSearch_Click;
            // 
            // btnBinarySearch
            // 
            btnBinarySearch.Location = new Point(438, 52);
            btnBinarySearch.Name = "btnBinarySearch";
            btnBinarySearch.Size = new Size(122, 51);
            btnBinarySearch.TabIndex = 4;
            btnBinarySearch.Text = "BinarySearch";
            btnBinarySearch.UseVisualStyleBackColor = true;
            btnBinarySearch.Click += btnBinarySearch_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(69, 257);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "Numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 134);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 7;
            label2.Text = "Numero a Buscar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnBinarySearch);
            Controls.Add(btnSequentialSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtNumbers);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private TextBox txtNumbers;
        private TextBox txtSearch;
        private Button btnSequentialSearch;
        private Button btnBinarySearch;
        private Label lblResult;
        private Label label1;
        private Label label2;
    }
}
