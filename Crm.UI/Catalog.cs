﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crm.UI
{
    public partial class Catalog<T> : Form
    {
        public Catalog(DbSet<T> set)
        {
            InitializeComponent();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }
    }
}
