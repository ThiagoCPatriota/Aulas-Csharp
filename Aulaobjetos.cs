public class Aluno
{
    public String Nome { get; }
    public int Idade { get; }
    public Double Saldo { get; set; }
    public Aluno(String nome, int idade, Double saldo)
    {
        Nome = nome;
        Idade = idade;
        Saldo = saldo;
    }

    public void depositar(Aluno aluno, Double deposito)
    {
        aluno.Saldo += deposito;
    }

    public void sacar(Aluno aluno, Double saque)
    {
        if (saque > Saldo)
        {
            return;
        }

        aluno.Saldo -= saque;
    }

    public void transferir(Double transferencia, Aluno aluno_que_envia, Aluno aluno_que_recebe)
    {
        if (transferencia > Saldo)
        {
            return;
        }

        depositar(aluno_que_recebe, transferencia);
        sacar(aluno_que_envia, transferencia);
    }
}


public class livro
{
    public String Titulo { get; }
    public String Autor { get; }
    public int Ano { get; }

    public livro(String titulo, String autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }
}
