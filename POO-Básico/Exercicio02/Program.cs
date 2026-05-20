//Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
Carro uno = new Carro();
uno.acelerar();
uno.frear();
uno.buzinar();

Carro celta = new Carro();
celta.acelerar();
celta.frear();
celta.buzinar();

class Carro
{
    public void acelerar()
    {
        Console.WriteLine("Acelerando");
    }

    public void frear()
    {
        Console.WriteLine("Freando");
    }

    public void buzinar()
    {
        Console.WriteLine("Buzinando");
    }
}