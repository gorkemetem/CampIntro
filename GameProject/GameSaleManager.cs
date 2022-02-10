using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSaleManager : IGameSaleService
    {
        Kampanya _kampanya = new Kampanya();
        GameSale _gamesale = new GameSale();

        public GameSaleManager(Kampanya kampanya, GameSale gamesale)
        {
            _kampanya = kampanya;
            _gamesale = gamesale;
        }

        public void Sale(Gamer gamer)
        {
            int price = _gamesale.GamePrice - ((_gamesale.GamePrice * _kampanya.KampanyaOrani)/100);
            Console.WriteLine(_gamesale.GameName+" "+gamer.FirstName+" tarafından satın alındı.\nÖnceki fiyat: "+_gamesale.GamePrice+" TL\nİndirim oranı : %"+_kampanya.KampanyaOrani+ "\nİndirimli fiyat: "+price+" TL");
        }
    }
}
