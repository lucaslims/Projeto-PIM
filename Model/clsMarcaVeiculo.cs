
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class clsMarcaVeiculo
{

    public clsMarcaVeiculo()
    {
    }

    private int id_marca;

    private string desc_marca;

    private clsTipoVeiculo tipoveiculo;

    private clsModeloVeiculo modeloveiculo;

    public int Id_marca { get => id_marca; set => id_marca = value; }
    public string Desc_marca { get => desc_marca; set => desc_marca = value; }
    public clsTipoVeiculo Tipoveiculo { get => tipoveiculo; set => tipoveiculo = value; }
    public clsModeloVeiculo Modeloveiculo { get => modeloveiculo; set => modeloveiculo = value; }

    public void MarcaVeiculo()
    {
        // TODO implement here
    }

}