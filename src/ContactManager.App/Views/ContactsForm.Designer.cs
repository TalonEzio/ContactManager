namespace ContactManager.App.Views
{
    partial class ContactsForm
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
            components = new System.ComponentModel.Container();
            contactBindingSource = new BindingSource(components);
            splitContainer = new SplitContainer();
            grbContactList = new GroupBox();
            dgvContacts = new DataGridView();
            grbContactDetail = new GroupBox();
            dtpDateOfBirth = new DateTimePicker();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtAlias = new TextBox();
            txtContactName = new TextBox();
            numId = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            grbContactList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            grbContactDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            SuspendLayout();
            // 
            // contactBindingSource
            // 
            contactBindingSource.DataSource = typeof(ViewModels.ContactsViewModel);
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(grbContactList);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(grbContactDetail);
            splitContainer.Size = new Size(1264, 761);
            splitContainer.SplitterDistance = 801;
            splitContainer.TabIndex = 2;
            // 
            // grbContactList
            // 
            grbContactList.Controls.Add(dgvContacts);
            grbContactList.Dock = DockStyle.Fill;
            grbContactList.Location = new Point(0, 0);
            grbContactList.Name = "grbContactList";
            grbContactList.Size = new Size(801, 761);
            grbContactList.TabIndex = 0;
            grbContactList.TabStop = false;
            grbContactList.Text = "Contacts";
            // 
            // dgvContacts
            // 
            dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvContacts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Dock = DockStyle.Fill;
            dgvContacts.Location = new Point(3, 28);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.Size = new Size(795, 730);
            dgvContacts.TabIndex = 0;
            dgvContacts.SelectionChanged += dgvContacts_SelectionChanged;
            // 
            // grbContactDetail
            // 
            grbContactDetail.Controls.Add(dtpDateOfBirth);
            grbContactDetail.Controls.Add(txtLastName);
            grbContactDetail.Controls.Add(txtFirstName);
            grbContactDetail.Controls.Add(txtAlias);
            grbContactDetail.Controls.Add(txtContactName);
            grbContactDetail.Controls.Add(numId);
            grbContactDetail.Controls.Add(label6);
            grbContactDetail.Controls.Add(label5);
            grbContactDetail.Controls.Add(label4);
            grbContactDetail.Controls.Add(label3);
            grbContactDetail.Controls.Add(label2);
            grbContactDetail.Controls.Add(label1);
            grbContactDetail.Dock = DockStyle.Fill;
            grbContactDetail.Location = new Point(0, 0);
            grbContactDetail.Name = "grbContactDetail";
            grbContactDetail.Size = new Size(459, 761);
            grbContactDetail.TabIndex = 0;
            grbContactDetail.TabStop = false;
            grbContactDetail.Text = "Contact Detail";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(190, 283);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 32);
            dtpDateOfBirth.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(193, 237);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 32);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(193, 191);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 32);
            txtFirstName.TabIndex = 2;
            // 
            // txtAlias
            // 
            txtAlias.Location = new Point(193, 145);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(200, 32);
            txtAlias.TabIndex = 2;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(193, 99);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(200, 32);
            txtContactName.TabIndex = 2;
            // 
            // numId
            // 
            numId.Location = new Point(193, 53);
            numId.Name = "numId";
            numId.Size = new Size(200, 32);
            numId.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 289);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 0;
            label6.Text = "Date of birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 242);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 0;
            label5.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 195);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 0;
            label4.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 148);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 0;
            label3.Text = "Alias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 101);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 0;
            label2.Text = "Contact name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 54);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // ContactsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(splitContainer);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "ContactsForm";
            Text = "ContactForm";
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            grbContactList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            grbContactDetail.ResumeLayout(false);
            grbContactDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource contactBindingSource;
        private SplitContainer splitContainer;
        private GroupBox grbContactList;
        private GroupBox grbContactDetail;
        private DataGridView dgvContacts;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtAlias;
        private TextBox txtContactName;
        private NumericUpDown numId;
    }
}