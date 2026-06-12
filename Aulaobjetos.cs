public class Aluno
{
    public String Nome { get; }
    public int Idade { get; }
    public Aluno(String nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}


public class livro
{
    public String Titulo;
    public String Autor;
    public int Ano;

    public livro(String titulo, String autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }
}