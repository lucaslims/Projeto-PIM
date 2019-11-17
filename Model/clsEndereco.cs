
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class clsEndereco {

	public clsEndereco() {
	}

    private int id;

    private clsPessoa pessoa;

    private clsCidade cidade;

    private string logradouro;

    private int numero;

    private string complemento;

    private string cep;

    private string bairro;

    public int Id { get => id; set => id = value; }
    public clsPessoa Pessoa { get => pessoa; set => pessoa = value; }
    public clsCidade Cidade { get => cidade; set => cidade = value; }
    public string Logradouro { get => logradouro; set => logradouro = value; }
    public int Numero { get => numero; set => numero = value; }
    public string Complemento { get => complemento; set => complemento = value; }
    public string Cep { get => cep; set => cep = value; }
    public string Bairro { get => bairro; set => bairro = value; }
}