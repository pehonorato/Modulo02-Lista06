public class Main {
    public static void main(String[] args) {
        Moto moto = new Moto(1, 200, 80);
        Carro carro = new Carro(2, 300, 70);

        moto.utilizarHabilidadeEspecial();
        carro.utilizarHabilidadeEspecial();
    }
}
