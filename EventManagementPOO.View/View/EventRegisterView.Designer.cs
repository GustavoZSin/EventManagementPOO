namespace EventManagementPOO.View
{
    partial class EventRegisterView
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
            btnAddEvent = new Button();
            btnUpdateEvent = new Button();
            btnRemoveEvent = new Button();
            txbEventName = new TextBox();
            dtpEventDate = new DateTimePicker();
            txbEventLocation = new TextBox();
            cbxEventType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbEventDescription = new TextBox();
            dgvEvents = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            hour = new DataGridViewTextBoxColumn();
            location = new DataGridViewTextBoxColumn();
            label6 = new Label();
            dtpEventHour = new DateTimePicker();
            btnAddObserver = new Button();
            btnRemoveObserver = new Button();
            label7 = new Label();
            txbParticipantName = new TextBox();
            gbxParticipants = new GroupBox();
            label10 = new Label();
            dgvRegisteredParticipants = new DataGridView();
            participantName = new DataGridViewTextBoxColumn();
            participantEmail = new DataGridViewTextBoxColumn();
            eventName = new DataGridViewTextBoxColumn();
            label9 = new Label();
            txbParticipantEmail = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            gbxParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredParticipants).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(109, 146);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(238, 36);
            btnAddEvent.TabIndex = 7;
            btnAddEvent.Text = "Add Event";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // btnUpdateEvent
            // 
            btnUpdateEvent.Location = new Point(597, 146);
            btnUpdateEvent.Name = "btnUpdateEvent";
            btnUpdateEvent.Size = new Size(238, 36);
            btnUpdateEvent.TabIndex = 9;
            btnUpdateEvent.Text = "Update Event";
            btnUpdateEvent.UseVisualStyleBackColor = true;
            btnUpdateEvent.Click += btnUpdateEvent_Click;
            // 
            // btnRemoveEvent
            // 
            btnRemoveEvent.Location = new Point(353, 146);
            btnRemoveEvent.Name = "btnRemoveEvent";
            btnRemoveEvent.Size = new Size(238, 36);
            btnRemoveEvent.TabIndex = 8;
            btnRemoveEvent.Text = "Remove Event";
            btnRemoveEvent.UseVisualStyleBackColor = true;
            btnRemoveEvent.Click += btnRemoveEvent_Click;
            // 
            // txbEventName
            // 
            txbEventName.Location = new Point(109, 30);
            txbEventName.Name = "txbEventName";
            txbEventName.Size = new Size(612, 27);
            txbEventName.TabIndex = 1;
            // 
            // dtpEventDate
            // 
            dtpEventDate.CustomFormat = "dd/MM/yyyy";
            dtpEventDate.Format = DateTimePickerFormat.Custom;
            dtpEventDate.Location = new Point(797, 28);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(128, 27);
            dtpEventDate.TabIndex = 4;
            dtpEventDate.Value = new DateTime(2024, 6, 10, 20, 6, 46, 0);
            // 
            // txbEventLocation
            // 
            txbEventLocation.Location = new Point(109, 96);
            txbEventLocation.Name = "txbEventLocation";
            txbEventLocation.Size = new Size(612, 27);
            txbEventLocation.TabIndex = 3;
            // 
            // cbxEventType
            // 
            cbxEventType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEventType.ForeColor = Color.Black;
            cbxEventType.FormattingEnabled = true;
            cbxEventType.Items.AddRange(new object[] { "Conference", "Workshop" });
            cbxEventType.SelectedIndex = 0;
            cbxEventType.Location = new Point(797, 97);
            cbxEventType.Name = "cbxEventType";
            cbxEventType.Size = new Size(128, 28);
            cbxEventType.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 31);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 8;
            label1.Text = "Name*:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(758, 33);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 9;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 96);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 10;
            label3.Text = "Location*:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(753, 100);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 11;
            label4.Text = "Type*:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 64);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 13;
            label5.Text = "Description*:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txbEventDescription
            // 
            txbEventDescription.Location = new Point(109, 63);
            txbEventDescription.Name = "txbEventDescription";
            txbEventDescription.Size = new Size(612, 27);
            txbEventDescription.TabIndex = 2;
            // 
            // dgvEvents
            // 
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Columns.AddRange(new DataGridViewColumn[] { name, type, description, date, hour, location });
            dgvEvents.Location = new Point(6, 226);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.Size = new Size(948, 241);
            dgvEvents.TabIndex = 10;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // type
            // 
            type.HeaderText = "Type";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.ReadOnly = true;
            type.Width = 125;
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
            description.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 125;
            // 
            // hour
            // 
            hour.HeaderText = "Hour";
            hour.MinimumWidth = 6;
            hour.Name = "hour";
            hour.ReadOnly = true;
            hour.Width = 125;
            // 
            // location
            // 
            location.HeaderText = "Location";
            location.MinimumWidth = 6;
            location.Name = "location";
            location.ReadOnly = true;
            location.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(757, 69);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 16;
            label6.Text = "Hour:";
            // 
            // dtpEventHour
            // 
            dtpEventHour.CustomFormat = "";
            dtpEventHour.Format = DateTimePickerFormat.Time;
            dtpEventHour.Location = new Point(797, 64);
            dtpEventHour.Name = "dtpEventHour";
            dtpEventHour.ShowUpDown = true;
            dtpEventHour.Size = new Size(128, 27);
            dtpEventHour.TabIndex = 5;
            dtpEventHour.Value = new DateTime(2024, 6, 10, 20, 6, 46, 0);
            // 
            // btnAddObserver
            // 
            btnAddObserver.Location = new Point(24, 120);
            btnAddObserver.Name = "btnAddObserver";
            btnAddObserver.Size = new Size(463, 38);
            btnAddObserver.TabIndex = 13;
            btnAddObserver.Text = "Add Observer";
            btnAddObserver.UseVisualStyleBackColor = true;
            btnAddObserver.Click += btnAddObserver_Click;
            // 
            // btnRemoveObserver
            // 
            btnRemoveObserver.Location = new Point(24, 164);
            btnRemoveObserver.Name = "btnRemoveObserver";
            btnRemoveObserver.Size = new Size(463, 38);
            btnRemoveObserver.TabIndex = 14;
            btnRemoveObserver.Text = "Remove Observer";
            btnRemoveObserver.UseVisualStyleBackColor = true;
            btnRemoveObserver.Click += btnRemoveObserver_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 49);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 21;
            label7.Text = "Name*:";
            // 
            // txbParticipantName
            // 
            txbParticipantName.Location = new Point(82, 46);
            txbParticipantName.Name = "txbParticipantName";
            txbParticipantName.Size = new Size(405, 27);
            txbParticipantName.TabIndex = 11;
            // 
            // gbxParticipants
            // 
            gbxParticipants.Controls.Add(label10);
            gbxParticipants.Controls.Add(dgvRegisteredParticipants);
            gbxParticipants.Controls.Add(label9);
            gbxParticipants.Controls.Add(txbParticipantEmail);
            gbxParticipants.Controls.Add(label7);
            gbxParticipants.Controls.Add(btnRemoveObserver);
            gbxParticipants.Controls.Add(txbParticipantName);
            gbxParticipants.Controls.Add(btnAddObserver);
            gbxParticipants.Location = new Point(12, 503);
            gbxParticipants.Name = "gbxParticipants";
            gbxParticipants.Size = new Size(960, 218);
            gbxParticipants.TabIndex = 15;
            gbxParticipants.TabStop = false;
            gbxParticipants.Text = "Participants";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(507, 23);
            label10.Name = "label10";
            label10.Size = new Size(165, 20);
            label10.TabIndex = 24;
            label10.Text = "Registered participants:";
            // 
            // dgvRegisteredParticipants
            // 
            dgvRegisteredParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegisteredParticipants.Columns.AddRange(new DataGridViewColumn[] { participantName, participantEmail, eventName });
            dgvRegisteredParticipants.Location = new Point(507, 46);
            dgvRegisteredParticipants.Name = "dgvRegisteredParticipants";
            dgvRegisteredParticipants.RowHeadersWidth = 51;
            dgvRegisteredParticipants.Size = new Size(447, 166);
            dgvRegisteredParticipants.TabIndex = 24;
            // 
            // participantName
            // 
            participantName.HeaderText = "Name";
            participantName.MinimumWidth = 6;
            participantName.Name = "participantName";
            participantName.ReadOnly = true;
            participantName.Width = 125;
            // 
            // participantEmail
            // 
            participantEmail.HeaderText = "Email";
            participantEmail.MinimumWidth = 6;
            participantEmail.Name = "participantEmail";
            participantEmail.ReadOnly = true;
            participantEmail.Width = 125;
            // 
            // eventName
            // 
            eventName.HeaderText = "Event Name";
            eventName.MinimumWidth = 6;
            eventName.Name = "eventName";
            eventName.ReadOnly = true;
            eventName.Width = 125;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 82);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 23;
            label9.Text = "Email*:";
            // 
            // txbParticipantEmail
            // 
            txbParticipantEmail.Location = new Point(82, 79);
            txbParticipantEmail.Name = "txbParticipantEmail";
            txbParticipantEmail.Size = new Size(405, 27);
            txbParticipantEmail.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 203);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 23;
            label8.Text = "Registered Events:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAddEvent);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnUpdateEvent);
            groupBox1.Controls.Add(dtpEventHour);
            groupBox1.Controls.Add(btnRemoveEvent);
            groupBox1.Controls.Add(dgvEvents);
            groupBox1.Controls.Add(txbEventName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpEventDate);
            groupBox1.Controls.Add(txbEventDescription);
            groupBox1.Controls.Add(txbEventLocation);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbxEventType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 473);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Events";
            // 
            // EventRegisterView
            // 
            ClientSize = new Size(982, 733);
            Controls.Add(gbxParticipants);
            Controls.Add(groupBox1);
            Name = "EventRegisterView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Register";
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            gbxParticipants.ResumeLayout(false);
            gbxParticipants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredParticipants).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnRemoveEvent;
        private System.Windows.Forms.TextBox txbEventName;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox txbEventLocation;
        private System.Windows.Forms.ComboBox cbxEventType;

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbEventDescription;
        private DataGridView dgvEvents;
        private Label label6;
        private DateTimePicker dtpEventHour;
        private Button btnAddObserver;
        private Button btnRemoveObserver;
        private Label label7;
        private TextBox txbParticipantName;
        private GroupBox gbxParticipants;
        private Label label8;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox txbParticipantEmail;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn hour;
        private DataGridViewTextBoxColumn location;
        private Label label10;
        private DataGridView dgvRegisteredParticipants;
        private DataGridViewTextBoxColumn participantName;
        private DataGridViewTextBoxColumn participantEmail;
        private DataGridViewTextBoxColumn eventName;
    }
}
