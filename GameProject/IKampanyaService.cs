using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IKampanyaService
    {
        void Add(Kampanya kampanya);
        void Update(Kampanya kampanya);
        void Delete(Kampanya kampanya);
    }
}
