﻿using Estacionamento.Controller;
using Estacionamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estacionamento.Views
{
    public partial class ListarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            List<Cliente> lista = ctrl.Listar();

            gvListarC.DataSource = lista;
            gvListarC.DataBind();
        }

        protected void linkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastCliente.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            Cliente c = new Cliente();
            c.Nome = txtBNome.Text;

            if (c != null)
            {
                txtEdtCliente.Text = c.Nome;
                c = ctrl.BuscarCliente(c.Nome);


            }
        }

        protected void btnEditarC_Click(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            Cliente c = ctrl.BuscarCliente(txtBNome.Text);
            c.Nome = txtEdtCliente.Text;


            if (c != null)
            {
                c.Nome = txtEdtCliente.Text;
                ctrl.Editar(c);
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            Cliente c = ctrl.BuscarCliente(txtBNome.Text);
            c.Nome = txtExcCliente.Text;

            if (c != null)
            {
                c.Nome = txtExcCliente.Text;
                ctrl.Excluir(c);

            }

        }
    }
}