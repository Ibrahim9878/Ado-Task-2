namespace ADO_Task_2
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
            SearchBox = new TextBox();
            button1 = new Button();
            MarkaRadioButton = new RadioButton();
            ModelRadioButton = new RadioButton();
            carBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(14, 16);
            SearchBox.Margin = new Padding(3, 4, 3, 4);
            SearchBox.Multiline = true;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(266, 53);
            SearchBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(298, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 55);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MarkaRadioButton
            // 
            MarkaRadioButton.AutoSize = true;
            MarkaRadioButton.Location = new Point(14, 79);
            MarkaRadioButton.Margin = new Padding(3, 4, 3, 4);
            MarkaRadioButton.Name = "MarkaRadioButton";
            MarkaRadioButton.Size = new Size(71, 24);
            MarkaRadioButton.TabIndex = 2;
            MarkaRadioButton.TabStop = true;
            MarkaRadioButton.Text = "Marka";
            MarkaRadioButton.UseVisualStyleBackColor = true;
            // 
            // ModelRadioButton
            // 
            ModelRadioButton.AutoSize = true;
            ModelRadioButton.Location = new Point(128, 79);
            ModelRadioButton.Margin = new Padding(3, 4, 3, 4);
            ModelRadioButton.Name = "ModelRadioButton";
            ModelRadioButton.Size = new Size(73, 24);
            ModelRadioButton.TabIndex = 3;
            ModelRadioButton.TabStop = true;
            ModelRadioButton.Text = "Model";
            ModelRadioButton.UseVisualStyleBackColor = true;
            // 
            // carBox
            // 
            carBox.FormattingEnabled = true;
            carBox.Location = new Point(12, 134);
            carBox.Name = "carBox";
            carBox.Size = new Size(405, 344);
            carBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 111);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 111);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 111);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 7;
            label3.Text = "Model";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 500);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(carBox);
            Controls.Add(ModelRadioButton);
            Controls.Add(MarkaRadioButton);
            Controls.Add(button1);
            Controls.Add(SearchBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private Button button1;
        private RadioButton MarkaRadioButton;
        private RadioButton ModelRadioButton;
        private ListBox carBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
