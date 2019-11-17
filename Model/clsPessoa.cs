
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class clsPessoa
{

    public clsPessoa()
    {
    }

    private int id;

    private string nome;

    private clsStatus statusPessoa;

    public int Id { get => id; set => this.id = value; }
    public string Nome { get => nome; set => this.nome = value; }
    public clsStatus StatusPessoa { get => statusPessoa; set => this.statusPessoa = value; }
}