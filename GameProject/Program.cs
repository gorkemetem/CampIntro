using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Etem";
            gamer.LastName = "Irmak";
            gamer.BirthYear = 1998;
            gamer.TcNo = 12345;

            GamerManager gamermanager = new GamerManager(new UserValidationManager());
            gamermanager.Add(gamer);


            Kampanya kampanya = new Kampanya();
            kampanya.KampanyaAdı = "Kampanya";
            kampanya.KampanyaOrani = 50;

            KampanyaManager kampanyamanager = new KampanyaManager();
            kampanyamanager.Add(kampanya);


            GameSale gamesale = new GameSale();
            gamesale.GameName = "Oyun";
            gamesale.GamePrice = 1000;

            GameSaleManager gamesalemanager = new GameSaleManager(kampanya,gamesale);
            gamesalemanager.Sale(gamer);
            

        }
    }
}
