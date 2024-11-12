namespace todo
{
    partial class ToDoList
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.toDoListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 123);
            this.label1.TabIndex = 0;
            this.label1.Text = "To do list ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(90, 91);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(650, 35);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(90, 179);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(650, 35);
            this.descriptionTextbox.TabIndex = 2;
            this.descriptionTextbox.TextChanged += new System.EventHandler(this.descriptionTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "title:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(86, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // newButton
            // 
            this.newButton.ForeColor = System.Drawing.Color.Gray;
            this.newButton.Location = new System.Drawing.Point(90, 239);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(144, 43);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "new";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click_1);
            // 
            // editbutton
            // 
            this.editbutton.ForeColor = System.Drawing.Color.Gray;
            this.editbutton.Location = new System.Drawing.Point(240, 239);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(144, 43);
            this.editbutton.TabIndex = 6;
            this.editbutton.Text = "edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click_1);
            // 
            // deletebutton
            // 
            this.deletebutton.ForeColor = System.Drawing.Color.Gray;
            this.deletebutton.Location = new System.Drawing.Point(390, 239);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(144, 43);
            this.deletebutton.TabIndex = 7;
            this.deletebutton.Text = "delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.ForeColor = System.Drawing.Color.Gray;
            this.savebutton.Location = new System.Drawing.Point(540, 239);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(144, 43);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // toDoListView
            // 
            this.toDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDoListView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.toDoListView.Location = new System.Drawing.Point(90, 298);
            this.toDoListView.Name = "toDoListView";
            this.toDoListView.RowHeadersWidth = 82;
            this.toDoListView.RowTemplate.Height = 37;
            this.toDoListView.Size = new System.Drawing.Size(650, 457);
            this.toDoListView.TabIndex = 9;
            this.toDoListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 779);
            this.Controls.Add(this.toDoListView);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ToDoList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.toDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.DataGridView toDoListView;
    }
}

