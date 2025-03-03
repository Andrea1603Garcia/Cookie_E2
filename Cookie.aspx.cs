using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_E2_4955454
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Response.Redirect
    (
"Cookies2.aspx" + "?ddlCategory=" + ddlCategory.SelectedValue + "&ddlSupplier=" + ddlSupplier.SelectedValue + "&txtProducto=" + txtProduct.Text + "&txtDescripcion=" + txtDescripcion.Text + "&txtImagen=" + txtImagen.Text + "&decprice=" + txtPrice.Text + "&byNumberInStock=" + txtNumberInStock.Text + "&byNumberOnOrder=" + txtNumberOnOrder.Text + "&byReorderLevel=" + txtNumberOnOrder.Text);

        }
    }
}