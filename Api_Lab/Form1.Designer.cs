namespace Api_Lab
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
            type_of_data = new Label();
            fall_list = new ComboBox();
            name_znachenia = new Label();
            search_znachenia = new TextBox();
            search1 = new Button();
            rezults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)rezults).BeginInit();
            SuspendLayout();
            // 
            // type_of_data
            // 
            type_of_data.AutoSize = true;
            type_of_data.Location = new Point(12, 9);
            type_of_data.Name = "type_of_data";
            type_of_data.Size = new Size(74, 15);
            type_of_data.TabIndex = 0;
            type_of_data.Text = "Тип данных:";
            // 
            // fall_list
            // 
            fall_list.FormattingEnabled = true;
            fall_list.Location = new Point(92, 6);
            fall_list.Name = "fall_list";
            fall_list.Size = new Size(121, 23);
            fall_list.TabIndex = 1;
            // 
            // name_znachenia
            // 
            name_znachenia.AutoSize = true;
            name_znachenia.Location = new Point(12, 69);
            name_znachenia.Name = "name_znachenia";
            name_znachenia.Size = new Size(63, 15);
            name_znachenia.TabIndex = 2;
            name_znachenia.Text = "Значение:";
            // 
            // search_znachenia
            // 
            search_znachenia.Location = new Point(102, 66);
            search_znachenia.Name = "search_znachenia";
            search_znachenia.Size = new Size(100, 23);
            search_znachenia.TabIndex = 3;
            // 
            // search1
            // 
            search1.Location = new Point(12, 127);
            search1.Name = "search1";
            search1.Size = new Size(75, 23);
            search1.TabIndex = 4;
            search1.Text = "Найти";
            search1.UseVisualStyleBackColor = true;
            search1.Click += name_znachenia_Click;
            // 
            // rezults
            // 
            rezults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rezults.Location = new Point(12, 180);
            rezults.Name = "rezults";
            rezults.Size = new Size(732, 150);
            rezults.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rezults);
            Controls.Add(search1);
            Controls.Add(search_znachenia);
            Controls.Add(name_znachenia);
            Controls.Add(fall_list);
            Controls.Add(type_of_data);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)rezults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label type_of_data;
        private ComboBox fall_list;
        private Label name_znachenia;
        private TextBox search_znachenia;
        private Button search1;
        private DataGridView rezults;
    }
}
