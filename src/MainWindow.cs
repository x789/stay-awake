// Copyright 2021 by TillW
// Licensed to you under the MIT License
namespace StayAwake
{
	using StayAwake.Properties;
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public partial class MainWindow : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern ExecutionState SetThreadExecutionState(ExecutionState flags);

        public MainWindow()
        {
            this.InitializeComponent();
            this.AllowDisplaySleep.Checked = Settings.Default.AllowDisplaySleep;
            this.ApplySettings();
        }

        private void HandleChangedSettings(object sender, EventArgs args)
        {
            this.ApplySettings();
        }

        private void ApplySettings()
        {
            ExecutionState state = ExecutionState.Continuous | ExecutionState.SystemRequired;
            if (!this.AllowDisplaySleep.Checked)
            {
                state |= ExecutionState.DisplayRequired;
            }

            SetThreadExecutionState(state);
        }

        private void HandleFormClosing(object sender, FormClosingEventArgs e)
        {
            SetThreadExecutionState(ExecutionState.Continuous);
            Settings.Default.AllowDisplaySleep = this.AllowDisplaySleep.Checked;
            Settings.Default.Save();
        }
    }
}
