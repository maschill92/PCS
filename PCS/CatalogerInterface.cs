﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS
{
    public partial class CatalogerInterface : Form
    {
        DataCataloger dataCataloger;
        public CatalogerInterface(DataCataloger dc)
        {
            dataCataloger = dc;
            InitializeComponent();
        }

    }
}
