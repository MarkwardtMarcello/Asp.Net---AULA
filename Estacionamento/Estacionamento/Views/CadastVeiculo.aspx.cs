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
    public partial class CadastVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (!IsPostBack)
            {
                VeiculoController ctrl = new VeiculoController();
                dropdwClietV.DataSource = ctrl.Listar();
                dropdwClietV.DataBind();
            }
            */
            
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            VeiculoController ctrl = new VeiculoController();
            Veiculo v = new Veiculo();
            v.Modelo = txtNomeV.Text;
            v.Cor = txtVCor.Text;
            v.ClienteId = int.Parse(dropdwClietV.SelectedItem.Value);
            ctrl.Adicionar(v);

        }

       
    }
}