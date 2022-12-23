namespace Ucu.Poo.Defense
{
    public interface IPublicationItem
    {
        int SubTotal { get; }
    }
    //Aqui se aplico el patron DIP debido a que la clase PublicationDiscount y PublicationItem depende de una abstraccion IPublicationItem
    //y no hay un dependencia entre clases como sucedia antes, ahora las clases pueden tener cambios sin afectar a las otras
    // por consecuencia, por lo que se cumpple el patron DIP
}