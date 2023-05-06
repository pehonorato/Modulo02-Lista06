interface FormaGeometrica {
    double calcularArea(double base, double altura);
}

class Quadrado implements FormaGeometrica {
    @Override
    public double calcularArea(double base, double altura) {
        return base * altura;
    }
}

class Triangulo implements FormaGeometrica {
    @Override
    public double calcularArea(double base, double altura) {
        return (base * altura) / 2;
    }
}
