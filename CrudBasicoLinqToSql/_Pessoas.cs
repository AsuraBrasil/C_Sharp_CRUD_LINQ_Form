using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBasicoLinqToSql
{
    class _Pessoas
    {
        //Atributos globais encapsulados
        private string nome;
        private string sobreNome;
        private string rua;
        private string bairro;
        private string cidade;
        private string uf;
        private string telefone;
        private string celular;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string SobreNome
        {
            get { return sobreNome; }
            set { sobreNome = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        // Método interno para salvar dados
        public bool SalvarPessoa()
        {
            try
            {
                ClasseLinqDataContext dc = new ClasseLinqDataContext();

                Pessoa pessoa = new Pessoa(); //Objeto pessoa da base de dados
                pessoa.Nome = nome.Trim();
                pessoa.SobreNome = sobreNome.Trim();
                pessoa.Rua = rua.Trim();
                pessoa.Bairro = bairro.Trim();
                pessoa.Cidade = cidade.Trim();
                pessoa.Uf = uf.Trim();
                pessoa.Telefone = telefone.Trim();
                pessoa.Celular = celular.Trim();
                dc.Pessoas.InsertOnSubmit(pessoa);
                dc.SubmitChanges();
                
                dc.Dispose(); //DataContext são consideradas "Unidades de Trabalho, sendo assim, 
                              //sempre que instancia-la e terminar de utiliza-la, descarte-a.
                              //Uns falam isso por boa prática, outros por estética e outros dizem que é para limpar da cache o DataContext. Mas sei lá, aprendi assim. xD
                              
                return true; //Retorna verdadeiro no caso bem sucedido
            }
            catch (Exception)
            {
                return false; //Retorna falso caso ocorra uma excessão
                throw;
            }
        }

        // Método interno para excluir dados
        public bool ExcluirPessoa(uint id)
        {
            try
            {
                ClasseLinqDataContext dc = new ClasseLinqDataContext();
                Pessoa pessoa = new Pessoa();
                var pesquisa = from Pessoa in dc.Pessoas
                               where Pessoa.IdPessoa == id
                               select Pessoa;
                pessoa = pesquisa.Single();

                dc.Pessoas.DeleteOnSubmit(pessoa);
                dc.SubmitChanges();

                dc.Dispose();
                
                return true; //Retorna verdadeiro no caso bem sucedido
            }
            catch (Exception)
            {
                return false; //Retorna falso caso ocorra uma excessão
                throw;
            }
        }

        // Método interno para alterar dados
        public bool AlterarPessoa(uint id)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                ClasseLinqDataContext dc = new ClasseLinqDataContext();
                var pesquisa = from Pessoa in dc.Pessoas
                               where Pessoa.IdPessoa == id
                               select Pessoa;
                pessoa = pesquisa.Single();

                pessoa.Nome = nome.Trim();
                pessoa.SobreNome = sobreNome.Trim();
                pessoa.Rua = rua.Trim();
                pessoa.Bairro = bairro.Trim();
                pessoa.Cidade = cidade.Trim();
                pessoa.Uf = uf.Trim();
                pessoa.Telefone = telefone.Trim();
                pessoa.Celular = celular.Trim();

                dc.SubmitChanges();

                dc.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
