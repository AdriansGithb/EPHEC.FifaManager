﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace MatchManager_UI.Inscription
{
    public partial class frmTeamSelection : Form
    {
        private MdlMatchList slctdMatch;
        public frmTeamSelection(MdlMatchList slctdMatch)
        {
            InitializeComponent();
            this.slctdMatch = slctdMatch;
            lblMatch.Text = slctdMatch.NomString;
            btnEqpDom.Text = slctdMatch.Nom_EqpDom;
            btnEqpVisit.Text = slctdMatch.Nom_EqpVisit;
        }
    }
}
