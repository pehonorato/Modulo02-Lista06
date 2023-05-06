let listaPessoas = [
    {nome: "Ana", sobrenome: "Silva", idade: 25},
    {nome: "João", sobrenome: "Santos", idade: 18},
    {nome: "Maria", sobrenome: "Souza", idade: 30},
    {nome: "Pedro", sobrenome: "Oliveira", idade: 16},
    {nome: "Mariana", sobrenome: "Ferreira", idade: 20},
];


function verificaMaiorIdade(lista) {
    for(let pessoa of lista) {
        if(pessoa.idade >= 18) {
            console.log(`Seja bem vindo(a)! Você se chama ${pessoa.nome} ${pessoa.sobrenome} - e tem ${pessoa.idade} anos e é maior de idade.`);
        } else {
            console.log(`Seja bem vindo(a)! Você se chama ${pessoa.nome} ${pessoa.sobrenome} - e tem ${pessoa.idade} anos e não é maior de idade.`);
        }
    }
}


function verificaNome(lista) {
    for(let pessoa of lista) {
        let nomeCompleto = pessoa.nome + " " + pessoa.sobrenome;
        if(nomeCompleto.length < 3) {
            console.log("Erro! Nome inválido, nome e sobrenome devem ser maiores que 3 caracteres.");
        } else if(nomeCompleto.length > 50) {
            console.log("Erro! Nome inválido, nome e sobrenome devem ser menores que 50 caracteres.");
        }
    }
}


function numeroPessoas(lista) {
    return lista.length;
}


verificaMaiorIdade(listaPessoas);
verificaNome(listaPessoas);
console.log("Número de pessoas na lista: " + numeroPessoas(listaPessoas));
