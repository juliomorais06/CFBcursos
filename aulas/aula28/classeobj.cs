//classe é um tipo de dado composto por membros
//os membros são a variáveis e os métodos(funções)
//classe é a base do objeto, é o que define o comportamento dos objetos
//a partir de uma classe pode-se instanciar quantos objetos forem necessários
//os objetos são independentes um do outro pois são alocados em posições diferentes de memória

/*[ModificadorClasse] class NOME_DA_CLASSE{
    //Variáveis / propriedades
    [EspecificadorAcesso] retorno NOME_MÉTODO([arg1,...]){
        //Corpo do método
    }
}

//ModificadorClasse: Define a visibilidade da classe
    //public: Pública, sem restrição de visualização
    //abstract: Classe-Base para outras classes, não podem ser
        //instanciados objetos desta classe
    //sealed: Classe não pode ser herdada
    //static: Classe não permite a instanciação de objetos e seus membros devem ser static

//EspecificadorAcesso: Onde um membro da classe pode ser acessado
    //public: Sem restrição de acesso
    //private: Só podem ser acessado pela própria classe
    //protected: Podem ser acessados na própria classe e nas classes derivadas
    //abstract: Os métodos não tem implementação somente os cabeçalhos
    //sealed: O método não pode ser redefinido
    //virtual: o método pode ser redefinido em uma classe derivada
    //static: O método pode ser chamado mesmo sem a instanciação de um objeto