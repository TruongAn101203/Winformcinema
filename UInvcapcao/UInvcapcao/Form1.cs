﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UInvcapcao
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        bool phimCollapse;
        public Form1()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //set the minimum and maximum of sidebar panel

             if(sidebarExpand)
            {
                //if sidebar expand, minimize
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width) 
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true  ;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest 
            sidebarTimer.Start();
        }

        private void phimTimer_Tick(object sender, EventArgs e)
        {
            //if sidebar expand, minimize
            if (phimCollapse)
            {
                pnlPhim.Height += 30;
                if(pnlPhim.Height == pnlPhim.MaximumSize.Height)
                {
                    phimCollapse = false;
                    phimTimer.Stop();
                }
            }else
                {
                pnlPhim.Height -= 30;
                if (pnlPhim.Height == pnlPhim.MinimumSize.Height)
                {
                    phimCollapse = true;
                    phimTimer.Stop();
                }
            }
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest 
            phimTimer.Start();
        }
    }
}
