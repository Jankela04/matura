using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace B11
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PostaviDestinacije();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prognoza.Src = ("https://naslovi.net/vremenska-prognoza/" + DropDownList1.Text).Replace(' ', '-');
            PostaviDestinacije();
        }
        
        protected void PostaviDestinacije()
        {
            txtRenderOnme.Text = "<a href=\"#\" onclick=\"javascript:window.open('" + DropDownList1.Text + ".aspx" + "','','left=250px, top=245px, width=700px, height=450px, scrollbars=no, status=no, resizable=no');return false;\">Дестинације</a>";
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}