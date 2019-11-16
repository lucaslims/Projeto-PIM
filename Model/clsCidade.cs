
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class clsCidade {

	public clsCidade() {
	}

    private int id;

    private string descricao;

    private clsEstado estado;

    private double iss;

    public int Id { get => id; set => id = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public clsEstado Estado { get => estado; set => estado = value; }
    public double Iss { get => iss; set => iss = value; }
}