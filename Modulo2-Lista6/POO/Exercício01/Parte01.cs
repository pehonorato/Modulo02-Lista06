abstract class Veiculo {
    private int id;
    private int velocidadeAtual;
    private int velocidadeMaxima;
    private int precisaoEmCurvas;
    private boolean estaComFarolLigado;


    public Veiculo() {}

    public Veiculo(int id, int velocidadeMaxima, int precisaoEmCurvas) {
        this.id = id;
        this.velocidadeAtual = 0;
        this.velocidadeMaxima = velocidadeMaxima;
        this.precisaoEmCurvas = precisaoEmCurvas;
        this.estaComFarolLigado = false;
    }


    public void acelerar() {
        this.velocidadeAtual++;
        if (this.velocidadeAtual > this.velocidadeMaxima) {
            this.velocidadeAtual = this.velocidadeMaxima;
        }
    }

    public void desacelerar() {
        this.velocidadeAtual--;
        if (this.velocidadeAtual < 0) {
            this.velocidadeAtual = 0;
        }
    }

    public void ligarFarol() {
        this.estaComFarolLigado = true;
    }


    public abstract void utilizarHabilidadeEspecial();
}

class Moto extends Veiculo {


    public Moto() {}

    public Moto(int id, int velocidadeMaxima, int precisaoEmCurvas) {
        super(id, velocidadeMaxima, precisaoEmCurvas);
    }

    @Override
    public void utilizarHabilidadeEspecial() {
        System.out.println("Moto ultrapassou o adversário à frente");
    }
}

class Carro extends Veiculo {


    public Carro() {}

    public Carro(int id, int velocidadeMaxima, int precisaoEmCurvas) {
        super(id, velocidadeMaxima, precisaoEmCurvas);
    }

    @Override
    public void utilizarHabilidadeEspecial() {
        System.out.println("Carro fechou o adversário de trás");
    }
}
