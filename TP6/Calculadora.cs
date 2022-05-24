public class Calculadora {

    public double Resultado;

    public Calculadora(double valorInicial) {
        Resultado = valorInicial;
    }

    public void Sumar(double termino) {
        Resultado += termino;
    }

    public void Restar(double termino) {
        Resultado -= termino;
    }

    public void Multiplicar(double termino) {
        Resultado *= termino;
    }

    public void Dividir(double termino) {
        Resultado /= termino;
    }

    public void Limpiar() {
        Resultado = 0;
    }
}