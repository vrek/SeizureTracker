namespace SeizureTrackerWinUI;

partial class frmMain
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
        lblCareGiver = new Label();
        cmbCareGiver = new ComboBox();
        btnCareGiver = new Button();
        btnPatient = new Button();
        comboBox1 = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        btn_TestConnection = new Button();
        btnSaveConnection = new Button();
        dgSeizureList = new DataGridView();
        btnRecordSeizure = new Button();
        btnSeizureReport = new Button();
        btnAddCareGiver = new Button();
        btnAddPatient = new Button();
        ((System.ComponentModel.ISupportInitialize)dgSeizureList).BeginInit();
        SuspendLayout();
        // 
        // lblCareGiver
        // 
        lblCareGiver.AutoSize = true;
        lblCareGiver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblCareGiver.Location = new Point(12, 37);
        lblCareGiver.Name = "lblCareGiver";
        lblCareGiver.Size = new Size(108, 30);
        lblCareGiver.TabIndex = 0;
        lblCareGiver.Text = "Care Giver";
        // 
        // cmbCareGiver
        // 
        cmbCareGiver.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cmbCareGiver.FormattingEnabled = true;
        cmbCareGiver.Location = new Point(137, 38);
        cmbCareGiver.Name = "cmbCareGiver";
        cmbCareGiver.Size = new Size(226, 33);
        cmbCareGiver.TabIndex = 1;
        // 
        // btnCareGiver
        // 
        btnCareGiver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnCareGiver.Location = new Point(383, 38);
        btnCareGiver.Name = "btnCareGiver";
        btnCareGiver.Size = new Size(99, 33);
        btnCareGiver.TabIndex = 2;
        btnCareGiver.Text = "Select";
        btnCareGiver.UseVisualStyleBackColor = true;
        // 
        // btnPatient
        // 
        btnPatient.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnPatient.Location = new Point(383, 99);
        btnPatient.Name = "btnPatient";
        btnPatient.Size = new Size(99, 33);
        btnPatient.TabIndex = 4;
        btnPatient.Text = "Select";
        btnPatient.UseVisualStyleBackColor = true;
        // 
        // comboBox1
        // 
        comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(137, 99);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(226, 33);
        comboBox1.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 98);
        label1.Name = "label1";
        label1.Size = new Size(77, 30);
        label1.TabIndex = 3;
        label1.Text = "Patient";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(81, 599);
        label2.Name = "label2";
        label2.Size = new Size(50, 30);
        label2.TabIndex = 6;
        label2.Text = "Port";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(140, 594);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 35);
        textBox1.TabIndex = 7;
        textBox1.Text = "7079";
        // 
        // btn_TestConnection
        // 
        btn_TestConnection.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_TestConnection.Location = new Point(246, 575);
        btn_TestConnection.Name = "btn_TestConnection";
        btn_TestConnection.Size = new Size(168, 75);
        btn_TestConnection.TabIndex = 8;
        btn_TestConnection.Text = "Test Connection";
        btn_TestConnection.UseVisualStyleBackColor = true;
        // 
        // btnSaveConnection
        // 
        btnSaveConnection.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSaveConnection.Location = new Point(420, 575);
        btnSaveConnection.Name = "btnSaveConnection";
        btnSaveConnection.Size = new Size(168, 75);
        btnSaveConnection.TabIndex = 9;
        btnSaveConnection.Text = "Save Connection";
        btnSaveConnection.UseVisualStyleBackColor = true;
        // 
        // dgSeizureList
        // 
        dgSeizureList.AllowUserToAddRows = false;
        dgSeizureList.AllowUserToDeleteRows = false;
        dgSeizureList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgSeizureList.Location = new Point(22, 232);
        dgSeizureList.Name = "dgSeizureList";
        dgSeizureList.ReadOnly = true;
        dgSeizureList.Size = new Size(667, 337);
        dgSeizureList.TabIndex = 10;
        // 
        // btnRecordSeizure
        // 
        btnRecordSeizure.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnRecordSeizure.Location = new Point(12, 147);
        btnRecordSeizure.Name = "btnRecordSeizure";
        btnRecordSeizure.Size = new Size(119, 79);
        btnRecordSeizure.TabIndex = 11;
        btnRecordSeizure.Text = "Record Seizure";
        btnRecordSeizure.UseVisualStyleBackColor = true;
        // 
        // btnSeizureReport
        // 
        btnSeizureReport.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSeizureReport.Location = new Point(363, 147);
        btnSeizureReport.Name = "btnSeizureReport";
        btnSeizureReport.Size = new Size(119, 79);
        btnSeizureReport.TabIndex = 12;
        btnSeizureReport.Text = "Seizure Report";
        btnSeizureReport.UseVisualStyleBackColor = true;
        // 
        // btnAddCareGiver
        // 
        btnAddCareGiver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnAddCareGiver.Location = new Point(540, 38);
        btnAddCareGiver.Name = "btnAddCareGiver";
        btnAddCareGiver.Size = new Size(119, 79);
        btnAddCareGiver.TabIndex = 13;
        btnAddCareGiver.Text = "Add Care Giver";
        btnAddCareGiver.UseVisualStyleBackColor = true;
        // 
        // btnAddPatient
        // 
        btnAddPatient.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnAddPatient.Location = new Point(540, 147);
        btnAddPatient.Name = "btnAddPatient";
        btnAddPatient.Size = new Size(119, 79);
        btnAddPatient.TabIndex = 14;
        btnAddPatient.Text = "Add Patient";
        btnAddPatient.UseVisualStyleBackColor = true;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(717, 688);
        Controls.Add(btnAddPatient);
        Controls.Add(btnAddCareGiver);
        Controls.Add(btnSeizureReport);
        Controls.Add(btnRecordSeizure);
        Controls.Add(dgSeizureList);
        Controls.Add(btnSaveConnection);
        Controls.Add(btn_TestConnection);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(btnPatient);
        Controls.Add(comboBox1);
        Controls.Add(label1);
        Controls.Add(btnCareGiver);
        Controls.Add(cmbCareGiver);
        Controls.Add(lblCareGiver);
        Name = "frmMain";
        Text = "Seizure Tracker";
        Load += frmMain_Load;
        ((System.ComponentModel.ISupportInitialize)dgSeizureList).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblCareGiver;
    private ComboBox cmbCareGiver;
    private Button btnCareGiver;
    private Button btnPatient;
    private ComboBox comboBox1;
    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private Button btn_TestConnection;
    private Button btnSaveConnection;
    private DataGridView dgSeizureList;
    private Button btnRecordSeizure;
    private Button btnSeizureReport;
    private Button btnAddCareGiver;
    private Button btnAddPatient;
}