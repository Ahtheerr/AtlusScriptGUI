﻿using AtlusScriptGUI;
using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AtlusScriptGUI
{
    public partial class MainForm : MetroSetForm
    {
        public static Version version = new Version(3, 4);
        public Config settings = new Config();

        public MainForm(string[] args)
        {
            InitializeComponent();
            settings = settings.LoadJson();
            if (!settings.DarkMode)
                Theme.ThemeStyle = MetroSet_UI.Enums.Style.Light;
            Theme.ApplyToForm(this);
            MenuStripHelper.SetMenuStripIcons(MenuStripHelper.GetMenuStripIconPairs("Icons.txt"), this);

            ApplyCheckboxStates();
            SetDropDowns();
            SetLogging();
            
            this.Text += $" v{version.Major}.{version.Minor}";
        }
    }
}
