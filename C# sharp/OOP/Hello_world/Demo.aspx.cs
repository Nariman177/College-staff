﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hello_world
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(DateTime.Now);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "hi, " + TextBox.DisabledCssClass;
        }
    }
}