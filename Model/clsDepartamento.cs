
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class clsDepartamento {

	public clsDepartamento() {
	}

	private int id;

	private string descricao;

    public int Id { get => id; set => this.id = value; }
    public string Descricao { get => descricao; set => this.descricao = value; }
}