using MetodoConstrutor;

//fontes é um avariavel do tipo Pessoa
// Pessoa fontes = new Pessoa("João", 17);

// fontes.Nome = "Lorenzo";
// fontes.Idade = 17;

// Console.WriteLine(@$"O objeto pessoa que criei é o {fontes.Nome} com a idade
// {fontes.Idade}");

// fontes.Nome = "Gustavo Oliveira";

// fontes.Nome = "Herique";
// fontes.ExibirDados();

// Console.WriteLine($"{fontes.Nome}");

//primeiro metodo contrutor da clase Pessoa3Sobrecarga
Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();

System.Console.WriteLine(@$"Primeira Pessoa cadastrada:
                            Nome: {PrimeiraPessoa.Nome}
                            Idade: {PrimeiraPessoa.Idade}
");

//segundo metodo contrutor da clase Pessoa3Sobrecarga
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Matheus Felix");

System.Console.WriteLine(@$"Segunda Pessoa cadastrada:
                            Nome: {SegundaPessoa.Nome}
                            Idade: {SegundaPessoa.Idade}
");

//Atividade: Peça o nome e a idade da terceira pessoa pelo terminal
//Atribui os valores digitados ao objeto TerceiraPessoa

//terceiro metodo contrutor da clase Pessoa3Sobrecarga
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Felipe Silva", 16);
System.Console.WriteLine("Digite o seu nome");
TerceiraPessoa.Nome = Console.ReadLine();
System.Console.WriteLine("Digite o seu nome");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

System.Console.WriteLine(@$"Terceira Pessoa cadastrada:
                            Nome: {TerceiraPessoa.Nome}
                            Idade: {TerceiraPessoa.Idade}
");