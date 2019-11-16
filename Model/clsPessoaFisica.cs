
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class clsPessoaFisica {

	public clsPessoaFisica() {
	}

    private int id;

	private int cpf;

	private int rg;

	private DateTime dt_nasc;

	private clsCnh cnh;

	private clsPessoa id_pessoa;

    
    public int Id { get => id; set => id = value; }
    public int Cpf { get => cpf; set => cpf = value; }
    public int Rg { get => rg; set => rg = value; }
    public DateTime Dt_nasc { get => dt_nasc; set => dt_nasc = value; }
    public clsCnh Cnh { get => cnh; set => cnh = value; }
    public clsPessoa Id_pessoa { get => id_pessoa; set => id_pessoa = value; }

    private void PessoaFisica() {
		// TODO implement here
	}

}