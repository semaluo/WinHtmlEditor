﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinHtmlEditor;

namespace WinHtmlEditorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.htmlEditor1.BodyInnerHTML = "sunzq";
            this.htmlEditor1.FontName = new FontFamily("Arial");
            this.htmlEditor1.FontSize = FontSize.Seven;
        }
    }
}
