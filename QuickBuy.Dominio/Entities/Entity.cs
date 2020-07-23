using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    //classe abstract n pode ser instanciada
    public abstract class Entity
    {
        //Nessa classe mãe nós vamos definir o que as outras entidades devem seguir

        public List<string> _validationMessages { get; set; }

        //Private para que ele não possa ser acessado de fora, só poderá ser adicionada mensagem pelo método AddMessage
        //Quando é private posso colocar tudo em minúsculo
        private List<string> validationMessage
        {
            get
            {
                //verificando se a variável _validationMessages está vazia com o operador ?? (verifica se tem conteudo)
                //se ela estiver vazia será devolvida uma instância dela mesmo que sem elementos (como entre parenteses)
                return _validationMessages ?? (_validationMessages = new List<string>());
                //Não há necessidade de criar construtor pq a propriedade _validationMessages se tiver
                //vazia, vai ser instanciada
            }
        }

        //Limpar mensagens:
        protected void ClearValidationMessages()
        {
            validationMessage.Clear();
        }

        //Adicionar Mensagem:
        protected void AddValidationMessage(string message)
        {
            validationMessage.Add(message);
        }

        //Quando eu coloco abstract no metodo, eu forço para que as classes filhas implementem ele:
        public abstract void Validate();

        protected bool IsValid 
        {
            get
            {
                //Uma classe é válida se não possui nenhuma mensagem de validação
                //Any = serve para falar se existe algum registro no banco com a condição que for colocada nele:
                { return !validationMessage.Any(); }
            }
        }
    }
}
