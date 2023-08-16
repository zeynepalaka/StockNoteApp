namespace ExampleFullStack
{
    partial class ProductsForm
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
            btnAdd = new Button();
            listNote = new ListBox();
            TxtNote = new RichTextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            lblUser = new Label();
            txtStock = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.MediumSlateBlue;
            btnAdd.Location = new Point(361, 429);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 73);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // listNote
            // 
            listNote.FormattingEnabled = true;
            listNote.ItemHeight = 23;
            listNote.Location = new Point(551, 57);
            listNote.Margin = new Padding(4, 4, 4, 4);
            listNote.Name = "listNote";
            listNote.Size = new Size(355, 533);
            listNote.TabIndex = 1;
            listNote.SelectedIndexChanged += listNote_SelectedIndexChanged;
            // 
            // TxtNote
            // 
            TxtNote.Location = new Point(42, 151);
            TxtNote.Margin = new Padding(4, 4, 4, 4);
            TxtNote.Name = "TxtNote";
            TxtNote.Size = new Size(457, 154);
            TxtNote.TabIndex = 2;
            TxtNote.Text = "";
            // 
            // btnEdit
            // 
            btnEdit.ForeColor = Color.MediumSlateBlue;
            btnEdit.Location = new Point(198, 429);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(139, 72);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.MediumSlateBlue;
            btnDelete.Location = new Point(42, 429);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 73);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(704, 615);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(55, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 23);
            label2.TabIndex = 3;
            label2.Text = "Giriş Yapan Kullanıcı:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.ForeColor = SystemColors.ButtonFace;
            lblUser.Location = new Point(346, 39);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(61, 23);
            lblUser.TabIndex = 3;
            lblUser.Text = "label1";
            lblUser.Click += lblUser_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(42, 355);
            txtStock.Margin = new Padding(4, 4, 4, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(457, 31);
            txtStock.TabIndex = 4;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(44, 108);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 5;
            label3.Text = "Stock İsimleri";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(956, 672);
            Controls.Add(label3);
            Controls.Add(txtStock);
            Controls.Add(label2);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(TxtNote);
            Controls.Add(listNote);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ProductsForm";
            Text = "Form1";
            FormClosed += NotesForm_FormClosed;
            Load += ProductsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ListBox listNote;
        private RichTextBox TxtNote;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label lblUser;
        private TextBox txtStock;
        private Label label3;
    }
}