
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class clsLogAcessos {

	public clsLogAcessos() {
	}

	private int id;

	private clsPessoa id_pessoa;

	private DateTime datahora;

	private string usuario;

    public int Id { get => id; set => id = value; }
    public clsPessoa Id_pessoa { get => id_pessoa; set => id_pessoa = value; }
    public DateTime Datahora { get => datahora;}
    public string Usuario { get => usuario; set => usuario = value; }
}