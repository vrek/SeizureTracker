﻿namespace SeizureTrackerWinUI;
public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        _ = new HttpClient();

    }
}
