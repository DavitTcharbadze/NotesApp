
namespace FinalProject
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
            Title = new Label();
            Content = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            dataGridViewNotes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotes).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Title.Location = new Point(69, 19);
            Title.Name = "Title";
            Title.Size = new Size(102, 46);
            Title.TabIndex = 0;
            Title.Text = "Title:";
            // 
            // Content
            // 
            Content.AutoSize = true;
            Content.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Content.Location = new Point(16, 65);
            Content.Name = "Content";
            Content.Size = new Size(155, 46);
            Content.TabIndex = 1;
            Content.Text = "Content:";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(177, 96);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(413, 221);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.Location = new Point(177, 19);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(348, 52);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(177, 323);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(102, 40);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.TextAlign = ContentAlignment.TopCenter;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(337, 323);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(100, 40);
            UpdateButton.TabIndex = 5;
            UpdateButton.Text = "Update";
            UpdateButton.TextAlign = ContentAlignment.TopCenter;
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(492, 323);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 40);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.TextAlign = ContentAlignment.TopCenter;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // dataGridViewNotes
            // 
            dataGridViewNotes.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNotes.Location = new Point(636, 379);
            dataGridViewNotes.Name = "dataGridViewNotes";
            dataGridViewNotes.RowHeadersWidth = 51;
            dataGridViewNotes.Size = new Size(480, 266);
            dataGridViewNotes.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 657);
            Controls.Add(dataGridViewNotes);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(Content);
            Controls.Add(Title);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Content;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private DataGridView dataGridViewNotes;
    }
}