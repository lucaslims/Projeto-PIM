
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class clsVeiculo
{

    public clsVeiculo()
    {
    }

    private int id;

    private string placa_vec;

    private int chassi_vec;

    private string descricao;

    private clsCorVeiculo corveiculo;

    private clsMarcaVeiculo marcaveiculo;

    private clsModeloVeiculo modeloveiculo;

    private clsTipoVeiculo tipoveiculo;

    private clsStatusVeiculo statusveiculo;

    public string Placa_vec { get => placa_vec; set => placa_vec = value; }
    public int Chassi_vec { get => chassi_vec; set => chassi_vec = value; }
    public clsCorVeiculo Corveiculo { get => corveiculo; set => corveiculo = value; }
    public clsMarcaVeiculo Marcaveiculo { get => marcaveiculo; set => marcaveiculo = value; }
    public clsModeloVeiculo Modeloveiculo { get => modeloveiculo; set => modeloveiculo = value; }
    public clsTipoVeiculo Tipoveiculo { get => tipoveiculo; set => tipoveiculo = value; }
    public clsStatusVeiculo Statusveiculo { get => statusveiculo; set => statusveiculo = value; }
    public int Id { get => id; set => id = value; }
    public string Descricao { get => descricao; set => descricao = value; }

    public void Veiculo()
    {
        // TODO implement here
    }

}